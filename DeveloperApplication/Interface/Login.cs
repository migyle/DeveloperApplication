using DeveloperApplication.Business;
using DeveloperApplication.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DeveloperApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            developerTableAdapter1.Fill(devApp1.Developer);
        }

        public static class Globals
        {
            public static int devID { get; set; } // Static variable to hold the developer ID  
            public static string devName { get; set; }// Static variable to hold the developer name  

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter both Email and Password.");
                    return;
                }

                var hasher = new PasswordHasher<string>();

                // Retrieves user by email
                developerTableAdapter1.VerifyEmail(devApp1.Developer, txtEmail.Text);

                if (devApp1.Developer.Rows.Count > 0)
                {
                    // retrieves the stored hashed password from DB
                    string storedHash = devApp1.Developer.Rows[0]["password"].ToString();

                    // Verifies entered password against the stored hashed password
                    var result = hasher.VerifyHashedPassword(null, storedHash, txtPassword.Text);

                    if (result == PasswordVerificationResult.Success)
                    {
                        Globals.devID = devApp1.Developer.Rows[0].Field<int>("devID");
                        Globals.devName = devApp1.Developer.Rows[0].Field<string>("name") + " " + devApp1.Developer.Rows[0].Field<string>("surname");

                        MessageBox.Show("Login successful! Welcome, " + devApp1.Developer.Rows[0].Field<string>("name"));

                        //frmHome home = get();
                        //home.PerformLogin();




                        frmMyProjects myProjects = new frmMyProjects();
                        myProjects.MdiParent = this.MdiParent;
                        myProjects.Show();

                        frmHome mainForm = (frmHome)this.MdiParent;
                        mainForm.PerformLogin();


                    }
                    else
                    {
                        MessageBox.Show("Login failed! Incorrect password.");
                    }
                }
                else
                {
                    MessageBox.Show("Login failed! Email not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login:\n" + ex.Message);
            }

        }
        
        private void label2_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.Show();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
