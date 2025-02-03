using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace DLVD_Project
{
    public class Logger 
    {
        //Define a delegate for log actions
        public delegate void LogAction(string message);

        //The log action that will be invoked
        private LogAction _logAction;

        public Logger(LogAction logAction) 
        {
            _logAction = logAction;
        }

        public void Log(string message) 
        { 
            _logAction(message); //_logAction?.Invoke(message)
        }

    };
    public partial class frmLogin : Form
    {
        private short Trials = 10;

        public frmLogin()
        {
            InitializeComponent();
        }

        private const string CSV_FILE_PATH = "users.csv";

        private static void LogToCSVFile(string csvLine) 
        {
            File.WriteAllText(CSV_FILE_PATH, csvLine);
        }
        public static void SaveUser(string username, string password)
        {
            Logger csvLogger = new Logger(LogToCSVFile);
            string csvLine = $"{username},{password}";
            csvLogger.Log(csvLine);
            
        }

        public static (string username, string password)? LoadUser()
        {
            if (File.Exists(CSV_FILE_PATH))
            {
                string[] lines = File.ReadAllLines(CSV_FILE_PATH);
                if (lines.Length > 0)
                {
                    string[] userData = lines[0].Split(',');
                    if (userData.Length >= 2)
                    {
                        return (userData[0], userData[1]);
                    }
                }
            }
            return null;
        }

        public static void DeleteSavedUser()
        {
            if (File.Exists(CSV_FILE_PATH))
            {
                File.Delete(CSV_FILE_PATH);
            }
        }

        private bool _Login() 
        {
            Global.CurrentUser = clsUsers.FindUserByUserNameAndPass(tbUserName.Text, tbPassword.Text);

            if(Trials == 0) 
            { // valdate the user trials
                MessageBox.Show("Please Try again letter.", "Over Trials", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }

            //Valedation user input 
            if (Global.CurrentUser == null) 
            {
                //current user is not fount 
                lbErrorText.Enabled = true;
                lbErrorText.Text = "[-] Invaled UserName OR Password.";
                
                return false;
            }
            else if(!Global.CurrentUser.IsActive) 
            {
                lbErrorText.Enabled = true;
                lbErrorText.Text = "[-] The User Is Not Active.";

                return false;
            }
            else 
            {     
                return true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login
            if (_Login()) 
            {
                //remember check
                if (cbRememberMe.Checked) 
                {
                    SaveUser(tbUserName.Text, tbPassword.Text);
                }
                else { DeleteSavedUser(); }

                this.Hide();  // Hide the login form

                // invoke the main screen
                Form frm = new Main();
                frm.ShowDialog();

                this.Close(); // Then close it
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //try remember the user
            var rememberedUser = LoadUser();
            if (rememberedUser != null) 
            {
                tbUserName.Text = rememberedUser.Value.username;
                tbPassword.Text = rememberedUser.Value.password;
            }
        }


    }
}
