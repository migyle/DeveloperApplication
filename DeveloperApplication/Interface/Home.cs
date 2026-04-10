using DeveloperApplication.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperApplication.Interface
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
            projectsToolStripMenuItem.Visible =false;
            logOutToolStripMenuItem.Visible = false;
            nameToolStripMenuItem.Visible = false;
        }

        public void FormSetup(Form myForm)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            myForm.MdiParent = this;
            msHome.Parent = this;
            myForm.WindowState = FormWindowState.Maximized;


            myForm.Show();
            //pictureBox1.SendToBack();
        }
        public void PerformLogin() {

            projectsToolStripMenuItem.Visible = true;
            otherProjectsToolStripMenuItem.Visible = true;
            nameToolStripMenuItem.Visible = true;
            nameToolStripMenuItem.Text = frmLogin.Globals.devName;
            logOutToolStripMenuItem.Visible = true;
            loginToolStripMenuItem1.Visible = false;

        }
        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            FormSetup(login);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            //pictureBox1.BringToFront();
            //pictureBox1.Dock = DockStyle.Fill;
            //msMain.Parent = pictureBox1;
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyProjects myProjects = new frmMyProjects();
            FormSetup(myProjects);
        }

        private void otherProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtherProjects frmOtherProjects = new frmOtherProjects();
            FormSetup(frmOtherProjects);
        }


        public void PerformLogout()
        {
            // Disable core menus
            projectsToolStripMenuItem.Visible = false;
            otherProjectsToolStripMenuItem.Visible = false;
            nameToolStripMenuItem.Visible = false;
            logOutToolStripMenuItem.Visible = false;
            loginToolStripMenuItem1.Visible = true;

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformLogout();
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            //pictureBox1.BringToFront();
            //pictureBox1.Dock = DockStyle.Fill;
            //msMain.Parent = pictureBox1;

            MessageBox.Show("You have been logged out successfully.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            FormSetup(profile);
        }
    }
}
