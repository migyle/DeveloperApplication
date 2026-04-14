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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbLeaderboard = new System.Windows.Forms.GroupBox();
            this.chartLeaderboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.nudTopCount = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLoadLeaderboard = new System.Windows.Forms.Button();
            this.rbBarChart = new System.Windows.Forms.RadioButton();
            this.rbColumnChart = new System.Windows.Forms.RadioButton();
            this.rbPieChart = new System.Windows.Forms.RadioButton();
            this.gbTrends = new System.Windows.Forms.GroupBox();
            this.chartTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTrends = new System.Windows.Forms.DataGridView();
            this.btnLoadTrends = new System.Windows.Forms.Button();
            this.devApp1 = new DeveloperApplication.DevApp();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter = new DeveloperApplication.DevAppTableAdapters.DeveloperTableAdapter();
            this.devIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new DeveloperApplication.DevAppTableAdapters.ProjectTableAdapter();
            this.projIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visibilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDevelopers = new System.Windows.Forms.Label();
            this.lblTotalProjects = new System.Windows.Forms.Label();
            this.lblAvgCompletionRate = new System.Windows.Forms.Label();
            this.gbLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopCount)).BeginInit();
            this.gbTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLeaderboard
            // 
            this.gbLeaderboard.Controls.Add(this.rbPieChart);
            this.gbLeaderboard.Controls.Add(this.cmbFilterType);
            this.gbLeaderboard.Controls.Add(this.rbColumnChart);
            this.gbLeaderboard.Controls.Add(this.dgvLeaderboard);
            this.gbLeaderboard.Controls.Add(this.rbBarChart);
            this.gbLeaderboard.Controls.Add(this.chartLeaderboard);
            this.gbLeaderboard.Location = new System.Drawing.Point(12, 12);
            this.gbLeaderboard.Name = "gbLeaderboard";
            this.gbLeaderboard.Size = new System.Drawing.Size(800, 470);
            this.gbLeaderboard.TabIndex = 0;
            this.gbLeaderboard.TabStop = false;
            this.gbLeaderboard.Text = "Developer Leaderboard";
            // 
            // chartLeaderboard
            // 
            this.chartLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartLeaderboard.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLeaderboard.Legends.Add(legend1);
            this.chartLeaderboard.Location = new System.Drawing.Point(12, 40);
            this.chartLeaderboard.Name = "chartLeaderboard";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLeaderboard.Series.Add(series1);
            this.chartLeaderboard.Size = new System.Drawing.Size(500, 400);
            this.chartLeaderboard.TabIndex = 0;
            this.chartLeaderboard.Text = "chart1";
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaderboard.AutoGenerateColumns = false;
            this.dgvLeaderboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvLeaderboard.DataSource = this.developerBindingSource;
            this.dgvLeaderboard.Location = new System.Drawing.Point(520, 40);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersWidth = 51;
            this.dgvLeaderboard.RowTemplate.Height = 24;
            this.dgvLeaderboard.Size = new System.Drawing.Size(260, 400);
            this.dgvLeaderboard.TabIndex = 1;
            this.dgvLeaderboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaderboard_CellClick);
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "All",
            "Active",
            "Archived"});
            this.cmbFilterType.Location = new System.Drawing.Point(12, 6);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(100, 24);
            this.cmbFilterType.TabIndex = 1;
            // 
            // nudTopCount
            // 
            this.nudTopCount.Location = new System.Drawing.Point(130, 20);
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
            this.nudTopCount.Size = new System.Drawing.Size(60, 22);
            this.nudTopCount.TabIndex = 1;
            this.nudTopCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(210, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnLoadLeaderboard
            // 
            this.btnLoadLeaderboard.Location = new System.Drawing.Point(370, 19);
            this.btnLoadLeaderboard.Name = "btnLoadLeaderboard";
            this.btnLoadLeaderboard.Size = new System.Drawing.Size(100, 28);
            this.btnLoadLeaderboard.TabIndex = 3;
            this.btnLoadLeaderboard.Text = "Load Data";
            this.btnLoadLeaderboard.UseVisualStyleBackColor = true;
            // 
            // rbBarChart
            // 
            this.rbBarChart.AutoSize = true;
            this.rbBarChart.Checked = true;
            this.rbBarChart.Location = new System.Drawing.Point(334, 444);
            this.rbBarChart.Name = "rbBarChart";
            this.rbBarChart.Size = new System.Drawing.Size(83, 20);
            this.rbBarChart.TabIndex = 4;
            this.rbBarChart.TabStop = true;
            this.rbBarChart.Text = "Bar Chart";
            this.rbBarChart.UseVisualStyleBackColor = true;
            // 
            // rbColumnChart
            // 
            this.rbColumnChart.AutoSize = true;
            this.rbColumnChart.Location = new System.Drawing.Point(490, 444);
            this.rbColumnChart.Name = "rbColumnChart";
            this.rbColumnChart.Size = new System.Drawing.Size(107, 20);
            this.rbColumnChart.TabIndex = 5;
            this.rbColumnChart.Text = "Column Chart";
            this.rbColumnChart.UseVisualStyleBackColor = true;
            // 
            // rbPieChart
            // 
            this.rbPieChart.AutoSize = true;
            this.rbPieChart.Location = new System.Drawing.Point(657, 444);
            this.rbPieChart.Name = "rbPieChart";
            this.rbPieChart.Size = new System.Drawing.Size(82, 20);
            this.rbPieChart.TabIndex = 6;
            this.rbPieChart.Text = "Pie Chart";
            this.rbPieChart.UseVisualStyleBackColor = true;
            // 
            // gbTrends
            // 
            this.gbTrends.Controls.Add(this.btnLoadTrends);
            this.gbTrends.Controls.Add(this.dgvTrends);
            this.gbTrends.Controls.Add(this.chartTrends);
            this.gbTrends.Location = new System.Drawing.Point(12, 488);
            this.gbTrends.Name = "gbTrends";
            this.gbTrends.Size = new System.Drawing.Size(800, 250);
            this.gbTrends.TabIndex = 4;
            this.gbTrends.TabStop = false;
            this.gbTrends.Text = "Project Completion Trends";
            // 
            // chartTrends
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTrends.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTrends.Legends.Add(legend2);
            this.chartTrends.Location = new System.Drawing.Point(12, 30);
            this.chartTrends.Name = "chartTrends";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTrends.Series.Add(series2);
            this.chartTrends.Size = new System.Drawing.Size(260, 200);
            this.chartTrends.TabIndex = 0;
            this.chartTrends.Text = "chart1";
            // 
            // dgvTrends
            // 
            this.dgvTrends.AutoGenerateColumns = false;
            this.dgvTrends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn,
            this.devIDDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.supportDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.estimatedEndDateDataGridViewTextBoxColumn,
            this.isCompletedDataGridViewCheckBoxColumn,
            this.visibilityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1});
            this.dgvTrends.DataSource = this.projectBindingSource;
            this.dgvTrends.Location = new System.Drawing.Point(520, 30);
            this.dgvTrends.Name = "dgvTrends";
            this.dgvTrends.RowHeadersWidth = 51;
            this.dgvTrends.RowTemplate.Height = 24;
            this.dgvTrends.Size = new System.Drawing.Size(260, 200);
            this.dgvTrends.TabIndex = 1;
            // 
            // btnLoadTrends
            // 
            this.btnLoadTrends.Location = new System.Drawing.Point(390, 96);
            this.btnLoadTrends.Name = "btnLoadTrends";
            this.btnLoadTrends.Size = new System.Drawing.Size(92, 53);
            this.btnLoadTrends.TabIndex = 2;
            this.btnLoadTrends.Text = "btnLoadTrends";
            this.btnLoadTrends.UseVisualStyleBackColor = true;
            // 
            // devApp1
            // 
            this.devApp1.DataSetName = "DevApp1";
            this.devApp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // devIDDataGridViewTextBoxColumn
            // 
            this.devIDDataGridViewTextBoxColumn.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn.Name = "devIDDataGridViewTextBoxColumn";
            this.devIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "contactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "contactNumber";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.devApp1;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // projIDDataGridViewTextBoxColumn
            // 
            this.projIDDataGridViewTextBoxColumn.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn.HeaderText = "projID";
            this.projIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projIDDataGridViewTextBoxColumn.Name = "projIDDataGridViewTextBoxColumn";
            this.projIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.projIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // devIDDataGridViewTextBoxColumn1
            // 
            this.devIDDataGridViewTextBoxColumn1.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn1.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn1.Name = "devIDDataGridViewTextBoxColumn1";
            this.devIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // stageDataGridViewTextBoxColumn
            // 
            this.stageDataGridViewTextBoxColumn.DataPropertyName = "stage";
            this.stageDataGridViewTextBoxColumn.HeaderText = "stage";
            this.stageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
            this.stageDataGridViewTextBoxColumn.Width = 125;
            // 
            // supportDataGridViewTextBoxColumn
            // 
            this.supportDataGridViewTextBoxColumn.DataPropertyName = "support";
            this.supportDataGridViewTextBoxColumn.HeaderText = "support";
            this.supportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supportDataGridViewTextBoxColumn.Name = "supportDataGridViewTextBoxColumn";
            this.supportDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimatedEndDateDataGridViewTextBoxColumn
            // 
            this.estimatedEndDateDataGridViewTextBoxColumn.DataPropertyName = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn.HeaderText = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estimatedEndDateDataGridViewTextBoxColumn.Name = "estimatedEndDateDataGridViewTextBoxColumn";
            this.estimatedEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isCompletedDataGridViewCheckBoxColumn
            // 
            this.isCompletedDataGridViewCheckBoxColumn.DataPropertyName = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn.HeaderText = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isCompletedDataGridViewCheckBoxColumn.Name = "isCompletedDataGridViewCheckBoxColumn";
            this.isCompletedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // visibilityDataGridViewTextBoxColumn
            // 
            this.visibilityDataGridViewTextBoxColumn.DataPropertyName = "visibility";
            this.visibilityDataGridViewTextBoxColumn.HeaderText = "visibility";
            this.visibilityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visibilityDataGridViewTextBoxColumn.Name = "visibilityDataGridViewTextBoxColumn";
            this.visibilityDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lblTotalDevelopers
            // 
            this.lblTotalDevelopers.AutoSize = true;
            this.lblTotalDevelopers.Location = new System.Drawing.Point(945, 291);
            this.lblTotalDevelopers.Name = "lblTotalDevelopers";
            this.lblTotalDevelopers.Size = new System.Drawing.Size(44, 16);
            this.lblTotalDevelopers.TabIndex = 5;
            this.lblTotalDevelopers.Text = "label1";
            // 
            // lblTotalProjects
            // 
            this.lblTotalProjects.AutoSize = true;
            this.lblTotalProjects.Location = new System.Drawing.Point(945, 320);
            this.lblTotalProjects.Name = "lblTotalProjects";
            this.lblTotalProjects.Size = new System.Drawing.Size(44, 16);
            this.lblTotalProjects.TabIndex = 6;
            this.lblTotalProjects.Text = "label2";
            // 
            // lblAvgCompletionRate
            // 
            this.lblAvgCompletionRate.AutoSize = true;
            this.lblAvgCompletionRate.Location = new System.Drawing.Point(945, 353);
            this.lblAvgCompletionRate.Name = "lblAvgCompletionRate";
            this.lblAvgCompletionRate.Size = new System.Drawing.Size(44, 16);
            this.lblAvgCompletionRate.TabIndex = 7;
            this.lblAvgCompletionRate.Text = "label3";
            // 
            // frmCelebrationWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 842);
            this.Controls.Add(this.lblAvgCompletionRate);
            this.Controls.Add(this.lblTotalProjects);
            this.Controls.Add(this.lblTotalDevelopers);
            this.Controls.Add(this.gbTrends);
            this.Controls.Add(this.btnLoadLeaderboard);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.nudTopCount);
            this.Controls.Add(this.gbLeaderboard);
            this.Name = "frmCelebrationWall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CelebrationWall";
            this.Load += new System.EventHandler(this.CelebrationWall_Load);
            this.gbLeaderboard.ResumeLayout(false);
            this.gbLeaderboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopCount)).EndInit();
            this.gbTrends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLeaderboard;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLeaderboard;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.NumericUpDown nudTopCount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbPieChart;
        private System.Windows.Forms.RadioButton rbColumnChart;
        private System.Windows.Forms.RadioButton rbBarChart;
        private System.Windows.Forms.Button btnLoadLeaderboard;
        private System.Windows.Forms.GroupBox gbTrends;
        private System.Windows.Forms.Button btnLoadTrends;
        private System.Windows.Forms.DataGridView dgvTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrends;
        private DevApp devApp1;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private DevAppTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevAppTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTotalDevelopers;
        private System.Windows.Forms.Label lblTotalProjects;
        private System.Windows.Forms.Label lblAvgCompletionRate;
    }
}