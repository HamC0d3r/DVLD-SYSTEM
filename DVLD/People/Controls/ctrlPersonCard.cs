using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DLVD_Project
{
    public partial class ctrlPersonCard : UserControl
    {
        public int PersonID = -1;
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public clsPeople LoadPersonInfo(int PersonID)
        {
            this.PersonID = PersonID;
            //this function respose to fill data from DataBase
            
            clsPeople Person = clsPeople.Find(PersonID);

            if (Person != null)
            {
                lbPersonID.Text = PersonID.ToString();
                lbName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                lbNatonalNo.Text = Person.NatonalNo;
                lbGendor.Text = (Person.Gendor == 0 ? "Mail" : "Femail");
                lbEmail.Text = Person.Email;
                lbAddress.Text = Person.Address;
                lbDateOfBirth.Text = Person.DateOfBirth.ToString("yyyy-MM-dd");
                lbPhone.Text = Person.Phone;
                
                clsCountry country = clsCountry.FindByCountryID(Person.NationalityCountryID);
                lbCounrty.Text = country.CountryName;

                try
                {
                    pbPersonalImg.Load(Person.ImagePath);
                }
                catch (Exception)
                {
                    //defualt image if the image is null or if happed any error
                    pbPersonalImg.Image = Properties.Resources.man;
                }

                return Person;
            }


            return null;

        }

        public clsPeople LoadPersonInfo(string NationalNo)
        {
            
            //this function respose to fill data from DataBase

            clsPeople Person = clsPeople.FindByNationalNo(NationalNo);
            PersonID = Person.PersonID;

            if (Person != null)
            {
                lbPersonID.Text = Person.PersonID.ToString();
                lbName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                lbNatonalNo.Text = Person.NatonalNo;
                lbGendor.Text = (Person.Gendor == 0 ? "Mail" : "Femail");
                lbEmail.Text = Person.Email;
                lbAddress.Text = Person.Address;
                lbDateOfBirth.Text = Person.DateOfBirth.ToString("yyyy-MM-dd");
                lbPhone.Text = Person.Phone;

                clsCountry country = clsCountry.FindByCountryID(Person.NationalityCountryID);
                lbCounrty.Text = country.CountryName;

                try
                {
                    pbPersonalImg.Load(Person.ImagePath);
                }
                catch (Exception)
                {
                    //defualt image if the image is null or if happed any error
                    pbPersonalImg.Image = Properties.Resources.man;
                }

                return Person;
            }


            return null;

        }

        private void lblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddEditPersonInfo(PersonID);
            frm.ShowDialog();
            LoadPersonInfo(PersonID);
        }
    }
}
