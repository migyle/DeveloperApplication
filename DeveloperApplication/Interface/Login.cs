using DeveloperApplication.Business;
using DeveloperApplication.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DeveloperApplication.Interface.Validation;

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

        //vzco wkmc glep pprq


       
        // Configure these with your email settings
        private const string SmtpServer = "smtp.gmail.com"; // or your SMTP server
        private const int SmtpPort = 587;
        private const string FromEmail = "projexion99@gmail.com"; // Your email
        private const string FromPassword = "vzco wkmc glep pprq"; // Your email password or app password

        public static async Task<bool> SendRecoveryCode(string toEmail, string recoveryCode)
        {
            try
            {
                using (var client = new SmtpClient(SmtpServer, SmtpPort))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(FromEmail, FromPassword);

                    var message = new MailMessage
                    {
                        From = new MailAddress(FromEmail),
                        Subject = "Password Recovery Code",
                        Body = $@"
                        <h2>Password Recovery</h2>
                        <p>You requested a password recovery for your account.</p>
                        <p>Your recovery code is: <strong>{recoveryCode}</strong></p>
                        <p>If you didn't request this, please ignore this email.</p>
                    ",
                        IsBodyHtml = true
                    };

                    message.To.Add(toEmail);

                    await client.SendMailAsync(message);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //public static string GenerateRecoveryCode()
        //{
        //    Random random = new Random();
        //    return random.Next(100000, 999999).ToString(); // 6-digit code
        //}
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

        public int recoveryCode;
        string toEmail;
        private async void lblForgotPassword_Click(object sender, EventArgs e)
            {

            try
            {
                //pnlLogin.Visible = false;
                toEmail = Prompt("Please enter your email address that is registered with the system.", "Password Recovery");
                int count = Convert.ToInt32(developerTableAdapter1.CountEmail(toEmail));


                if (count == 1)
                {
                    recoveryCode = new Random().Next(100000, 999999); // Generate a 6-digit code

                    try
                    {

                       bool emailSent =  await SendRecoveryCode(toEmail, recoveryCode.ToString());
                        if (emailSent) {
                            MessageBox.Show("Recovery code sent to your email address\n Please ensure you check your junk folder if you don't receive an email in your inbox.");
                        }
                        groupboxPasswordRecovery.Visible = true;
                        pnlLogin.Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending email:\n" + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Email Address is invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email:\n" + ex.ToString());
            }

        }

            private bool passwordVisible = false;
            private void btnTogglePassword_Click(object sender, EventArgs e)
            {

                passwordVisible = !passwordVisible;
                txtPassword.UseSystemPasswordChar = !passwordVisible;
            }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            if (txtRecoveryCode.Text == recoveryCode.ToString())
            {
                MessageBox.Show("Recovery code is correct. You can now reset your password.");
                pnlNewPass.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid recovery code.");
            }
        }

        private bool passwordVisible1 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            passwordVisible1 = !passwordVisible1;
            txtNewPassword.UseSystemPasswordChar = !passwordVisible1;
            txtConfirmPass.UseSystemPasswordChar = !passwordVisible1;
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
                    developerTableAdapter1.UpdatePassword(hash, toEmail);
                    MessageBox.Show("Your Password has been Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupboxPasswordRecovery.Visible = false;
                    pnlLogin.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the password:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text != txtPassword.Text || txtPassword.Text != txtConfirmPass.Text)
            {
                txtPassword.ForeColor = Color.DarkRed;
                txtConfirmPass.ForeColor = Color.DarkRed;
            }
            else
            {
                txtPassword.ForeColor = Color.DarkGreen;
                txtConfirmPass.ForeColor = Color.DarkGreen;
            }
        }
    }
}