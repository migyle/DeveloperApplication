namespace DeveloperApplication
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.groupboxPasswordRecovery = new System.Windows.Forms.GroupBox();
            this.pnlNewPass = new System.Windows.Forms.Panel();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.txtRecoveryCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.devApp1 = new DeveloperApplication.DevApp();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter1 = new DeveloperApplication.DevAppTableAdapters.DeveloperTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupboxPasswordRecovery.SuspendLayout();
            this.pnlNewPass.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(135, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(140, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email Address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(152, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(74, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(150, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dont have an account?";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSignUp.Location = new System.Drawing.Point(285, 377);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(86, 16);
            this.lblSignUp.TabIndex = 6;
            this.lblSignUp.Text = "Sign-Up here";
            this.lblSignUp.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblForgotPassword.Location = new System.Drawing.Point(84, 252);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(110, 16);
            this.lblForgotPassword.TabIndex = 8;
            this.lblForgotPassword.Text = "forgot password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePassword.Location = new System.Drawing.Point(314, 162);
            this.btnTogglePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(38, 46);
            this.btnTogglePassword.TabIndex = 20;
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.UseVisualStyleBackColor = true;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // groupboxPasswordRecovery
            // 
            this.groupboxPasswordRecovery.Controls.Add(this.pnlNewPass);
            this.groupboxPasswordRecovery.Controls.Add(this.btnTogglePassword);
            this.groupboxPasswordRecovery.Controls.Add(this.btnRecovery);
            this.groupboxPasswordRecovery.Controls.Add(this.txtRecoveryCode);
            this.groupboxPasswordRecovery.Controls.Add(this.label2);
            this.groupboxPasswordRecovery.Location = new System.Drawing.Point(7, 56);
            this.groupboxPasswordRecovery.Name = "groupboxPasswordRecovery";
            this.groupboxPasswordRecovery.Size = new System.Drawing.Size(383, 390);
            this.groupboxPasswordRecovery.TabIndex = 21;
            this.groupboxPasswordRecovery.TabStop = false;
            this.groupboxPasswordRecovery.Text = "PASSWORD RECOVERY";
            this.groupboxPasswordRecovery.Visible = false;
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.Controls.Add(this.btnUpdatePassword);
            this.pnlNewPass.Controls.Add(this.button1);
            this.pnlNewPass.Controls.Add(this.txtConfirmPass);
            this.pnlNewPass.Controls.Add(this.label7);
            this.pnlNewPass.Controls.Add(this.txtNewPassword);
            this.pnlNewPass.Controls.Add(this.label5);
            this.pnlNewPass.Location = new System.Drawing.Point(10, 78);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(367, 195);
            this.pnlNewPass.TabIndex = 6;
            this.pnlNewPass.Visible = false;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(74, 155);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(284, 37);
            this.btnUpdatePassword.TabIndex = 25;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "👁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(32, 116);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(243, 29);
            this.txtConfirmPass.TabIndex = 23;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirm New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(32, 44);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(243, 29);
            this.txtNewPassword.TabIndex = 21;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Password";
            // 
            // btnRecovery
            // 
            this.btnRecovery.Location = new System.Drawing.Point(130, 233);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(132, 40);
            this.btnRecovery.TabIndex = 5;
            this.btnRecovery.Text = "Enter";
            this.btnRecovery.UseVisualStyleBackColor = true;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // txtRecoveryCode
            // 
            this.txtRecoveryCode.Location = new System.Drawing.Point(67, 169);
            this.txtRecoveryCode.Name = "txtRecoveryCode";
            this.txtRecoveryCode.Size = new System.Drawing.Size(227, 29);
            this.txtRecoveryCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter recovery code below";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.groupboxPasswordRecovery);
            this.pnlLogin.Controls.Add(this.lblForgotPassword);
            this.pnlLogin.Controls.Add(this.lblSignUp);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtEmail);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblEmail);
            this.pnlLogin.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.Location = new System.Drawing.Point(1031, 264);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(393, 412);
            this.pnlLogin.TabIndex = 22;
            // 
            // devApp1
            // 
            this.devApp1.DataSetName = "DevApp";
            this.devApp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.devApp1;
            this.bindingSource1.Position = 0;
            // 
            // developerTableAdapter1
            // 
            this.developerTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DeveloperApplication.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 842);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 842);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupboxPasswordRecovery.ResumeLayout(false);
            this.groupboxPasswordRecovery.PerformLayout();
            this.pnlNewPass.ResumeLayout(false);
            this.pnlNewPass.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private DevApp devApp1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevAppTableAdapters.DeveloperTableAdapter developerTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.GroupBox groupboxPasswordRecovery;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.TextBox txtRecoveryCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNewPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

