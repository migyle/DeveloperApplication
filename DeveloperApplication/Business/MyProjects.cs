using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DeveloperApplication.Interface.Validation;
namespace DeveloperApplication.Business
{
    public partial class frmMyProjects : Form
    {
        public frmMyProjects()
        {
            InitializeComponent();
        }

        private void frmMyProjects_Load(object sender, EventArgs e)
        {
            projectTableAdapter.FillByDevID(devApp1.Project, frmLogin.Globals.devID);
            commentTableAdapter.FillByProjID(devApp1.Comment, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));


        }

        private void dgvMyProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMTitle.Text = dgvMyProjects.CurrentRow.Cells[2].Value.ToString();
            txtMDescrip.Text = dgvMyProjects.CurrentRow.Cells[3].Value.ToString();
            cmbMStage.Text = dgvMyProjects.CurrentRow.Cells[4].Value.ToString();
            txtMSupport.Text = dgvMyProjects.CurrentRow.Cells[5].Value.ToString();
            dtpMStartDate.Value = Convert.ToDateTime(dgvMyProjects.CurrentRow.Cells[6].Value);
            dtpMEndDate.Value = Convert.ToDateTime(dgvMyProjects.CurrentRow.Cells[7].Value);

            if (dgvMyProjects.CurrentRow.Cells[8].Value.ToString() == "True")
            {
                chkMYes.Checked = true;
                chkMNo.Checked = false;
            }
            else
            {
                chkMNo.Checked = true;
                chkMYes.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try {

                
                string error = "";
                bool er = false;
                if (!string.IsNullOrEmpty(txtMTitle.Text) && !string.IsNullOrEmpty(txtMDescrip.Text) &&
                !string.IsNullOrEmpty(cmbMStage.Text) && !string.IsNullOrEmpty(txtMSupport.Text) &&
                !string.IsNullOrEmpty(dtpMStartDate.Text) && !string.IsNullOrEmpty(dtpMStartDate.Text) &&
                (chkMYes.Checked || chkMNo.Checked))
                {
                    error+= "Please fill in all fields.\n";
                    er=true;
                }

                if (!UserValidation.ValidateString(txtMTitle.Text))
                {
                    error += "Title Error: Please ensure that the title does not contain any numericals.\n";
                    er=true;
                }

                if (!UserValidation.ValidateString(txtMDescrip.Text))
                {
                    error += "Description Error: Please ensure that the description does not contain any numericals.\n";
                    er = true;
                }

                if (!UserValidation.ValidateString(txtMSupport.Text))
                {
                    error += "Support Error: Please ensure that the support does not contain any numericals.\n";
                    er = true;
                }

                if (cmbMStage.SelectedIndex == -1) {
                    error+= "Please select a stage from the dropdown.\n";
                    er=true;
                }

                if (dtpMStartDate.Value > dtpMEndDate.Value)
                {
                    error += "Date Error: Start date cannot be after end date.\n";
                    er = true;
                }

                if (!chkMYes.Checked && !chkMNo.Checked)
                {
                    error += "Please select whether the project is completed or not.\n";
                    er = true;
                }

                if (er)
                {
                    MessageBox.Show(error);
                    return;
                }
                else {
                    if (chkMYes.Checked) {
                        projectTableAdapter.InsertQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, true);
                    }
                    else if (chkMNo.Checked) {
                        projectTableAdapter.InsertQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, false);
                    }

                    MessageBox.Show("Project added successfully!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try {

                if (dgvMyProjects.CurrentRow == null)
                {
                    MessageBox.Show("Please select a project to update.");
                    return;
                }

                string error = "";
                bool er = false;
                if (!string.IsNullOrEmpty(txtMTitle.Text) && !string.IsNullOrEmpty(txtMDescrip.Text) &&
                !string.IsNullOrEmpty(cmbMStage.Text) && !string.IsNullOrEmpty(txtMSupport.Text) &&
                !string.IsNullOrEmpty(dtpMStartDate.Text) && !string.IsNullOrEmpty(dtpMStartDate.Text) &&
                (chkMYes.Checked || chkMNo.Checked))
                {
                    error += "Please fill in all fields.\n";
                    er = true;
                }

                if (!UserValidation.ValidateString(txtMTitle.Text))
                {
                    error += "Title Error: Please ensure that the title does not contain any numericals.\n";
                    er = true;
                }

                if (!UserValidation.ValidateString(txtMDescrip.Text))
                {
                    error += "Description Error: Please ensure that the description does not contain any numericals.\n";
                    er = true;
                }

                if (!UserValidation.ValidateString(txtMSupport.Text))
                {
                    error += "Support Error: Please ensure that the support does not contain any numericals.\n";
                    er = true;
                }

                if (cmbMStage.SelectedIndex == -1)
                {
                    error += "Please select a stage from the dropdown.\n";
                    er = true;
                }

                if (dtpMStartDate.Value > dtpMEndDate.Value)
                {
                    error += "Date Error: Start date cannot be after end date.\n";
                    er = true;
                }

                if (!chkMYes.Checked && !chkMNo.Checked)
                {
                    error += "Please select whether the project is completed or not.\n";
                    er = true;
                }

                if (er)
                {
                    MessageBox.Show(error);
                    return;
                }
                else
                {
                    if (chkMYes.Checked)
                    {
                        projectTableAdapter.UpdateQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, true, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    }
                    else if (chkMNo.Checked)
                    {
                        projectTableAdapter.UpdateQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, false, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    }

                    MessageBox.Show("Project updated successfully!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }
    }
}
