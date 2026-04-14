using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeveloperApplication.Interface.Validation;

namespace DeveloperApplication.Business
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
            lblName.Parent = pictureBox1;
            grpDetails.Parent = pictureBox1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public string devPass;
        private void Profile_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'devApp1.Comment' table. You can move, or remove it, as needed.
            //this.commentTableAdapter.Fill(this.devApp1.Comment);
            //// TODO: This line of code loads data into the 'devApp1.Collaboration' table. You can move, or remove it, as needed.
            //this.collaborationTableAdapter.Fill(this.devApp1.Collaboration);
            lblName.Text = frmLogin.Globals.devName;
            developerTableAdapter1.FillByDevID(devApp1.Developer, frmLogin.Globals.devID);
            if (devApp1.Developer.Rows.Count == 1)
            {
                var row = devApp1.Developer.Rows[0];
                // pbStaffImage.Image = Image.FromFile(row["image"].ToString());
                txtName.Text = row["name"].ToString();
                txtSurname.Text = row["surname"].ToString();
                txtContact.Text = row["contactNumber"].ToString();
                txtEmail.Text = row["email"].ToString();
                dtpDOB.Value = Convert.ToDateTime(row["dateOfBirth"]);
                devPass = row["password"].ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpOtherProj_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";
                bool er = false;
                string errorMessage = "";

                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContact.Text) ||
                    dtpDOB.Value == null)
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

                if (er == false)
                {
                    developerTableAdapter1.UpdateDetails(txtName.Text, txtSurname.Text, txtEmail.Text, dtpDOB.Value, txtContact.Text, "Active", frmLogin.Globals.devID);
                    MessageBox.Show("Profile updated successfully.");
                    txtName.Enabled = false;
                    txtSurname.Enabled = false;
                    txtContact.Enabled = false;
                    txtEmail.Enabled = false;
                    dtpDOB.Enabled = false;
                    btnApply.Visible = false;
                    btnUpdate.Visible = true;
                    btnCancel.Visible = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to update your profile?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtContact.Enabled = true;
                txtEmail.Enabled = true;
                dtpDOB.Enabled = true;
                btnApply.Visible = true;
                btnUpdate.Visible = false;
                btnCancel.Visible = true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel the update?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtContact.Enabled = false;
                txtEmail.Enabled = false;
                dtpDOB.Enabled = false;
                btnApply.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = false;
            }
        }

        private string Prompt(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                Text = caption,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string password = Prompt("Please enter your current password:", "Password Authentication");
            var hasher = new PasswordHasher<string>();

            // Verifies entered password against the stored hashed password
            var result = hasher.VerifyHashedPassword(null, devPass, password);

            if (result == PasswordVerificationResult.Success)
            {
                MessageBox.Show("Password verified. You can now enter a new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupboxPasswordRecovery.Visible = true;
                grpDetails.Visible = false;
            }
            else { 
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                if (!UserValidation.ValidatePassword(txtNewPassword.Text, out errorMessage))
                {
                    MessageBox.Show("Password Error: " + errorMessage + "\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtConfirmPass.Text != txtNewPassword.Text || txtNewPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Password and Confirmed Password do not match.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    var hasher = new PasswordHasher<string>();
                    // Hashes Password entered to save it securely in the database
                    string hash = hasher.HashPassword(null, txtNewPassword.Text);
                    developerTableAdapter1.UpdateQuery(hash, frmLogin.Globals.devID);
                    MessageBox.Show("Your Password has been Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupboxPasswordRecovery.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the password:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to terminate your account? This action cannot be undone.", "Confirm Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                developerTableAdapter1.UpdateDetails(txtName.Text, txtSurname.Text, txtEmail.Text, dtpDOB.Value, txtContact.Text, "Archived", frmLogin.Globals.devID);
            }
        }

        private void btnCanelPass_Click(object sender, EventArgs e)
        {
            txtConfirmPass.Text = "";
            txtNewPassword.Text = "";
            groupboxPasswordRecovery.Visible = false;
            grpDetails.Visible = true;
        }
    }
}
