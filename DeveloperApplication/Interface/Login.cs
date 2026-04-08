using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        public static class Globals
        {
            public static int devID { get; set; } // Static variable to hold the developer ID  
            public static string devName { get; set; }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            developerTableAdapter1.verifyLogin(devApp1.Developer,txtEmail.Text,txtPassword.Text);
            if (devApp1.Developer.Rows.Count == 1) { 
                Globals.devID = devApp1.Developer.Rows[0].Field<int>("DeveloperID");
                Globals.devName = devApp1.Developer.Rows[0].Field<string>("DeveloperName");
            }
            
        }
    }
}
