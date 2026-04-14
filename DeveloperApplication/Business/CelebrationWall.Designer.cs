namespace DeveloperApplication.Business
{
    partial class frmCelebrationWall
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbLeaderboard = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTopCount = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBarChart = new System.Windows.Forms.RadioButton();
            this.rbColumnChart = new System.Windows.Forms.RadioButton();
            this.rbPieChart = new System.Windows.Forms.RadioButton();
            this.lblAvgCompletionRate = new System.Windows.Forms.Label();
            this.lblTotalProjects = new System.Windows.Forms.Label();
            this.lblTotalDevelopers = new System.Windows.Forms.Label();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.leaderboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devApp1 = new DeveloperApplication.DevApp();
            this.chartLeaderboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projectTrendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter = new DeveloperApplication.DevAppTableAdapters.DeveloperTableAdapter();
            this.projectTableAdapter = new DeveloperApplication.DevAppTableAdapters.ProjectTableAdapter();
            this.leaderboardTableAdapter = new DeveloperApplication.DevAppTableAdapters.LeaderboardTableAdapter();
            this.projectTrendsTableAdapter = new DeveloperApplication.DevAppTableAdapters.ProjectTrendsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.devIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLeaderboard.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLeaderboard
            // 
            this.gbLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.gbLeaderboard.Controls.Add(this.groupBox2);
            this.gbLeaderboard.Controls.Add(this.groupBox1);
            this.gbLeaderboard.Controls.Add(this.lblAvgCompletionRate);
            this.gbLeaderboard.Controls.Add(this.lblTotalProjects);
            this.gbLeaderboard.Controls.Add(this.lblTotalDevelopers);
            this.gbLeaderboard.Controls.Add(this.dgvLeaderboard);
            this.gbLeaderboard.Controls.Add(this.chartLeaderboard);
            this.gbLeaderboard.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLeaderboard.Location = new System.Drawing.Point(12, 12);
            this.gbLeaderboard.Name = "gbLeaderboard";
            this.gbLeaderboard.Size = new System.Drawing.Size(1519, 818);
            this.gbLeaderboard.TabIndex = 0;
            this.gbLeaderboard.TabStop = false;
            this.gbLeaderboard.Text = "Developer Leaderboard";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudTopCount);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(920, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leaderboard Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search for Developer (Name/ Surname/ Email)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // nudTopCount
            // 
            this.nudTopCount.ForeColor = System.Drawing.Color.Black;
            this.nudTopCount.Location = new System.Drawing.Point(32, 42);
            this.nudTopCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTopCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTopCount.Name = "nudTopCount";
            this.nudTopCount.Size = new System.Drawing.Size(167, 25);
            this.nudTopCount.TabIndex = 1;
            this.nudTopCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTopCount.ValueChanged += new System.EventHandler(this.nudTopCount_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(248, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(303, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBarChart);
            this.groupBox1.Controls.Add(this.rbColumnChart);
            this.groupBox1.Controls.Add(this.rbPieChart);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1071, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Chart Type";
            // 
            // rbBarChart
            // 
            this.rbBarChart.AutoSize = true;
            this.rbBarChart.Checked = true;
            this.rbBarChart.Location = new System.Drawing.Point(17, 32);
            this.rbBarChart.Name = "rbBarChart";
            this.rbBarChart.Size = new System.Drawing.Size(100, 21);
            this.rbBarChart.TabIndex = 4;
            this.rbBarChart.TabStop = true;
            this.rbBarChart.Text = "Bar Chart";
            this.rbBarChart.UseVisualStyleBackColor = true;
            this.rbBarChart.CheckedChanged += new System.EventHandler(this.rbBarChart_CheckedChanged);
            // 
            // rbColumnChart
            // 
            this.rbColumnChart.AutoSize = true;
            this.rbColumnChart.Location = new System.Drawing.Point(138, 32);
            this.rbColumnChart.Name = "rbColumnChart";
            this.rbColumnChart.Size = new System.Drawing.Size(136, 21);
            this.rbColumnChart.TabIndex = 5;
            this.rbColumnChart.Text = "Column Chart";
            this.rbColumnChart.UseVisualStyleBackColor = true;
            this.rbColumnChart.CheckedChanged += new System.EventHandler(this.rbColumnChart_CheckedChanged);
            // 
            // rbPieChart
            // 
            this.rbPieChart.AutoSize = true;
            this.rbPieChart.Location = new System.Drawing.Point(301, 32);
            this.rbPieChart.Name = "rbPieChart";
            this.rbPieChart.Size = new System.Drawing.Size(98, 21);
            this.rbPieChart.TabIndex = 6;
            this.rbPieChart.Text = "Pie Chart";
            this.rbPieChart.UseVisualStyleBackColor = true;
            this.rbPieChart.CheckedChanged += new System.EventHandler(this.rbPieChart_CheckedChanged);
            // 
            // lblAvgCompletionRate
            // 
            this.lblAvgCompletionRate.AutoSize = true;
            this.lblAvgCompletionRate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAvgCompletionRate.Location = new System.Drawing.Point(1333, 675);
            this.lblAvgCompletionRate.Name = "lblAvgCompletionRate";
            this.lblAvgCompletionRate.Size = new System.Drawing.Size(53, 17);
            this.lblAvgCompletionRate.TabIndex = 7;
            this.lblAvgCompletionRate.Text = "label3";
            // 
            // lblTotalProjects
            // 
            this.lblTotalProjects.AutoSize = true;
            this.lblTotalProjects.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalProjects.Location = new System.Drawing.Point(1102, 675);
            this.lblTotalProjects.Name = "lblTotalProjects";
            this.lblTotalProjects.Size = new System.Drawing.Size(53, 17);
            this.lblTotalProjects.TabIndex = 6;
            this.lblTotalProjects.Text = "label2";
            // 
            // lblTotalDevelopers
            // 
            this.lblTotalDevelopers.AutoSize = true;
            this.lblTotalDevelopers.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalDevelopers.Location = new System.Drawing.Point(860, 675);
            this.lblTotalDevelopers.Name = "lblTotalDevelopers";
            this.lblTotalDevelopers.Size = new System.Drawing.Size(53, 17);
            this.lblTotalDevelopers.TabIndex = 5;
            this.lblTotalDevelopers.Text = "label1";
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.AutoGenerateColumns = false;
            this.dgvLeaderboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvLeaderboard.DataSource = this.leaderboardBindingSource;
            this.dgvLeaderboard.Location = new System.Drawing.Point(842, 289);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersWidth = 51;
            this.dgvLeaderboard.RowTemplate.Height = 24;
            this.dgvLeaderboard.Size = new System.Drawing.Size(628, 383);
            this.dgvLeaderboard.TabIndex = 1;
            this.dgvLeaderboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaderboard_CellClick);
            // 
            // leaderboardBindingSource
            // 
            this.leaderboardBindingSource.DataMember = "Leaderboard";
            this.leaderboardBindingSource.DataSource = this.devApp1;
            // 
            // devApp1
            // 
            this.devApp1.DataSetName = "DevApp1";
            this.devApp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartLeaderboard
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLeaderboard.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLeaderboard.Legends.Add(legend1);
            this.chartLeaderboard.Location = new System.Drawing.Point(28, 84);
            this.chartLeaderboard.Name = "chartLeaderboard";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLeaderboard.Series.Add(series1);
            this.chartLeaderboard.Size = new System.Drawing.Size(742, 633);
            this.chartLeaderboard.TabIndex = 0;
            this.chartLeaderboard.Text = "chart1";
            // 
            // projectTrendsBindingSource
            // 
            this.projectTrendsBindingSource.DataMember = "ProjectTrends";
            this.projectTrendsBindingSource.DataSource = this.devApp1;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.devApp1;
            // 
            // developerBindingSource
            // 
            this.developerBindingSource.DataMember = "Developer";
            this.developerBindingSource.DataSource = this.devApp1;
            // 
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // leaderboardTableAdapter
            // 
            this.leaderboardTableAdapter.ClearBeforeFill = true;
            // 
            // projectTrendsTableAdapter
            // 
            this.projectTrendsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DeveloperApplication.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 842);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // devIDDataGridViewTextBoxColumn
            // 
            this.devIDDataGridViewTextBoxColumn.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn.Name = "devIDDataGridViewTextBoxColumn";
            this.devIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCelebrationWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 842);
            this.Controls.Add(this.gbLeaderboard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCelebrationWall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CelebrationWall";
            this.Load += new System.EventHandler(this.CelebrationWall_Load);
            this.gbLeaderboard.ResumeLayout(false);
            this.gbLeaderboard.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLeaderboard;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLeaderboard;
        private System.Windows.Forms.NumericUpDown nudTopCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbPieChart;
        private System.Windows.Forms.RadioButton rbColumnChart;
        private System.Windows.Forms.RadioButton rbBarChart;
        private DevApp devApp1;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private DevAppTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevAppTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.Label lblTotalDevelopers;
        private System.Windows.Forms.Label lblTotalProjects;
        private System.Windows.Forms.Label lblAvgCompletionRate;
        private System.Windows.Forms.BindingSource leaderboardBindingSource;
        private DevAppTableAdapters.LeaderboardTableAdapter leaderboardTableAdapter;
        private System.Windows.Forms.BindingSource projectTrendsBindingSource;
        private DevAppTableAdapters.ProjectTrendsTableAdapter projectTrendsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}