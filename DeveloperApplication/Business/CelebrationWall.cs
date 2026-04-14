using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeveloperApplication.Business
{
    public partial class frmCelebrationWall : Form
    {
        //// Declare TableAdapters
        //private devApp1TableAdapters.DeveloperTableAdapter developerAdapter;
        //private devApp1TableAdapters.ProjectTableAdapter projectAdapter;

        //// Declare DataTables to hold the data
        //private devApp1.DeveloperDataTable leaderboardData;
        //private devApp1.ProjectDataTable trendsData;

        public frmCelebrationWall()
        {
            InitializeComponent();
            //InitializeTableAdapters();
        }

        private void InitializeTableAdapters()
        {
            // Initialize the TableAdapters
            //developerAdapter = new devApp1TableAdapters.DeveloperTableAdapter();
            //projectAdapter = new devApp1TableAdapters.ProjectTableAdapter();
        }

        private void CelebrationWall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'devApp.Project' table. You can move, or remove it, as needed.
            //this.projectTableAdapter.Fill(this.devApp1.Project);
            // TODO: This line of code loads data into the 'devApp.Developer' table. You can move, or remove it, as needed.
            //this.developerTableAdapter.Fill(this.devApp1.Developer);
            // Load data when form loads
            //LoadLeaderboardData();
            //LoadTrendsData();

            //// Set default chart type
            //rbBarChart.Checked = true;
        }

        // ==================== LEADERBOARD METHODS ====================

        private void LoadLeaderboardData()
        {
            //try
            //{
            //    Cursor = Cursors.WaitCursor;
            //    //lblStatus.Text = "Loading leaderboard data...";
            //    //progressBar.Visible = true;

            //    // Get parameters from UI
            //    int topCount = (int)nudTopCount.Value;
            //    string filterType = cmbFilterType.SelectedItem?.ToString() ?? "All";
            //    string searchTerm = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text;

            //    // Call the FillLeaderboard query
            //    //leaderboardData = new devApp1.DeveloperDataTable();
            //    developerTableAdapter.FillLeaderboard(devApp1.Developer, topCount, filterType, searchTerm);

            //    // Bind to DataGridView
            //    //dgvLeaderboard.DataSource = leaderboardData;

            //    // Format the DataGridView
            //    FormatLeaderboardGrid();

            //    // Update the chart
            //    UpdateLeaderboardChart();

            //    // Update statistics labels
            //    UpdateStatistics();

            //    //lblStatus.Text = $"Loaded {leaderboardData.Rows.Count} developers successfully!";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error loading leaderboard: {ex.Message}", "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //lblStatus.Text = "Error loading leaderboard data";
            //}
            //finally
            //{
            //    Cursor = Cursors.Default;
            //    //progressBar.Visible = false;
            //}
        }

        private void FormatLeaderboardGrid()
        {
            //if (dgvLeaderboard.Columns.Count == 0) return;

            //// Hide unnecessary columns
            //if (dgvLeaderboard.Columns.Contains("devID"))
            //    dgvLeaderboard.Columns["devID"].HeaderText = "ID";

            //if (dgvLeaderboard.Columns.Contains("name"))
            //    dgvLeaderboard.Columns["name"].HeaderText = "First Name";

            //if (dgvLeaderboard.Columns.Contains("surname"))
            //    dgvLeaderboard.Columns["surname"].HeaderText = "Last Name";

            //if (dgvLeaderboard.Columns.Contains("email"))
            //    dgvLeaderboard.Columns["email"].Visible = false; // Hide email for space

            //if (dgvLeaderboard.Columns.Contains("DeveloperStatus"))
            //    dgvLeaderboard.Columns["DeveloperStatus"].HeaderText = "Status";

            //if (dgvLeaderboard.Columns.Contains("CompletedProjects"))
            //{
            //    dgvLeaderboard.Columns["CompletedProjects"].HeaderText = "✅ Completed";
            //    dgvLeaderboard.Columns["CompletedProjects"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}

            //if (dgvLeaderboard.Columns.Contains("ActiveProjects"))
            //{
            //    dgvLeaderboard.Columns["ActiveProjects"].HeaderText = "🔄 Active";
            //    dgvLeaderboard.Columns["ActiveProjects"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}

            //if (dgvLeaderboard.Columns.Contains("ArchivedProjects"))
            //{
            //    dgvLeaderboard.Columns["ArchivedProjects"].HeaderText = "📦 Archived";
            //    dgvLeaderboard.Columns["ArchivedProjects"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}

            //if (dgvLeaderboard.Columns.Contains("CompletionRate"))
            //{
            //    dgvLeaderboard.Columns["CompletionRate"].HeaderText = "Rate (%)";
            //    dgvLeaderboard.Columns["CompletionRate"].DefaultCellStyle.Format = "0.0";
            //}

            //if (dgvLeaderboard.Columns.Contains("TotalProjects"))
            //    dgvLeaderboard.Columns["TotalProjects"].Visible = false;

            //// Add rank column if it doesn't exist
            //if (!dgvLeaderboard.Columns.Contains("Rank"))
            //{
            //    DataGridViewTextBoxColumn rankColumn = new DataGridViewTextBoxColumn
            //    {
            //        Name = "Rank",
            //        HeaderText = "🏆 Rank",
            //        Width = 60,
            //        ReadOnly = true
            //    };
            //    dgvLeaderboard.Columns.Insert(0, rankColumn);
            //}

            //// Set rank values and color rows
            //for (int i = 0; i < dgvLeaderboard.Rows.Count; i++)
            //{
            //    // Set rank text
            //    string rank;
            //    switch (i)
            //    {
            //        case 0:
            //            rank = "🥇 GOLD";
            //            break;
            //        case 1:
            //            rank = "🥈 SILVER";
            //            break;
            //        case 2:
            //            rank = "🥉 BRONZE";
            //            break;
            //        default:
            //            rank = $"#{i + 1}";
            //            break;
            //    }
            //    dgvLeaderboard.Rows[i].Cells["Rank"].Value = rank;

            //    // Color the top 3 rows
            //    if (i == 0)
            //        dgvLeaderboard.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 215, 0); // Gold
            //    else if (i == 1)
            //        dgvLeaderboard.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192); // Silver
            //    else if (i == 2)
            //        dgvLeaderboard.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50); // Bronze
            //}
        }

        private void UpdateLeaderboardChart()
        {
        //    if (devApp1.Developer == null || devApp1.Developer.Rows.Count == 0)
        //    {
        //        chartLeaderboard.Series.Clear();
        //        return;
        //    }

        //    chartLeaderboard.Series.Clear();
        //    chartLeaderboard.Titles.Clear();

        //    // Add title
        //    Title title = new Title
        //    {
        //        Text = "Top Developer Performers",
        //        Font = new Font("Segoe UI", 12, FontStyle.Bold),
        //        Docking = Docking.Top
        //    };
        //    chartLeaderboard.Titles.Add(title);

        //    // Create series
        //    Series series = new Series("Completed Projects")
        //    {
        //        Font = new Font("Segoe UI", 8),
        //        IsValueShownAsLabel = true,
        //        LabelFormat = "{#} projects",
        //        ToolTip = "#VALX: #VAL completed projects"
        //    };

        //    // Set chart type based on radio button
        //    if (rbBarChart.Checked)
        //    {
        //        series.ChartType = SeriesChartType.Bar;
        //        series.Color = Color.FromArgb(52, 152, 219);
        //    }
        //    else if (rbColumnChart.Checked)
        //    {
        //        series.ChartType = SeriesChartType.Column;
        //        series.Color = Color.FromArgb(46, 204, 113);
        //    }
        //    else if (rbPieChart.Checked)
        //    {
        //        series.ChartType = SeriesChartType.Pie;
        //        series.Label = "#PERCENT{P0}";
        //        series.ToolTip = "#VALX: #VAL projects (#PERCENT{P0})";
        //        series["PieLabelStyle"] = "Outside";
        //        series["PieLineColor"] = "Black";
        //    }

        //    chartLeaderboard.Series.Add(series);

        //    // Add data points
        //    int displayCount = Math.Min(devApp1.Developer.Rows.Count, (int)nudTopCount.Value);
        //    for (int i = 0; i < displayCount; i++)
        //    {
        //        var row = devApp1.Developer[i];
        //        string developerName = $"{row.name} {row.surname}";
        //        int completedProjects = Convert.ToInt32(row[6]);

        //        DataPoint point = new DataPoint(i, completedProjects)
        //        {
        //            AxisLabel = developerName,
        //            Label = completedProjects.ToString(),
        //            ToolTip = $"{developerName}: {completedProjects} projects completed"
        //        };

        //        series.Points.Add(point);
        //    }

        //    // Customize chart area
        //    if (rbPieChart.Checked)
        //    {
        //        chartLeaderboard.ChartAreas[0].Area3DStyle.Enable3D = true;
        //        chartLeaderboard.ChartAreas[0].Area3DStyle.Inclination = 30;
        //    }
        //    else
        //    {
        //        chartLeaderboard.ChartAreas[0].AxisX.Title = "Developer";
        //        chartLeaderboard.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
        //        chartLeaderboard.ChartAreas[0].AxisY.Title = "Projects Completed";
        //        chartLeaderboard.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
        //    }
        }

        private void UpdateStatistics()
        {
            //    if (devApp1.Developer == null || devApp1.Developer.Rows.Count == 0)
            //    {
            //        lblTotalDevelopers.Text = "Total Developers: 0";
            //        lblTotalProjects.Text = "Total Completed Projects: 0";
            //        lblAvgCompletionRate.Text = "Avg Completion Rate: 0%";
            //        return;
            //    }

            //    int totalDevelopers = devApp1.Developer.Rows.Count;
            //    int totalCompletedProjects = devApp1.Developer.Sum(row => Convert.ToInt32(row[6]));
            //    double avgCompletionRate = devApp1.Developer.Average(row => Convert.ToDouble(row[7]));

            //    lblTotalDevelopers.Text = $"👥 Total Developers: {totalDevelopers}";
            //    lblTotalProjects.Text = $"✅ Total Completed Projects: {totalCompletedProjects}";
            //    lblAvgCompletionRate.Text = $"📈 Avg Completion Rate: {avgCompletionRate:F1}%";
        }

        // ==================== TRENDS METHODS ====================

        private void LoadTrendsData()
        {
            //try
            //{
            //    Cursor = Cursors.WaitCursor;
            //    //lblStatus.Text = "Loading trends data...";

            //    // Call the FillProjectTrends query
            //    //trendsData = new devApp1.ProjectDataTable();
            //    projectTableAdapter.FillProjectTrends(devApp1.Project);

            //    // Bind to DataGridView
            //    //dgvTrends.DataSource = devApp1.Project;

            //    // Format trends grid
            //    FormatTrendsGrid();

            //    // Update trends chart
            //    UpdateTrendsChart();

            //    //lblStatus.Text = $"Loaded {trendsData.Rows.Count} months of trend data!";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error loading trends: {ex.Message}", "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //lblStatus.Text = "Error loading trends data";
            //}
            //finally
            //{
            //    Cursor = Cursors.Default;
            //}
        }

        private void FormatTrendsGrid()
        {
            //if (dgvTrends.Columns.Count == 0) return;

            //// Format column headers
            //if (dgvTrends.Columns.Contains("Year"))
            //    dgvTrends.Columns["Year"].HeaderText = "Year";

            //if (dgvTrends.Columns.Contains("Month"))
            //    dgvTrends.Columns["Month"].HeaderText = "Month";

            //if (dgvTrends.Columns.Contains("ProjectsStarted"))
            //    dgvTrends.Columns["ProjectsStarted"].HeaderText = "📊 Started";

            //if (dgvTrends.Columns.Contains("ProjectsCompleted"))
            //    dgvTrends.Columns["ProjectsCompleted"].HeaderText = "✅ Completed";

            //if (dgvTrends.Columns.Contains("CompletionRate"))
            //{
            //    dgvTrends.Columns["CompletionRate"].HeaderText = "Rate (%)";
            //    dgvTrends.Columns["CompletionRate"].DefaultCellStyle.Format = "0.0";
            //}

            //// Add month name column for better readability
            //if (!dgvTrends.Columns.Contains("MonthName"))
            //{
            //    DataGridViewTextBoxColumn monthNameColumn = new DataGridViewTextBoxColumn
            //    {
            //        Name = "MonthName",
            //        HeaderText = "Month Name",
            //        Width = 100
            //    };
            //    dgvTrends.Columns.Insert(1, monthNameColumn);
            //}

            //// Set month names
            //for (int i = 0; i < dgvTrends.Rows.Count; i++)
            //{
            //    int month = Convert.ToInt32(dgvTrends.Rows[i].Cells["Month"].Value);
            //    string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            //    dgvTrends.Rows[i].Cells["MonthName"].Value = monthName;
            //}
        }

        private void UpdateTrendsChart()
        {
            //if (devApp1.Project == null || devApp1.Project.Rows.Count == 0)
            //{
            //    chartTrends.Series.Clear();
            //    return;
            //}

            //chartTrends.Series.Clear();
            //chartTrends.Titles.Clear();

            //// Add title
            //Title title = new Title
            //{
            //    Text = "Monthly Project Completion Trends",
            //    Font = new Font("Segoe UI", 12, FontStyle.Bold),
            //    Docking = Docking.Top
            //};
            //chartTrends.Titles.Add(title);

            //// Create series for projects started
            //Series startedSeries = new Series("Projects Started")
            //{
            //    ChartType = SeriesChartType.Column,
            //    Color = Color.FromArgb(52, 152, 219),
            //    IsValueShownAsLabel = true,
            //    LabelFormat = "{#}",
            //    ToolTip = "#VALX: #VAL projects started"
            //};

            //// Create series for projects completed
            //Series completedSeries = new Series("Projects Completed")
            //{
            //    ChartType = SeriesChartType.Line,
            //    Color = Color.FromArgb(46, 204, 113),
            //    BorderWidth = 3,
            //    MarkerStyle = MarkerStyle.Circle,
            //    MarkerSize = 8,
            //    IsValueShownAsLabel = true,
            //    LabelFormat = "{#}",
            //    ToolTip = "#VALX: #VAL projects completed"
            //};

            //chartTrends.Series.Add(startedSeries);
            //chartTrends.Series.Add(completedSeries);

            //// Sort data by year and month (ascending for chart)
            //var sortedData = devApp1.Project.OrderBy(row => row[0]).ThenBy(row => row[1]).ToList();

            //// Add data points
            //foreach (var row in sortedData)
            //{
            //    string monthYear = $"{System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(row[1]))} {row[0]}";

            //    startedSeries.Points.AddXY(monthYear, row[3]);
            //    completedSeries.Points.AddXY(monthYear, row[4]);
            //}

            //// Configure chart area
            //chartTrends.ChartAreas[0].AxisX.Title = "Month";
            //chartTrends.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            //chartTrends.ChartAreas[0].AxisY.Title = "Number of Projects";
            //chartTrends.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

            //// Add legend
            //chartTrends.Legends.Clear();
            //Legend legend = new Legend
            //{
            //    Title = "Legend",
            //    TitleFont = new Font("Segoe UI", 9, FontStyle.Bold),
            //    Docking = Docking.Top
            //};
            //chartTrends.Legends.Add(legend);
        }

        // ==================== EVENT HANDLERS ====================

        private void BtnLoadLeaderboard_Click(object sender, EventArgs e)
        {
            //LoadLeaderboardData();
        }

        private void BtnLoadTrends_Click(object sender, EventArgs e)
        {
            //LoadTrendsData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //LoadLeaderboardData();
            //LoadTrendsData();
        }

        private void RbChartType_CheckedChanged(object sender, EventArgs e)
        {
            //// Refresh chart when chart type changes
            //if (devApp1.Developer != null && devApp1.Developer.Rows.Count > 0)
            //{
            //    UpdateLeaderboardChart();
            //}
        }

        private void CmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadLeaderboardData();
        }

        private void NudTopCount_ValueChanged(object sender, EventArgs e)
        {
            //LoadLeaderboardData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //LoadLeaderboardData();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            //ResetFilters();
        }

        private void ResetFilters()
        {
            //cmbFilterType.SelectedIndex = 0;
            //txtSearch.Clear();
            //nudTopCount.Value = 10;
            //LoadLeaderboardData();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    LoadLeaderboardData();
            //}
        }

        // Your existing CellClick event handler
        private void dgvLeaderboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.RowIndex < dgvLeaderboard.Rows.Count)
            //{
            //    DataGridViewRow row = dgvLeaderboard.Rows[e.RowIndex];
            //    string developerName = $"{row.Cells["name"].Value} {row.Cells["surname"].Value}";
            //    int completed = Convert.ToInt32(row.Cells["CompletedProjects"].Value);
            //    int active = Convert.ToInt32(row.Cells["ActiveProjects"].Value);
            //    int archived = Convert.ToInt32(row.Cells["ArchivedProjects"].Value);
            //    decimal rate = Convert.ToDecimal(row.Cells["CompletionRate"].Value);

            //    string message = $"🏆 {developerName} 🏆\n\n" +
            //                    $"✅ Completed: {completed} projects\n" +
            //                    $"🔄 Active: {active} projects\n" +
            //                    $"📦 Archived: {archived} projects\n" +
            //                    $"📊 Success Rate: {rate:F1}%\n" +
            //                    $"🥇 Rank: #{e.RowIndex + 1}";

            //    MessageBox.Show(message, "Developer Achievement",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}