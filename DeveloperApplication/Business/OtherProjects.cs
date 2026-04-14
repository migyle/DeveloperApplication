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

namespace DeveloperApplication.Business
{
    public partial class frmOtherProjects : Form
    {
        public frmOtherProjects()
        {
            InitializeComponent();
            
        }

        private void frmOtherProjects_Load(object sender, EventArgs e)
        {
           
            projectTableAdapter.FillOtherProjects(devApp1.Project,frmLogin.Globals.devID);
            projectTableAdapter1.FillByMyCollabReq(devApp1.Project, frmLogin.Globals.devID);
            commentTableAdapter.FillByDevID(devApp1.Comment, frmLogin.Globals.devID);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                projectTableAdapter.FillOtherProjects(devApp1.Project, frmLogin.Globals.devID);
            }
        }

        private void rbMyCollabs_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMyCollabs.Checked)
            {
                projectTableAdapter.FillMyCollabs(devApp1.Project, frmLogin.Globals.devID);
            }
        }

        private void txtSearchProj_TextChanged(object sender, EventArgs e)
        {
            projectTableAdapter.SearchByOtherProj(devApp1.Project, txtSearchProj.Text);
        }

        private void dgvCollabReq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvOtherProjects.Rows) { 
            
                if (row.Cells[0].Value.ToString() == dgvCollabReq.CurrentRow.Cells[0].Value.ToString())
                {
                    row.Selected = true;
                    //dgvOtherProjects.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

        }

        private void btnRemoveReq_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Are you sure you want to remove this request?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            if (check == "Yes")
            {
                if (dgvCollabReq.CurrentRow == null)
                {
                    MessageBox.Show("Please select a collaboration request to remove.");
                    return;
                }
                collaborationTableAdapter1.UpdateQuery("Archived",frmLogin.Globals.devID,Convert.ToInt32(dgvCollabReq.CurrentRow.Cells[0].Value));
                MessageBox.Show("Collaboration request removed.");
                projectTableAdapter1.FillByMyCollabReq(devApp1.Project, frmLogin.Globals.devID);
            }
        }

        private void btnRequestCollab_Click(object sender, EventArgs e)
        {
            if (dgvOtherProjects.CurrentRow != null)
            {
                int projectId = Convert.ToInt32(dgvOtherProjects.CurrentRow.Cells[0].Value);
                collaborationTableAdapter1.InsertQuery(projectId, frmLogin.Globals.devID, "Requested");
                MessageBox.Show("Collaboration request sent.");
                projectTableAdapter1.FillByMyCollabReq(devApp1.Project, frmLogin.Globals.devID);
            }
            else { 
                MessageBox.Show("Please select a project to request collaboration on.");
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertComment_Click(object sender, EventArgs e)
        {
            try {
                if (dgvOtherProjects.CurrentRow != null && !string.IsNullOrWhiteSpace(rtbAddComment.Text))
                {
                    int projectId = Convert.ToInt32(dgvOtherProjects.CurrentRow.Cells[0].Value);
                    commentTableAdapter.InsertQuery(frmLogin.Globals.devID, projectId, rtbAddComment.Text, DateTime.Now, "Active");
                    commentTableAdapter.FillByDevID(devApp1.Comment, frmLogin.Globals.devID);
                    MessageBox.Show("Comment added.");
                    rtbAddComment.Clear();
                }
                else
                {
                    MessageBox.Show("Please select a project and enter a comment before submitting.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the comment: " + ex.Message);
                return;
            }
        
        }

        private void btnUpdateComment_Click(object sender, EventArgs e)
        {

            try
                {
                    if (dgvComments.CurrentRow != null && !string.IsNullOrWhiteSpace(rtbCommentDescription.Text))
                    {
                        int commentId = Convert.ToInt32(dgvComments.CurrentRow.Cells[0].Value);
                        commentTableAdapter.UpdateQuery(frmLogin.Globals.devID, Convert.ToInt32(dgvComments.CurrentRow.Cells[2].Value), rtbCommentDescription.Text, dtpDateCreated.Value, "Active", commentId);
                        commentTableAdapter.FillByDevID(devApp1.Comment, frmLogin.Globals.devID);
                        MessageBox.Show("Comment updated.");
                        rtbAddComment.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please select a comment and enter new text before updating.");
                    }
    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the comment: " + ex.Message);
                    return;
            }


        }

        private void btnArchiveComment_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Are you sure you want to archive this comment?", "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            if (check == "Yes")
            {
                if (dgvComments.CurrentRow != null)
                {
                    commentTableAdapter.UpdateQuery(frmLogin.Globals.devID, Convert.ToInt32(dgvComments.CurrentRow.Cells[2].Value), rtbCommentDescription.Text, dtpDateCreated.Value, "Archived", Convert.ToInt32(dgvComments.CurrentRow.Cells[0].Value));
                    commentTableAdapter.FillByDevID(devApp1.Comment, frmLogin.Globals.devID);
                    MessageBox.Show("Comment archived.");
                }
                else
                {
                    MessageBox.Show("Please select a comment to archive.");
                }
            } 
        }

        private void dgvOtherProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbCommentDescription.Text = dgvComments.CurrentRow.Cells[3].Value.ToString();
            dtpDateCreated.Value = Convert.ToDateTime(dgvComments.CurrentRow.Cells[4].Value);
        }

        private void dgvOtherProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitle.Text = dgvOtherProjects.CurrentRow.Cells[2].Value.ToString();
            txtDescrip.Text = dgvOtherProjects.CurrentRow.Cells[3].Value.ToString();
            cmbStage.Text = dgvOtherProjects.CurrentRow.Cells[4].Value.ToString();
            txtSupport.Text = dgvOtherProjects.CurrentRow.Cells[5].Value.ToString();
            dtpStartDate.Value = Convert.ToDateTime(dgvOtherProjects.CurrentRow.Cells[6].Value);
            dtpEndDate.Value = Convert.ToDateTime(dgvOtherProjects.CurrentRow.Cells[7].Value);
            cmbVisibility.Text = dgvOtherProjects.CurrentRow.Cells[9].Value.ToString();

            if (dgvOtherProjects.CurrentRow.Cells[8].Value.ToString() == "True")
            {
                chkYes.Checked = true;
                chkNo.Checked = false;
            }
            else
            {
                chkNo.Checked = true;
                chkYes.Checked = false;
            }
            developerTableAdapter.FillCollaborators(devApp1.Developer, Convert.ToInt32(dgvOtherProjects.CurrentRow.Cells[0].Value));
            commentTableAdapter.FillByDevID(devApp1.Comment, frmLogin.Globals.devID);
        }
    }
}
