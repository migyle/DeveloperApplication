using DeveloperApplication.DevAppTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DeveloperApplication.Business
{
    public partial class frmCelebrationWall : Form
    {
        private LeaderboardTableAdapter leaderboardAdapter;
        private ProjectTrendsTableAdapter trendsAdapter;
         public frmCelebrationWall()
        {
            InitializeComponent();
            InitializeAdapters();
            gbLeaderboard.Parent = pictureBox1;
        }

        private void InitializeAdapters()
        {
            leaderboardAdapter = new LeaderboardTableAdapter();
            trendsAdapter = new ProjectTrendsTableAdapter();
        }

        private void CelebrationWall_Load(object sender, EventArgs e)
        {
            nudTopCount.Value = 10;
            rbBarChart.Checked = true;

            LoadLeaderboard();
           
        }

        private void LoadLeaderboard()
        {
            try
            {
                int topCount = (int)nudTopCount.Value;
                string searchTerm = string.IsNullOrWhiteSpace(txtSearch.Text) ? "" : txtSearch.Text;

                DevApp.LeaderboardDataTable data = leaderboardAdapter.GetData(topCount, "Active", searchTerm);

                dgvLeaderboard.DataSource = data;
                dgvLeaderboard.Refresh();
                Application.DoEvents();
                FormatLeaderboardGrid(data);

                UpdateChart(data);

                UpdateStatistics(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatLeaderboardGrid(DevApp.LeaderboardDataTable data)
        {
            if (dgvLeaderboard.Columns.Count == 0) return;

            if (dgvLeaderboard.Columns.Contains("name"))
                dgvLeaderboard.Columns["name"].HeaderText = "First Name";

            if (dgvLeaderboard.Columns.Contains("surname"))
                dgvLeaderboard.Columns["surname"].HeaderText = "Last Name";

            if (dgvLeaderboard.Columns.Contains("email"))
                dgvLeaderboard.Columns["email"].Visible = false;

            if (dgvLeaderboard.Columns.Contains("DeveloperStatus"))
                dgvLeaderboard.Columns["DeveloperStatus"].HeaderText = "Status";

            if (dgvLeaderboard.Columns.Contains("CompletedProjects"))
            {
                dgvLeaderboard.Columns["CompletedProjects"].HeaderText = "✅ Completed";
                dgvLeaderboard.Columns["CompletedProjects"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLeaderboard.Columns.Contains("ActiveProjects"))
            {
                dgvLeaderboard.Columns["ActiveProjects"].HeaderText = "🔄 Active";
                dgvLeaderboard.Columns["ActiveProjects"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLeaderboard.Columns.Contains("ArchivedProjects"))
            {
                dgvLeaderboard.Columns["ArchivedProjects"].HeaderText = "📦 Archived";
                dgvLeaderboard.Columns["ArchivedProjects"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLeaderboard.Columns.Contains("CompletionRate"))
            {
                dgvLeaderboard.Columns["CompletionRate"].HeaderText = "Rate (%)";
                dgvLeaderboard.Columns["CompletionRate"].DefaultCellStyle.Format = "0.0";
            }

            if (dgvLeaderboard.Columns.Contains("TotalProjects"))
                dgvLeaderboard.Columns["TotalProjects"].Visible = false;
            if (!dgvLeaderboard.Columns.Contains("Rank"))
            {
                DataGridViewTextBoxColumn rankCol = new DataGridViewTextBoxColumn
                {
                    Name = "Rank",
                    HeaderText = "Rank",
                    Width = 60,
                    ReadOnly = true
                };
                dgvLeaderboard.Columns.Insert(0, rankCol);
            }

            for (int i = 0; i < dgvLeaderboard.Rows.Count; i++)
            {
                if (i == 0)
                    dgvLeaderboard.Rows[i].Cells["Rank"].Value = "GOLD";
                else if (i == 1)
                    dgvLeaderboard.Rows[i].Cells["Rank"].Value = "SILVER";
                else if (i == 2)
                    dgvLeaderboard.Rows[i].Cells["Rank"].Value = "BRONZE";
                else
                    dgvLeaderboard.Rows[i].Cells["Rank"].Value = $"#{i + 1}";

                if (i == 0)
                    dgvLeaderboard.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 215, 0);
                else if (i == 1)
                    dgvLeaderboard.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);
                else if (i == 2)
                    dgvLeaderboard.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50);
            }
        }

        private void UpdateChart(DevApp.LeaderboardDataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                chartLeaderboard.Series.Clear();
                chartLeaderboard.Titles.Clear();
                return;
            }

            chartLeaderboard.Series.Clear();
            chartLeaderboard.Titles.Clear();

            Title mainTitle = new Title
            {
                Text = $"Top {Math.Min(data.Rows.Count, (int)nudTopCount.Value)} Developers",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Docking = Docking.Top
            };
            chartLeaderboard.Titles.Add(mainTitle);

            Series series = new Series("Completed Projects");
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series.ToolTip = "#VALX: #VAL projects completed";

            if (rbBarChart.Checked)
            {
                series.ChartType = SeriesChartType.Bar;
                series.Color = Color.FromArgb(52, 152, 219);
                series.LabelFormat = "{#} projects";
                series.LabelForeColor = Color.Black;

                chartLeaderboard.ChartAreas[0].Area3DStyle.Enable3D = false;
                chartLeaderboard.ChartAreas[0].AxisX.Interval = 1;
                chartLeaderboard.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
                chartLeaderboard.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
                chartLeaderboard.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                chartLeaderboard.ChartAreas[0].AxisX.LabelAutoFitMinFontSize = 7;
            }
            else if (rbColumnChart.Checked)
            {
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.FromArgb(46, 204, 113);
                series.LabelFormat = "{#}";
                series.LabelForeColor = Color.White;

                chartLeaderboard.ChartAreas[0].Area3DStyle.Enable3D = false;
                chartLeaderboard.ChartAreas[0].AxisX.Interval = 1;
                chartLeaderboard.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
                chartLeaderboard.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartLeaderboard.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                chartLeaderboard.ChartAreas[0].AxisX.LabelAutoFitMinFontSize = 7;
            }
            else if (rbPieChart.Checked)
            {
                series.ChartType = SeriesChartType.Pie;
                series.Label = "#PERCENT{P0}";
                series.LabelForeColor = Color.Black;
                series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                series["PieLabelStyle"] = "Outside";
                series["PieLineColor"] = "Black";
                series["PieStartAngle"] = "90";

                chartLeaderboard.ChartAreas[0].Area3DStyle.Enable3D = true;
                chartLeaderboard.ChartAreas[0].Area3DStyle.Inclination = 30;
                chartLeaderboard.ChartAreas[0].Area3DStyle.Rotation = 10;
                chartLeaderboard.ChartAreas[0].Area3DStyle.LightStyle = LightStyle.Realistic;

                mainTitle.Text = "Project Completion Distribution";
            }

            chartLeaderboard.Series.Add(series);

            int displayCount = Math.Min(data.Rows.Count, (int)nudTopCount.Value);



            for (int i = 0; i < displayCount; i++)
            {
                var row = data[i];
                string developerName = $"{row.name} {row.surname}";
                int completedProjects = row.CompletedProjects;

              
                if (developerName.Length > 20 && !rbPieChart.Checked)
                {
                    developerName = developerName.Substring(0, 18) + "...";
                }


                int pointIndex = series.Points.AddXY(developerName, completedProjects);
             
                if (!rbPieChart.Checked)
                {
                    if (i == 0)
                        series.Points[pointIndex].Color = Color.FromArgb(255, 215, 0); // Gold
                    else if (i == 1)
                        series.Points[pointIndex].Color = Color.FromArgb(192, 192, 192); // Silver
                    else if (i == 2)
                        series.Points[pointIndex].Color = Color.FromArgb(205, 127, 50); // Bronze
                }
                else
                {
                    
                    if (i == 0)
                        series.Points[pointIndex]["Exploded"] = "true";
                }
            }

            if (!rbPieChart.Checked)
            {
                chartLeaderboard.ChartAreas[0].AxisX.Title = "Developer";
                chartLeaderboard.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                chartLeaderboard.ChartAreas[0].AxisY.Title = "Projects Completed";
                chartLeaderboard.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                chartLeaderboard.ChartAreas[0].AxisY.Minimum = 0;

                chartLeaderboard.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                chartLeaderboard.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chartLeaderboard.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            }
            else
            {
                chartLeaderboard.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                chartLeaderboard.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;

                chartLeaderboard.Legends.Clear();
                Legend legend = new Legend
                {
                    Title = "Developers",
                    TitleFont = new Font("Segoe UI", 9, FontStyle.Bold),
                    Docking = Docking.Right,
                    Font = new Font("Segoe UI", 8)
                };
                chartLeaderboard.Legends.Add(legend);
                series.LegendText = "#VALX";
            }
        }

        private void UpdateStatistics(DevApp.LeaderboardDataTable data)
        {
            if (data.Rows.Count == 0)
            {
                lblTotalDevelopers.Text = "Developers: 0";
                lblTotalProjects.Text = "Completed: 0";
                lblAvgCompletionRate.Text = "Avg Rate: 0%";
                return;
            }

            int totalDevs = data.Rows.Count;
            int totalCompleted = 0;
            double totalRate = 0;

            foreach (var row in data)
            {
                totalCompleted += row.CompletedProjects;
                totalRate += (double)row.CompletionRate;
            }

            double avgRate = totalRate / totalDevs;

            lblTotalDevelopers.Text = $"Developers Count: {totalDevs}";
            lblTotalProjects.Text = $"Completed Projects: {totalCompleted}";
            lblAvgCompletionRate.Text = $"Avg Completion Rate: {avgRate:F1}%";
        }

        private void dgvLeaderboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilterType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        private void nudTopCount_ValueChanged(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        private void rbColumnChart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColumnChart.Checked && dgvLeaderboard.DataSource != null)
                LoadLeaderboard();
        }

        private void rbPieChart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPieChart.Checked && dgvLeaderboard.DataSource != null)
                LoadLeaderboard();
        }

        private void rbBarChart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBarChart.Checked && dgvLeaderboard.DataSource != null)
                LoadLeaderboard();
        }
    }
}