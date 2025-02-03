using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVD_Project
{
    public partial class frmAddEditPersonInfo : Form
    {
        clsPeople Person;
        int PersonID;
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        string SaveImagePath = "";
        public frmAddEditPersonInfo()
        {
            InitializeComponent();

            Mode = enMode.AddNew;
        }
        public frmAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();

            this.PersonID = PersonID;
            Mode = enMode.Update;
        }

        //delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        private int _isMailOrFemail()
        {
            return (rdFemail.Checked ? 1 : 0);
        }

        private void _UploadPersonImage()
        {
            //btnRemoveImage.Enabled = false;

            //create OpenFileFialog
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.Title = "Upload Image";

            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|ALL files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //set image to my form
                pbPersonImage.Image = Image.FromFile(openFileDialog1.FileName);
                
                //user can remove uploaded image
                btnRemoveImage.Enabled = true;
            }
        }
        private bool _SavePersonImageInServer(string folderPath) 
        {
            bool isFoundImage = false;    
            
            string fileName = "";

            fileName = openFileDialog1.FileName;

            if (fileName != "") //if the user is uploaded personal photo
            {
                isFoundImage = true;

                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(openFileDialog1.FileName);

                SaveImagePath = Path.Combine(folderPath, newFileName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                pbPersonImage.Image.Save(SaveImagePath);
            }
         
            return isFoundImage;
        }
        private void _SetDefaultImage()
        {
            if (_isMailOrFemail() == 1)
            {
                pbPersonImage.Image = Properties.Resources.woman;
            }
            else
            {
                pbPersonImage.Image = Properties.Resources.man;
            }
            btnRemoveImage.Enabled = false;
        }

        private void _FillDataAdded(ref clsPeople Person) 
        {
            //fill Data in object And send to DataBase

            Person = new clsPeople();

            Person.NatonalNo = txtNationalNo.Text;
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecondName.Text;
            Person.ThirdName = txtThirdName.Text;
            Person.LastName = txtLastName.Text;
            Person.Phone = mtxtPhone.Text;
            Person.Address = txtAddress.Text;
            Person.Gendor = _isMailOrFemail();
            Person.Email = txtEmail.Text;
            Person.NationalityCountryID = (cbCountry.SelectedIndex + 1); // i encreased 1 on the cbCountry Index number Because the initial Index in CompoBox same Index in dataBase but decrease 1

            if (_SavePersonImageInServer("C:/DVLD-People-Images"))
                Person.ImagePath = SaveImagePath;
            else
                Person.ImagePath = null;


        }
        private void _FillDataUpdated(ref clsPeople Person) 
        {
            //fill Data in object And send to DataBase

            Person = new clsPeople(PersonID); // this line invoke paramitarize conestructor and fire Update Mode in Business

            Person.NatonalNo = txtNationalNo.Text;
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecondName.Text;
            Person.ThirdName = txtThirdName.Text;
            Person.LastName = txtLastName.Text;
            Person.Phone = mtxtPhone.Text;
            Person.Address = txtAddress.Text;
            Person.Gendor = _isMailOrFemail();
            Person.DateOfBirth = dtpDateOfBirth.Value;
            Person.Email = txtEmail.Text;
            Person.NationalityCountryID = (cbCountry.SelectedIndex + 1);
            
            if (_SavePersonImageInServer("C:/DVLD-People-Images")) // save new image on server
            {
                //Delete the The Last image from server  
                File.Delete(pbPersonImage.ImageLocation);
                //set new path image on database
                Person.ImagePath = SaveImagePath;
            }
            else
                Person.ImagePath = null;
            

        }
        private void _FillCountriesToComboBox() 
        {
            //fill countries on combobox from database
            DataTable AllCounties = clsCountry.GetAllCountries();
            foreach (DataRow row in AllCounties.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _FillDataOnForm(clsPeople PersonInfo) 
        {
            txtFirstName.Text = PersonInfo.FirstName;
            txtSecondName.Text = PersonInfo.SecondName;
            txtThirdName.Text = PersonInfo.ThirdName;
            txtLastName.Text = PersonInfo.LastName;
            mtxtPhone.Text = PersonInfo.Phone;
            txtEmail.Text = PersonInfo.Email;
            txtAddress.Text = PersonInfo.Address;
            txtNationalNo.Text = PersonInfo.NatonalNo;
            cbCountry.SelectedIndex = (PersonInfo.NationalityCountryID - 1);
            
            //set Gendor radio
            if (PersonInfo.Gendor == 1)
                rdFemail.Select();
            else
                rdMail.Select();

            //set image on Form:
            //this code not contain case state if the path is not found in server
            try
            {

                pbPersonImage.ImageLocation = PersonInfo.ImagePath;
            }
            catch (Exception)
            {
                _SetDefaultImage();
            }
        }
        private void _LoadData()
        {
            //fill all countries on compobox
            _FillCountriesToComboBox();

            //check Mode and change the lableMode
            if (Mode == enMode.AddNew)
            {

                //add person mode
                lbMode.Text = "Add New Person";

                _SetDefaultImage();

                //defult index country even to easy access them
                cbCountry.SelectedIndex = 89; //jordan
                
                //by defulte mail in Radio
                rdMail.Select();
            }
            else 
            { 
                //Update Person Mode
                lbMode.Text = "Update Person";
                lbPersonID.Text = PersonID.ToString();

                //get the information person from database
                clsPeople PersonInfo = clsPeople.Find(PersonID);
                _FillDataOnForm(PersonInfo);

            }
        }
        
        private void frmAddEditPersonInfo_Load(object sender, EventArgs e)
        { 
            //Load Defult Data on Form
            _LoadData();
        }


        private void rdFemail_CheckedChanged(object sender, EventArgs e)
        {
            //change the defualt image
            pbPersonImage.Image = Properties.Resources.woman;
        }

        private void rdMail_CheckedChanged(object sender, EventArgs e)
        {
            //change the defualt image
            pbPersonImage.Image = Properties.Resources.man;
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            _UploadPersonImage();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
                _FillDataAdded(ref Person);

            if (Mode == enMode.Update)
            {
                _FillDataUpdated(ref Person);

            }
                

            Person.Save(); // Save Data to DataBase and Server
            
            //get the new person id in data base
            PersonID = Person.PersonID;
            //show person id to user
            lbPersonID.Text = PersonID.ToString();

            MessageBox.Show("Completed Saving", "Done Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbPersonImage.Image = null;
            _SetDefaultImage();
        }

        private void btnClose_Click(object sender, EventArgs e)
        { 
            //Tigger the event to send data 
            DataBack?.Invoke(this, PersonID);

            this.Close();
        }
    }
}
