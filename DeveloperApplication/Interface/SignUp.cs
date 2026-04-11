using DeveloperApplication.Business;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeveloperApplication.Interface.Validation;


namespace DeveloperApplication.Interface
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";
                bool er = false;
                string errorMessage = "";
                
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContact.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) || dtpDOB.Value == null)
                {
                    error += "Please fill in/ select all fields.\n";
                    er = true;
                 
                }

                // Name validation
                if (!UserValidation.ValidateName(txtName.Text, out errorMessage))
                {
                    error += "First Name Error: " + errorMessage + "\n";
                    er = true;
                }
                // Surname validation
                if (!UserValidation.ValidateName(txtSurname.Text, out errorMessage))
                {
                    error += "Surname Error: " + errorMessage + "\n";
                    er = true;
                }

                // Email validation
                if (!UserValidation.ValidateEmail(txtEmail.Text, out errorMessage))
                {
                    error += "Email Error: " + errorMessage + "\n";
                    er = true;
                }

                // Contact Number validation
                if (!UserValidation.ValidateContactNumber(txtContact.Text, out errorMessage))
                {
                    error += "Contact Number Error: " + errorMessage + "\n";
                    er = true;
                }

                // Date of Birth validation
                if (!UserValidation.ValidateDOB(dtpDOB.Value, out errorMessage))
                {
                    error += "Date of Birth Error: " + errorMessage + "\n";
                    er = true;
                }


                // Password validation
                if (!UserValidation.ValidatePassword(txtPassword.Text, out errorMessage))
                {
                    error += "Email Error: " + errorMessage + "\n";
                    er = true;
                }

            
                if (er == false)
                {

                    var hasher = new PasswordHasher<string>();
                    // Hashes Password entered to save it securely in the database
                    string hash = hasher.HashPassword(null, txtPassword.Text);

                    developerTableAdapter1.InsertQuery(txtName.Text, txtSurname.Text, txtEmail.Text, dtpDOB.Value, txtContact.Text, hash);
                    MessageBox.Show("Developer Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.MdiParent = this.MdiParent;
                    frmLogin.Show();

                }
                else
                {
                    MessageBox.Show(error, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
