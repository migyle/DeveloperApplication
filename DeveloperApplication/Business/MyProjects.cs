using DeveloperApplication.DevAppTableAdapters;
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
            milestoneTableAdapter.FillByProjID(devApp1.Milestone, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
            developerTableAdapter.FillCollaborators(devApp1.Developer, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));

        }

        private void dgvMyProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try {

                
                string error = "";
                bool er = false;
                if (!string.IsNullOrEmpty(txtMTitle.Text) && !string.IsNullOrEmpty(txtMDescrip.Text) &&
                !string.IsNullOrEmpty(cmbMStage.Text) && !string.IsNullOrEmpty(txtMSupport.Text) &&
                !string.IsNullOrEmpty(dtpMStartDate.Text) && !string.IsNullOrEmpty(dtpMStartDate.Text) &&
                !string.IsNullOrEmpty(cmbVisibility.Text) && !chkMYes.Checked && !chkMNo.Checked)
                {
                    error+= "Please fill in all fields.\n";
                    er=true;
                }

                //if (!UserValidation.ValidateString(txtMTitle.Text))
                //{
                //    error += "Title Error: Please ensure that the title does not contain any numericals.\n";
                //    er=true;
                //}

                //if (!UserValidation.ValidateString(txtMDescrip.Text))
                //{
                //    error += "Description Error: Please ensure that the description does not contain any numericals.\n";
                //    er = true;
                //}

                //if (!UserValidation.ValidateString(txtMSupport.Text))
                //{
                //    error += "Support Error: Please ensure that the support does not contain any numericals.\n";
                //    er = true;
                //}

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

                if (cmbVisibility.SelectedIndex == -1)
                {
                    error += "Please select a visibility option from the dropdown.\n";
                    er = true;
                }

                if (er)
                {
                    MessageBox.Show(error);
                    return;
                }
                else {
                    if (chkMYes.Checked) {
                        projectTableAdapter.InsertQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, true, cmbVisibility.Text, "Active");
                        projectTableAdapter.FillByDevID(devApp1.Project, frmLogin.Globals.devID);
                    }
                    else if (chkMNo.Checked) {
                        projectTableAdapter.InsertQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, false, cmbVisibility.Text, "Active");
                        projectTableAdapter.FillByDevID(devApp1.Project, frmLogin.Globals.devID);
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
                !string.IsNullOrEmpty(cmbVisibility.Text) && !chkMYes.Checked && !chkMNo.Checked )
                {
                    error += "Please fill in all fields.\n";
                    er = true;
                }

                //if (!UserValidation.ValidateString(txtMTitle.Text))
                //{
                //    error += "Title Error: Please ensure that the title does not contain any numericals.\n";
                //    er = true;
                //}

                //if (!UserValidation.ValidateString(txtMDescrip.Text))
                //{
                //    error += "Description Error: Please ensure that the description does not contain any numericals.\n";
                //    er = true;
                //}

                //if (!UserValidation.ValidateString(txtMSupport.Text))
                //{
                //    error += "Support Error: Please ensure that the support does not contain any numericals.\n";
                //    er = true;
                //}

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

                    if (cmbVisibility.SelectedIndex == -1)
                    {
                        error += "Please select a visibility option from the dropdown.\n";
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
                        projectTableAdapter.UpdateQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, true, cmbVisibility.Text,"Active", Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                        projectTableAdapter.FillByDevID(devApp1.Project, frmLogin.Globals.devID);
                    }
                    else if (chkMNo.Checked)
                    {
                        projectTableAdapter.UpdateQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, false, cmbVisibility.Text,"Active", Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                        projectTableAdapter.FillByDevID(devApp1.Project, frmLogin.Globals.devID);
                    }

                    MessageBox.Show("Project updated successfully!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure you want to archive this project? This action cannot be undone.", "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            else if (dgvMyProjects.CurrentRow == null)
            {
                MessageBox.Show("Please select a project to archive.");
                return;
            }
            else if (result == DialogResult.Yes)
            {
                projectTableAdapter.UpdateQuery(frmLogin.Globals.devID, txtMTitle.Text, txtMDescrip.Text, cmbMStage.Text, txtMSupport.Text, dtpMStartDate.Value, dtpMEndDate.Value, true, cmbVisibility.Text, "Archived", Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                projectTableAdapter.FillByDevID(devApp1.Project, frmLogin.Globals.devID);
                MessageBox.Show("Project archived successfully!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMTitle.Text = "";
            txtMDescrip.Text = "";
            cmbMStage.Text = "";
            txtMSupport.Text = "";
            dtpMStartDate.Value = DateTime.Now;
            dtpMEndDate.Value = DateTime.Now;
            cmbVisibility.Text = "";
            chkMNo.Checked = false;
            chkMYes.Checked = false;
            dgvMyProjects.ClearSelection();
        }

        private void txtProjTitleSearch_TextChanged(object sender, EventArgs e)
        {
            projectTableAdapter.SearchByProjTitle(devApp1.Project, frmLogin.Globals.devID,txtProjTitleSearch.Text);
        }

        private void dgvMyProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMTitle.Text = dgvMyProjects.CurrentRow.Cells[2].Value.ToString();
            txtMDescrip.Text = dgvMyProjects.CurrentRow.Cells[3].Value.ToString();
            cmbMStage.Text = dgvMyProjects.CurrentRow.Cells[4].Value.ToString();
            txtMSupport.Text = dgvMyProjects.CurrentRow.Cells[5].Value.ToString();
            dtpMStartDate.Value = Convert.ToDateTime(dgvMyProjects.CurrentRow.Cells[6].Value);
            dtpMEndDate.Value = Convert.ToDateTime(dgvMyProjects.CurrentRow.Cells[7].Value);
            cmbVisibility.Text = dgvMyProjects.CurrentRow.Cells[9].Value.ToString();

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
            commentTableAdapter.FillByProjID(devApp1.Comment, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
            milestoneTableAdapter.FillByProjID(devApp1.Milestone, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
            developerTableAdapter.FillCollaborators(devApp1.Developer, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
        }

        private void chkMYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMYes.Checked)
            {
                chkMNo.Checked = false;
            }
            else if (!chkMYes.Checked)
            {
                chkMNo.Checked = true;
            }
        }

        private void chkMNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMNo.Checked)
            {
                chkMYes.Checked = false;
            }
            else if (!chkMNo.Checked)
            {
                chkMYes.Checked = true;
            }
        }

        private void dgvComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            var output = commentDetailsTableAdapter1.GetCommentDetails( Convert.ToInt32(dgvComments.CurrentRow.Cells[0].Value));
            txtDevName.Text = output[0].name + " " + output[0].surname;
            txtProjTitle.Text = output[0].title;
            rtbDescrip.Text = output[0].description;
        }


        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            try {

                commentTableAdapter.FilterByDateCreated(devApp1.Comment, dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));

            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                commentTableAdapter.FilterByDateCreated(devApp1.Comment, dtpStartDate.Value, dtpEndDate.Value, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked) {
                developerTableAdapter.FillCollaborators(devApp1.Developer, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
            }
        }

        private void rbRequests_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRequests.Checked)
            {
                developerTableAdapter.FillByRequestedCollab(devApp1.Developer, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));

                if (dgvDevCollab.Rows.Count == 0)
                {
                    MessageBox.Show("There are currently no collaboration requests for this project.");
                    btnApprove.Visible = false;
                    btnDeny.Visible = false;
                }
                else
                {
                    btnApprove.Visible = true;
                    btnDeny.Visible = true;
                }

            }
            else
            {
                btnApprove.Visible = false;
                btnDeny.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try
            {

                string error = "";
                bool er = false;
                if (!string.IsNullOrEmpty(cmbProjTitle.Text) && !string.IsNullOrEmpty(txtMilestoneTitle.Text) &&
                !string.IsNullOrEmpty(dtpDateAchieved.Text) && !string.IsNullOrEmpty(cmbStatus.Text))
                {
                    error += "Please fill in all Milestone fields.\n";
                    er = true;
                }

                if (dtpDateAchieved.Value < Convert.ToDateTime(dgvMyProjects.CurrentRow.Cells[6].Value))
                {
                    error += "Date Error: Achieved date cannot be before the project start date.\n";
                    er = true;
                }

                if (cmbProjTitle.SelectedIndex == -1)
                {
                    error += "Please select a project title from the dropdown.\n";
                    er = true;
                }

                if (cmbStatus.SelectedIndex == -1)
                {
                    error += "Please select a status from the dropdown.\n";
                    er = true;
                }

                if (er)
                {
                    MessageBox.Show(error);
                    return;
                }
                else
                {
                    milestoneTableAdapter.InsertQuery(Convert.ToInt32(cmbProjTitle.SelectedValue), txtMilestoneTitle.Text, dtpDateAchieved.Value, cmbStatus.Text);
                    milestoneTableAdapter.FillByProjID(devApp1.Milestone, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Milestone added successfully for Project: '" + cmbProjTitle.Text + "'!");
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdateMilestone_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";
                bool er = false;
                if (!string.IsNullOrEmpty(cmbProjTitle.Text) && !string.IsNullOrEmpty(txtMilestoneTitle.Text) &&
                !string.IsNullOrEmpty(dtpDateAchieved.Text) && !string.IsNullOrEmpty(cmbStatus.Text))
                {
                    error += "Please fill in all Milestone fields.\n";
                    er = true;
                }

                if (dtpDateAchieved.Value < Convert.ToDateTime(dgvMyProjects.CurrentRow.Cells[6].Value))
                {
                    error += "Date Error: Achieved date cannot be before the project start date.\n";
                    er = true;
                }

                if (cmbProjTitle.SelectedIndex == -1)
                {
                    error += "Please select a project title from the dropdown.\n";
                    er = true;
                }

                if (cmbStatus.SelectedIndex == -1)
                {
                    error += "Please select a status from the dropdown.\n";
                    er = true;
                }

                if (er)
                {
                    MessageBox.Show(error);
                    return;
                }
                else
                {
                    milestoneTableAdapter.UpdateQuery(Convert.ToInt32(cmbProjTitle.SelectedValue), txtMilestoneTitle.Text, dtpDateAchieved.Value, cmbStatus.Text, Convert.ToInt32(dgvMilestones.CurrentRow.Cells[0].Value));
                    milestoneTableAdapter.FillByProjID(devApp1.Milestone, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Milestone '"+txtMilestoneTitle.Text+"' updated successfully for Project: '" + cmbProjTitle.Text + "'!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnArchiveMilestone_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to archive this milestone? This action cannot be undone.", "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgvMilestones.CurrentRow == null)
                {
                    MessageBox.Show("Please select a milestone to archive.");
                    return;
                }
                else
                {
                    milestoneTableAdapter.UpdateQuery(Convert.ToInt32(cmbProjTitle.SelectedValue), txtMilestoneTitle.Text, dtpDateAchieved.Value, "Archived", Convert.ToInt32(dgvMilestones.CurrentRow.Cells[0].Value));
                    milestoneTableAdapter.FillByProjID(devApp1.Milestone, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Milestone '" + txtMilestoneTitle.Text + "' archived successfully for Project: '" + cmbProjTitle.Text + "'!");
                }
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            cmbProjTitle.SelectedIndex = -1;
            txtMilestoneTitle.Text = "";
            cmbStatus.SelectedIndex = -1;
            dtpDateAchieved.Value = DateTime.Now;
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (dgvDevCollab.CurrentRow == null)
            {
                MessageBox.Show("Please select a collaboration request to deny.");
                return;
            }
            else if (dgvMyProjects.CurrentRow == null)
            {
                MessageBox.Show("Please select a project to deny collaboration request.");
                return;
            }
            else
            {
                var check = MessageBox.Show("Are you sure you want to deny this collaboration request?", "Confirm Denial", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (check == "No")
                {
                    return;
                }
                else if (check == "Yes")
                {
                    collaborationTableAdapter.UpdateQuery("Denied", frmLogin.Globals.devID, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    developerTableAdapter.FillCollaborators(devApp1.Developer, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Collaboration request denied successfully!");
                }


            }

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvDevCollab.CurrentRow == null)
            {
                MessageBox.Show("Please select a collaboration request to approve.");
                return;
            }
            else if (dgvMyProjects.CurrentRow == null)
            {
                MessageBox.Show("Please select a project for the collaboration request.");
                return;
            }
            else
            {
                var check = MessageBox.Show("Are you sure you want to approve this collaboration request?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (check == "No")
                {
                    return;
                }else if (check == "Yes")
                {
                    collaborationTableAdapter.UpdateQuery("Approved", frmLogin.Globals.devID, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    developerTableAdapter.FillCollaborators(devApp1.Developer, Convert.ToInt32(dgvMyProjects.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Collaboration request approved successfully!");
                }
          
                
            }
        }
    }
}
    

