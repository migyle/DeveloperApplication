namespace DeveloperApplication.Business
{
    partial class frmOtherProjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInsertComment = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCollabReq = new System.Windows.Forms.DataGridView();
            this.projIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedEndDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visibilityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.devApp1 = new DeveloperApplication.DevApp();
            this.btnRemoveReq = new System.Windows.Forms.Button();
            this.rtbAddComment = new System.Windows.Forms.RichTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbVisibility = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.btnArchiveComment = new System.Windows.Forms.Button();
            this.btnUpdateComment = new System.Windows.Forms.Button();
            this.rtbCommentDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.commentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRequestCollab = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.devIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtSupport = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbStage = new System.Windows.Forms.ComboBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtSearchProj = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMyCollabs = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.devApp = new DeveloperApplication.DevApp();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new DeveloperApplication.DevAppTableAdapters.ProjectTableAdapter();
            this.developerTableAdapter = new DeveloperApplication.DevAppTableAdapters.DeveloperTableAdapter();
            this.projectTableAdapter1 = new DeveloperApplication.DevAppTableAdapters.ProjectTableAdapter();
            this.collaborationTableAdapter1 = new DeveloperApplication.DevAppTableAdapters.CollaborationTableAdapter();
            this.commentTableAdapter = new DeveloperApplication.DevAppTableAdapters.CommentTableAdapter();
            this.dgvOtherProjects = new System.Windows.Forms.DataGridView();
            this.projIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visibilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollabReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnInsertComment);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.rtbAddComment);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.cmbVisibility);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.txtSupport);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.cmbStage);
            this.groupBox3.Controls.Add(this.txtDescrip);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1512, 434);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PROJECT DETAILS:        ";
            // 
            // btnInsertComment
            // 
            this.btnInsertComment.Location = new System.Drawing.Point(830, 140);
            this.btnInsertComment.Name = "btnInsertComment";
            this.btnInsertComment.Size = new System.Drawing.Size(142, 58);
            this.btnInsertComment.TabIndex = 25;
            this.btnInsertComment.Text = "Send Comment";
            this.btnInsertComment.UseVisualStyleBackColor = true;
            this.btnInsertComment.Click += new System.EventHandler(this.btnInsertComment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCollabReq);
            this.groupBox2.Controls.Add(this.btnRemoveReq);
            this.groupBox2.Location = new System.Drawing.Point(1190, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 387);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PROJECTS YOU COLLABORATE/  REQUESTED TO COLLABORATE ON";
            // 
            // dgvCollabReq
            // 
            this.dgvCollabReq.AllowUserToAddRows = false;
            this.dgvCollabReq.AllowUserToDeleteRows = false;
            this.dgvCollabReq.AutoGenerateColumns = false;
            this.dgvCollabReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCollabReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollabReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn1,
            this.devIDDataGridViewTextBoxColumn2,
            this.titleDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.stageDataGridViewTextBoxColumn1,
            this.supportDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn1,
            this.estimatedEndDateDataGridViewTextBoxColumn1,
            this.isCompletedDataGridViewCheckBoxColumn1,
            this.visibilityDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn2});
            this.dgvCollabReq.DataSource = this.projectBindingSource1;
            this.dgvCollabReq.Location = new System.Drawing.Point(6, 41);
            this.dgvCollabReq.Name = "dgvCollabReq";
            this.dgvCollabReq.ReadOnly = true;
            this.dgvCollabReq.RowHeadersWidth = 51;
            this.dgvCollabReq.RowTemplate.Height = 24;
            this.dgvCollabReq.Size = new System.Drawing.Size(304, 287);
            this.dgvCollabReq.TabIndex = 2;
            this.dgvCollabReq.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCollabReq_CellClick);
            // 
            // projIDDataGridViewTextBoxColumn1
            // 
            this.projIDDataGridViewTextBoxColumn1.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn1.HeaderText = "projID";
            this.projIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.projIDDataGridViewTextBoxColumn1.Name = "projIDDataGridViewTextBoxColumn1";
            this.projIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.projIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // devIDDataGridViewTextBoxColumn2
            // 
            this.devIDDataGridViewTextBoxColumn2.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn2.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn2.Name = "devIDDataGridViewTextBoxColumn2";
            this.devIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stageDataGridViewTextBoxColumn1
            // 
            this.stageDataGridViewTextBoxColumn1.DataPropertyName = "stage";
            this.stageDataGridViewTextBoxColumn1.HeaderText = "stage";
            this.stageDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stageDataGridViewTextBoxColumn1.Name = "stageDataGridViewTextBoxColumn1";
            this.stageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stageDataGridViewTextBoxColumn1.Visible = false;
            // 
            // supportDataGridViewTextBoxColumn1
            // 
            this.supportDataGridViewTextBoxColumn1.DataPropertyName = "support";
            this.supportDataGridViewTextBoxColumn1.HeaderText = "support";
            this.supportDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.supportDataGridViewTextBoxColumn1.Name = "supportDataGridViewTextBoxColumn1";
            this.supportDataGridViewTextBoxColumn1.ReadOnly = true;
            this.supportDataGridViewTextBoxColumn1.Visible = false;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            this.startDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // estimatedEndDateDataGridViewTextBoxColumn1
            // 
            this.estimatedEndDateDataGridViewTextBoxColumn1.DataPropertyName = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn1.HeaderText = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.estimatedEndDateDataGridViewTextBoxColumn1.Name = "estimatedEndDateDataGridViewTextBoxColumn1";
            this.estimatedEndDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estimatedEndDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // isCompletedDataGridViewCheckBoxColumn1
            // 
            this.isCompletedDataGridViewCheckBoxColumn1.DataPropertyName = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn1.HeaderText = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.isCompletedDataGridViewCheckBoxColumn1.Name = "isCompletedDataGridViewCheckBoxColumn1";
            this.isCompletedDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.isCompletedDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // visibilityDataGridViewTextBoxColumn1
            // 
            this.visibilityDataGridViewTextBoxColumn1.DataPropertyName = "visibility";
            this.visibilityDataGridViewTextBoxColumn1.HeaderText = "visibility";
            this.visibilityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.visibilityDataGridViewTextBoxColumn1.Name = "visibilityDataGridViewTextBoxColumn1";
            this.visibilityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.visibilityDataGridViewTextBoxColumn1.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            this.statusDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // projectBindingSource1
            // 
            this.projectBindingSource1.DataMember = "Project";
            this.projectBindingSource1.DataSource = this.devApp1;
            // 
            // devApp1
            // 
            this.devApp1.DataSetName = "DevApp";
            this.devApp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRemoveReq
            // 
            this.btnRemoveReq.Location = new System.Drawing.Point(103, 334);
            this.btnRemoveReq.Name = "btnRemoveReq";
            this.btnRemoveReq.Size = new System.Drawing.Size(143, 35);
            this.btnRemoveReq.TabIndex = 1;
            this.btnRemoveReq.Text = "Remove Request";
            this.btnRemoveReq.UseVisualStyleBackColor = true;
            this.btnRemoveReq.Click += new System.EventHandler(this.btnRemoveReq_Click);
            // 
            // rtbAddComment
            // 
            this.rtbAddComment.Location = new System.Drawing.Point(388, 146);
            this.rtbAddComment.Name = "rtbAddComment";
            this.rtbAddComment.Size = new System.Drawing.Size(423, 52);
            this.rtbAddComment.TabIndex = 4;
            this.rtbAddComment.Text = "";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(370, 127);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(233, 16);
            this.label27.TabIndex = 5;
            this.label27.Text = "Add comment to selected project :";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // cmbVisibility
            // 
            this.cmbVisibility.Enabled = false;
            this.cmbVisibility.FormattingEnabled = true;
            this.cmbVisibility.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cmbVisibility.Location = new System.Drawing.Point(998, 37);
            this.cmbVisibility.Name = "cmbVisibility";
            this.cmbVisibility.Size = new System.Drawing.Size(175, 24);
            this.cmbVisibility.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(995, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Visibility";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dtpDateCreated);
            this.groupBox4.Controls.Add(this.btnArchiveComment);
            this.groupBox4.Controls.Add(this.btnUpdateComment);
            this.groupBox4.Controls.Add(this.rtbCommentDescription);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dgvComments);
            this.groupBox4.Location = new System.Drawing.Point(639, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 204);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "YOUR COMMENTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date Created";
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCreated.Location = new System.Drawing.Point(332, 155);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(105, 23);
            this.dtpDateCreated.TabIndex = 10;
            // 
            // btnArchiveComment
            // 
            this.btnArchiveComment.Location = new System.Drawing.Point(456, 168);
            this.btnArchiveComment.Name = "btnArchiveComment";
            this.btnArchiveComment.Size = new System.Drawing.Size(85, 29);
            this.btnArchiveComment.TabIndex = 9;
            this.btnArchiveComment.Text = "Archive";
            this.btnArchiveComment.UseVisualStyleBackColor = true;
            this.btnArchiveComment.Click += new System.EventHandler(this.btnArchiveComment_Click);
            // 
            // btnUpdateComment
            // 
            this.btnUpdateComment.Location = new System.Drawing.Point(456, 133);
            this.btnUpdateComment.Name = "btnUpdateComment";
            this.btnUpdateComment.Size = new System.Drawing.Size(85, 32);
            this.btnUpdateComment.TabIndex = 8;
            this.btnUpdateComment.Text = "Update";
            this.btnUpdateComment.UseVisualStyleBackColor = true;
            this.btnUpdateComment.Click += new System.EventHandler(this.btnUpdateComment_Click);
            // 
            // rtbCommentDescription
            // 
            this.rtbCommentDescription.Location = new System.Drawing.Point(93, 133);
            this.rtbCommentDescription.Name = "rtbCommentDescription";
            this.rtbCommentDescription.Size = new System.Drawing.Size(230, 64);
            this.rtbCommentDescription.TabIndex = 6;
            this.rtbCommentDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "description";
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AutoGenerateColumns = false;
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentIDDataGridViewTextBoxColumn,
            this.devIDDataGridViewTextBoxColumn3,
            this.projIDDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn2,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn3});
            this.dgvComments.DataSource = this.commentBindingSource;
            this.dgvComments.Location = new System.Drawing.Point(7, 22);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.ReadOnly = true;
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.Size = new System.Drawing.Size(538, 108);
            this.dgvComments.TabIndex = 0;
            this.dgvComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComments_CellClick);
            // 
            // commentIDDataGridViewTextBoxColumn
            // 
            this.commentIDDataGridViewTextBoxColumn.DataPropertyName = "commentID";
            this.commentIDDataGridViewTextBoxColumn.HeaderText = "commentID";
            this.commentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentIDDataGridViewTextBoxColumn.Name = "commentIDDataGridViewTextBoxColumn";
            this.commentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // devIDDataGridViewTextBoxColumn3
            // 
            this.devIDDataGridViewTextBoxColumn3.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn3.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn3.Name = "devIDDataGridViewTextBoxColumn3";
            this.devIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // projIDDataGridViewTextBoxColumn2
            // 
            this.projIDDataGridViewTextBoxColumn2.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn2.HeaderText = "projID";
            this.projIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.projIDDataGridViewTextBoxColumn2.Name = "projIDDataGridViewTextBoxColumn2";
            this.projIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn3
            // 
            this.statusDataGridViewTextBoxColumn3.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn3.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn3.Name = "statusDataGridViewTextBoxColumn3";
            this.statusDataGridViewTextBoxColumn3.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn3.Visible = false;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataMember = "Comment";
            this.commentBindingSource.DataSource = this.devApp1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRequestCollab);
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(22, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(604, 205);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SELECTED PROJECT COLLABORATORS         ";
            // 
            // btnRequestCollab
            // 
            this.btnRequestCollab.Location = new System.Drawing.Point(364, 168);
            this.btnRequestCollab.Name = "btnRequestCollab";
            this.btnRequestCollab.Size = new System.Drawing.Size(226, 31);
            this.btnRequestCollab.TabIndex = 24;
            this.btnRequestCollab.Text = "Request Collaboration";
            this.btnRequestCollab.UseVisualStyleBackColor = true;
            this.btnRequestCollab.Click += new System.EventHandler(this.btnRequestCollab_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.developerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 21);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(584, 141);
            this.dataGridView3.TabIndex = 22;
            // 
            // devIDDataGridViewTextBoxColumn1
            // 
            this.devIDDataGridViewTextBoxColumn1.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn1.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn1.Name = "devIDDataGridViewTextBoxColumn1";
            this.devIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn1.Visible = false;
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
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Visible = false;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "contactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "contactNumber";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // developerBindingSource
            // 
            this.developerBindingSource.DataMember = "Developer";
            this.developerBindingSource.DataSource = this.devApp1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkNo);
            this.groupBox7.Controls.Add(this.chkYes);
            this.groupBox7.Location = new System.Drawing.Point(998, 82);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(175, 61);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "is Completed?    ";
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Enabled = false;
            this.chkNo.Location = new System.Drawing.Point(97, 27);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(47, 20);
            this.chkNo.TabIndex = 1;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Enabled = false;
            this.chkYes.Location = new System.Drawing.Point(25, 27);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(52, 20);
            this.chkYes.TabIndex = 0;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(705, 71);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 16);
            this.label30.TabIndex = 15;
            this.label30.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(718, 94);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(224, 23);
            this.dtpEndDate.TabIndex = 14;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(705, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 16);
            this.label31.TabIndex = 12;
            this.label31.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(718, 40);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(224, 23);
            this.dtpStartDate.TabIndex = 11;
            // 
            // txtSupport
            // 
            this.txtSupport.Enabled = false;
            this.txtSupport.Location = new System.Drawing.Point(388, 94);
            this.txtSupport.Name = "txtSupport";
            this.txtSupport.Size = new System.Drawing.Size(262, 23);
            this.txtSupport.TabIndex = 10;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(370, 71);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 16);
            this.label32.TabIndex = 9;
            this.label32.Text = "Support";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(370, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 16);
            this.label33.TabIndex = 8;
            this.label33.Text = "Stage";
            // 
            // cmbStage
            // 
            this.cmbStage.Enabled = false;
            this.cmbStage.FormattingEnabled = true;
            this.cmbStage.Items.AddRange(new object[] {
            "Planning",
            "Design",
            "Development",
            "Testing",
            "Deployment",
            "Maintenance"});
            this.cmbStage.Location = new System.Drawing.Point(388, 38);
            this.cmbStage.Name = "cmbStage";
            this.cmbStage.Size = new System.Drawing.Size(262, 24);
            this.cmbStage.TabIndex = 7;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Enabled = false;
            this.txtDescrip.Location = new System.Drawing.Point(44, 82);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(262, 103);
            this.txtDescrip.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(44, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(262, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 62);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 16);
            this.label34.TabIndex = 4;
            this.label34.Text = "Description";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(19, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 16);
            this.label35.TabIndex = 3;
            this.label35.Text = "Title";
            // 
            // txtSearchProj
            // 
            this.txtSearchProj.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProj.Location = new System.Drawing.Point(283, 39);
            this.txtSearchProj.Name = "txtSearchProj";
            this.txtSearchProj.Size = new System.Drawing.Size(367, 28);
            this.txtSearchProj.TabIndex = 13;
            this.txtSearchProj.TextChanged += new System.EventHandler(this.txtSearchProj_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(48, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(214, 20);
            this.label22.TabIndex = 12;
            this.label22.Text = "Search by Project Title";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbMyCollabs);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(956, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 60);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTERS  ";
            // 
            // rbMyCollabs
            // 
            this.rbMyCollabs.AutoSize = true;
            this.rbMyCollabs.Location = new System.Drawing.Point(249, 21);
            this.rbMyCollabs.Name = "rbMyCollabs";
            this.rbMyCollabs.Size = new System.Drawing.Size(189, 24);
            this.rbMyCollabs.TabIndex = 1;
            this.rbMyCollabs.Text = "My Collaborations";
            this.rbMyCollabs.UseVisualStyleBackColor = true;
            this.rbMyCollabs.CheckedChanged += new System.EventHandler(this.rbMyCollabs_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 21);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(187, 24);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Public Projects";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // devApp
            // 
            this.devApp.DataSetName = "DevApp";
            this.devApp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter1
            // 
            this.projectTableAdapter1.ClearBeforeFill = true;
            // 
            // collaborationTableAdapter1
            // 
            this.collaborationTableAdapter1.ClearBeforeFill = true;
            // 
            // commentTableAdapter
            // 
            this.commentTableAdapter.ClearBeforeFill = true;
            // 
            // dgvOtherProjects
            // 
            this.dgvOtherProjects.AllowUserToAddRows = false;
            this.dgvOtherProjects.AllowUserToDeleteRows = false;
            this.dgvOtherProjects.AutoGenerateColumns = false;
            this.dgvOtherProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtherProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn,
            this.devIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.supportDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.estimatedEndDateDataGridViewTextBoxColumn,
            this.isCompletedDataGridViewCheckBoxColumn,
            this.visibilityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvOtherProjects.DataSource = this.projectBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOtherProjects.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOtherProjects.Location = new System.Drawing.Point(12, 88);
            this.dgvOtherProjects.Name = "dgvOtherProjects";
            this.dgvOtherProjects.ReadOnly = true;
            this.dgvOtherProjects.RowHeadersWidth = 51;
            this.dgvOtherProjects.RowTemplate.Height = 24;
            this.dgvOtherProjects.Size = new System.Drawing.Size(1509, 278);
            this.dgvOtherProjects.TabIndex = 25;
            this.dgvOtherProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOtherProjects_CellClick);
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
            // devIDDataGridViewTextBoxColumn
            // 
            this.devIDDataGridViewTextBoxColumn.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn.Name = "devIDDataGridViewTextBoxColumn";
            this.devIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // stageDataGridViewTextBoxColumn
            // 
            this.stageDataGridViewTextBoxColumn.DataPropertyName = "stage";
            this.stageDataGridViewTextBoxColumn.HeaderText = "stage";
            this.stageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
            this.stageDataGridViewTextBoxColumn.ReadOnly = true;
            this.stageDataGridViewTextBoxColumn.Width = 125;
            // 
            // supportDataGridViewTextBoxColumn
            // 
            this.supportDataGridViewTextBoxColumn.DataPropertyName = "support";
            this.supportDataGridViewTextBoxColumn.HeaderText = "support";
            this.supportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supportDataGridViewTextBoxColumn.Name = "supportDataGridViewTextBoxColumn";
            this.supportDataGridViewTextBoxColumn.ReadOnly = true;
            this.supportDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimatedEndDateDataGridViewTextBoxColumn
            // 
            this.estimatedEndDateDataGridViewTextBoxColumn.DataPropertyName = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn.HeaderText = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estimatedEndDateDataGridViewTextBoxColumn.Name = "estimatedEndDateDataGridViewTextBoxColumn";
            this.estimatedEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.estimatedEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isCompletedDataGridViewCheckBoxColumn
            // 
            this.isCompletedDataGridViewCheckBoxColumn.DataPropertyName = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn.HeaderText = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isCompletedDataGridViewCheckBoxColumn.Name = "isCompletedDataGridViewCheckBoxColumn";
            this.isCompletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCompletedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // visibilityDataGridViewTextBoxColumn
            // 
            this.visibilityDataGridViewTextBoxColumn.DataPropertyName = "visibility";
            this.visibilityDataGridViewTextBoxColumn.HeaderText = "visibility";
            this.visibilityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visibilityDataGridViewTextBoxColumn.Name = "visibilityDataGridViewTextBoxColumn";
            this.visibilityDataGridViewTextBoxColumn.ReadOnly = true;
            this.visibilityDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DeveloperApplication.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 842);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmOtherProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 842);
            this.Controls.Add(this.dgvOtherProjects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSearchProj);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmOtherProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtherProjects";
            this.Load += new System.EventHandler(this.frmOtherProjects_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollabReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRequestCollab;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtSupport;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbStage;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtSearchProj;
        private System.Windows.Forms.Label label22;
        private DevApp devApp1;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevAppTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMyCollabs;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.ComboBox cmbVisibility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private DevAppTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveReq;
        private System.Windows.Forms.DataGridView dgvCollabReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibilityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource projectBindingSource1;
        private DevAppTableAdapters.ProjectTableAdapter projectTableAdapter1;
        private DevAppTableAdapters.CollaborationTableAdapter collaborationTableAdapter1;
        private System.Windows.Forms.Button btnInsertComment;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RichTextBox rtbAddComment;
        private System.Windows.Forms.DataGridView dgvComments;
        private DevApp devApp;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private DevAppTableAdapters.CommentTableAdapter commentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnArchiveComment;
        private System.Windows.Forms.Button btnUpdateComment;
        private System.Windows.Forms.RichTextBox rtbCommentDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.DataGridView dgvOtherProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}