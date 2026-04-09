namespace DeveloperApplication.Business
{
    partial class Profile
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.devApp1 = new DeveloperApplication.DevApp();
            this.developerTableAdapter1 = new DeveloperApplication.DevAppTableAdapters.DeveloperTableAdapter();
            this.projectTableAdapter1 = new DeveloperApplication.DevAppTableAdapters.ProjectTableAdapter();
            this.tcProjects = new System.Windows.Forms.TabControl();
            this.tpMyProj = new System.Windows.Forms.TabPage();
            this.tpOtherProj = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMyProjects = new System.Windows.Forms.DataGridView();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbMyProjDet = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMTitle = new System.Windows.Forms.TextBox();
            this.txtMDescrip = new System.Windows.Forms.TextBox();
            this.cmbMStage = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMSupport = new System.Windows.Forms.TextBox();
            this.dtpMStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpMEndDate = new System.Windows.Forms.DateTimePicker();
            this.gbMCompleted = new System.Windows.Forms.GroupBox();
            this.chkMYes = new System.Windows.Forms.CheckBox();
            this.chkMNo = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.milestoneTableAdapter1 = new DeveloperApplication.DevAppTableAdapters.MilestoneTableAdapter();
            this.dgvMilestones = new System.Windows.Forms.DataGridView();
            this.milestoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milestoneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAchievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedEndDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbCollaborators = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbRequests = new System.Windows.Forms.RadioButton();
            this.btnMCollabRequest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.collaborationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collaborationTableAdapter = new DeveloperApplication.DevAppTableAdapters.CollaborationTableAdapter();
            this.devIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCollaborators = new System.Windows.Forms.DataGridView();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentTableAdapter = new DeveloperApplication.DevAppTableAdapters.CommentTableAdapter();
            this.commentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearchDevName = new System.Windows.Forms.TextBox();
            this.chkAllComments = new System.Windows.Forms.CheckBox();
            this.rtbDescrip = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDevName = new System.Windows.Forms.TextBox();
            this.txtProjTitle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSearchDev2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtProjTitleSearch = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).BeginInit();
            this.tcProjects.SuspendLayout();
            this.tpMyProj.SuspendLayout();
            this.tpOtherProj.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.gbMyProjDet.SuspendLayout();
            this.gbMCompleted.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilestones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milestoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).BeginInit();
            this.gbCollaborators.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollaborators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.grpDetails);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Location = new System.Drawing.Point(12, 23);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(323, 850);
            this.pnlDetails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi,";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name+Surname";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnPassword);
            this.grpDetails.Controls.Add(this.btnCancel);
            this.grpDetails.Controls.Add(this.btnApply);
            this.grpDetails.Controls.Add(this.btnUpdate);
            this.grpDetails.Controls.Add(this.txtEmail);
            this.grpDetails.Controls.Add(this.txtSurname);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Location = new System.Drawing.Point(14, 245);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(286, 366);
            this.grpDetails.TabIndex = 2;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "PERSONAL DETAILS:    ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(13, 153);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(198, 22);
            this.txtSurname.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 22);
            this.txtName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(6, 319);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(116, 33);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 33);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(143, 279);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(137, 34);
            this.btnPassword.TabIndex = 17;
            this.btnPassword.Text = "Change password";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // devApp1
            // 
            this.devApp1.DataSetName = "DevApp";
            this.devApp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // developerTableAdapter1
            // 
            this.developerTableAdapter1.ClearBeforeFill = true;
            // 
            // projectTableAdapter1
            // 
            this.projectTableAdapter1.ClearBeforeFill = true;
            // 
            // tcProjects
            // 
            this.tcProjects.Controls.Add(this.tpMyProj);
            this.tcProjects.Controls.Add(this.tpOtherProj);
            this.tcProjects.Location = new System.Drawing.Point(341, 12);
            this.tcProjects.Name = "tcProjects";
            this.tcProjects.SelectedIndex = 0;
            this.tcProjects.Size = new System.Drawing.Size(1268, 865);
            this.tcProjects.TabIndex = 1;
            // 
            // tpMyProj
            // 
            this.tpMyProj.Controls.Add(this.panel2);
            this.tpMyProj.Controls.Add(this.panel1);
            this.tpMyProj.Location = new System.Drawing.Point(4, 25);
            this.tpMyProj.Name = "tpMyProj";
            this.tpMyProj.Padding = new System.Windows.Forms.Padding(3);
            this.tpMyProj.Size = new System.Drawing.Size(1260, 836);
            this.tpMyProj.TabIndex = 0;
            this.tpMyProj.Text = "MY PROJECTS";
            this.tpMyProj.UseVisualStyleBackColor = true;
            // 
            // tpOtherProj
            // 
            this.tpOtherProj.Controls.Add(this.groupBox3);
            this.tpOtherProj.Controls.Add(this.textBox2);
            this.tpOtherProj.Controls.Add(this.label22);
            this.tpOtherProj.Controls.Add(this.dataGridView1);
            this.tpOtherProj.Location = new System.Drawing.Point(4, 25);
            this.tpOtherProj.Name = "tpOtherProj";
            this.tpOtherProj.Padding = new System.Windows.Forms.Padding(3);
            this.tpOtherProj.Size = new System.Drawing.Size(1260, 836);
            this.tpOtherProj.TabIndex = 1;
            this.tpOtherProj.Text = "OTHER PROJECTS";
            this.tpOtherProj.UseVisualStyleBackColor = true;
            this.tpOtherProj.Click += new System.EventHandler(this.tpOtherProj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProjTitleSearch);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.gbMyProjDet);
            this.panel1.Controls.Add(this.dgvMyProjects);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 623);
            this.panel1.TabIndex = 0;
            // 
            // dgvMyProjects
            // 
            this.dgvMyProjects.AllowUserToAddRows = false;
            this.dgvMyProjects.AllowUserToDeleteRows = false;
            this.dgvMyProjects.AllowUserToOrderColumns = true;
            this.dgvMyProjects.AutoGenerateColumns = false;
            this.dgvMyProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn,
            this.devIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.supportDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.estimatedEndDateDataGridViewTextBoxColumn,
            this.isCompletedDataGridViewCheckBoxColumn});
            this.dgvMyProjects.DataSource = this.projectBindingSource;
            this.dgvMyProjects.Location = new System.Drawing.Point(3, 32);
            this.dgvMyProjects.Name = "dgvMyProjects";
            this.dgvMyProjects.ReadOnly = true;
            this.dgvMyProjects.RowHeadersWidth = 51;
            this.dgvMyProjects.RowTemplate.Height = 24;
            this.dgvMyProjects.Size = new System.Drawing.Size(1245, 193);
            this.dgvMyProjects.TabIndex = 0;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.devApp1;
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
            // gbMyProjDet
            // 
            this.gbMyProjDet.Controls.Add(this.groupBox2);
            this.gbMyProjDet.Controls.Add(this.gbCollaborators);
            this.gbMyProjDet.Controls.Add(this.button3);
            this.gbMyProjDet.Controls.Add(this.button2);
            this.gbMyProjDet.Controls.Add(this.button1);
            this.gbMyProjDet.Controls.Add(this.btnClear);
            this.gbMyProjDet.Controls.Add(this.gbMCompleted);
            this.gbMyProjDet.Controls.Add(this.label11);
            this.gbMyProjDet.Controls.Add(this.dtpMEndDate);
            this.gbMyProjDet.Controls.Add(this.label9);
            this.gbMyProjDet.Controls.Add(this.dtpMStartDate);
            this.gbMyProjDet.Controls.Add(this.txtMSupport);
            this.gbMyProjDet.Controls.Add(this.label8);
            this.gbMyProjDet.Controls.Add(this.label7);
            this.gbMyProjDet.Controls.Add(this.cmbMStage);
            this.gbMyProjDet.Controls.Add(this.txtMDescrip);
            this.gbMyProjDet.Controls.Add(this.txtMTitle);
            this.gbMyProjDet.Controls.Add(this.label6);
            this.gbMyProjDet.Controls.Add(this.label5);
            this.gbMyProjDet.Location = new System.Drawing.Point(3, 231);
            this.gbMyProjDet.Name = "gbMyProjDet";
            this.gbMyProjDet.Size = new System.Drawing.Size(1245, 389);
            this.gbMyProjDet.TabIndex = 1;
            this.gbMyProjDet.TabStop = false;
            this.gbMyProjDet.Text = "DETAILS:        ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Title";
            // 
            // txtMTitle
            // 
            this.txtMTitle.Location = new System.Drawing.Point(31, 37);
            this.txtMTitle.Name = "txtMTitle";
            this.txtMTitle.Size = new System.Drawing.Size(262, 22);
            this.txtMTitle.TabIndex = 5;
            // 
            // txtMDescrip
            // 
            this.txtMDescrip.Location = new System.Drawing.Point(31, 82);
            this.txtMDescrip.Multiline = true;
            this.txtMDescrip.Name = "txtMDescrip";
            this.txtMDescrip.Size = new System.Drawing.Size(262, 103);
            this.txtMDescrip.TabIndex = 6;
            // 
            // cmbMStage
            // 
            this.cmbMStage.FormattingEnabled = true;
            this.cmbMStage.Items.AddRange(new object[] {
            "Planning",
            "Design",
            "Development",
            "Testing",
            "Deployment",
            "Maintenance"});
            this.cmbMStage.Location = new System.Drawing.Point(326, 38);
            this.cmbMStage.Name = "cmbMStage";
            this.cmbMStage.Size = new System.Drawing.Size(262, 24);
            this.cmbMStage.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Support";
            // 
            // txtMSupport
            // 
            this.txtMSupport.Location = new System.Drawing.Point(326, 105);
            this.txtMSupport.Name = "txtMSupport";
            this.txtMSupport.Size = new System.Drawing.Size(262, 22);
            this.txtMSupport.TabIndex = 10;
            // 
            // dtpMStartDate
            // 
            this.dtpMStartDate.Location = new System.Drawing.Point(616, 40);
            this.dtpMStartDate.Name = "dtpMStartDate";
            this.dtpMStartDate.Size = new System.Drawing.Size(224, 22);
            this.dtpMStartDate.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Start Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "End Date";
            // 
            // dtpMEndDate
            // 
            this.dtpMEndDate.Location = new System.Drawing.Point(616, 105);
            this.dtpMEndDate.Name = "dtpMEndDate";
            this.dtpMEndDate.Size = new System.Drawing.Size(224, 22);
            this.dtpMEndDate.TabIndex = 14;
            // 
            // gbMCompleted
            // 
            this.gbMCompleted.Controls.Add(this.chkMNo);
            this.gbMCompleted.Controls.Add(this.chkMYes);
            this.gbMCompleted.Location = new System.Drawing.Point(326, 136);
            this.gbMCompleted.Name = "gbMCompleted";
            this.gbMCompleted.Size = new System.Drawing.Size(150, 61);
            this.gbMCompleted.TabIndex = 16;
            this.gbMCompleted.TabStop = false;
            this.gbMCompleted.Text = "is Completed?    ";
            // 
            // chkMYes
            // 
            this.chkMYes.AutoSize = true;
            this.chkMYes.Location = new System.Drawing.Point(17, 27);
            this.chkMYes.Name = "chkMYes";
            this.chkMYes.Size = new System.Drawing.Size(53, 20);
            this.chkMYes.TabIndex = 0;
            this.chkMYes.Text = "Yes";
            this.chkMYes.UseVisualStyleBackColor = true;
            // 
            // chkMNo
            // 
            this.chkMNo.AutoSize = true;
            this.chkMNo.Location = new System.Drawing.Point(97, 27);
            this.chkMNo.Name = "chkMNo";
            this.chkMNo.Size = new System.Drawing.Size(47, 20);
            this.chkMNo.TabIndex = 1;
            this.chkMNo.Text = "No";
            this.chkMNo.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(516, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(324, 29);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Archive";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 20;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dgvMilestones);
            this.panel2.Location = new System.Drawing.Point(3, 654);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 176);
            this.panel2.TabIndex = 1;
            // 
            // milestoneTableAdapter1
            // 
            this.milestoneTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvMilestones
            // 
            this.dgvMilestones.AllowUserToAddRows = false;
            this.dgvMilestones.AllowUserToDeleteRows = false;
            this.dgvMilestones.AutoGenerateColumns = false;
            this.dgvMilestones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilestones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.milestoneIDDataGridViewTextBoxColumn,
            this.projIDDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.dateAchievedDataGridViewTextBoxColumn});
            this.dgvMilestones.DataSource = this.milestoneBindingSource;
            this.dgvMilestones.Location = new System.Drawing.Point(3, 7);
            this.dgvMilestones.Name = "dgvMilestones";
            this.dgvMilestones.ReadOnly = true;
            this.dgvMilestones.RowHeadersWidth = 51;
            this.dgvMilestones.RowTemplate.Height = 24;
            this.dgvMilestones.Size = new System.Drawing.Size(728, 166);
            this.dgvMilestones.TabIndex = 0;
            // 
            // milestoneBindingSource
            // 
            this.milestoneBindingSource.DataMember = "Milestone";
            this.milestoneBindingSource.DataSource = this.devApp1;
            // 
            // milestoneIDDataGridViewTextBoxColumn
            // 
            this.milestoneIDDataGridViewTextBoxColumn.DataPropertyName = "milestoneID";
            this.milestoneIDDataGridViewTextBoxColumn.HeaderText = "milestoneID";
            this.milestoneIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.milestoneIDDataGridViewTextBoxColumn.Name = "milestoneIDDataGridViewTextBoxColumn";
            this.milestoneIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.milestoneIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // projIDDataGridViewTextBoxColumn1
            // 
            this.projIDDataGridViewTextBoxColumn1.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn1.HeaderText = "projID";
            this.projIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.projIDDataGridViewTextBoxColumn1.Name = "projIDDataGridViewTextBoxColumn1";
            this.projIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.projIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateAchievedDataGridViewTextBoxColumn
            // 
            this.dateAchievedDataGridViewTextBoxColumn.DataPropertyName = "dateAchieved";
            this.dateAchievedDataGridViewTextBoxColumn.HeaderText = "dateAchieved";
            this.dateAchievedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAchievedDataGridViewTextBoxColumn.Name = "dateAchievedDataGridViewTextBoxColumn";
            this.dateAchievedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAchievedDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.projectBindingSource;
            this.comboBox1.DisplayMember = "title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(795, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "projID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(778, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Project Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1017, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Milestone Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1032, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(967, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Date Achieved";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(926, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // developerBindingSource
            // 
            this.developerBindingSource.DataMember = "Developer";
            this.developerBindingSource.DataSource = this.devApp1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn2,
            this.devIDDataGridViewTextBoxColumn2,
            this.titleDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn1,
            this.stageDataGridViewTextBoxColumn1,
            this.supportDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn1,
            this.estimatedEndDateDataGridViewTextBoxColumn1,
            this.isCompletedDataGridViewCheckBoxColumn1});
            this.dataGridView1.DataSource = this.projectBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // projectBindingSource1
            // 
            this.projectBindingSource1.DataMember = "Project";
            this.projectBindingSource1.DataSource = this.devApp1;
            // 
            // projIDDataGridViewTextBoxColumn2
            // 
            this.projIDDataGridViewTextBoxColumn2.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn2.HeaderText = "projID";
            this.projIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.projIDDataGridViewTextBoxColumn2.Name = "projIDDataGridViewTextBoxColumn2";
            this.projIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.projIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // devIDDataGridViewTextBoxColumn2
            // 
            this.devIDDataGridViewTextBoxColumn2.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn2.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn2.Name = "devIDDataGridViewTextBoxColumn2";
            this.devIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn2.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stageDataGridViewTextBoxColumn1
            // 
            this.stageDataGridViewTextBoxColumn1.DataPropertyName = "stage";
            this.stageDataGridViewTextBoxColumn1.HeaderText = "stage";
            this.stageDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stageDataGridViewTextBoxColumn1.Name = "stageDataGridViewTextBoxColumn1";
            this.stageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stageDataGridViewTextBoxColumn1.Width = 125;
            // 
            // supportDataGridViewTextBoxColumn1
            // 
            this.supportDataGridViewTextBoxColumn1.DataPropertyName = "support";
            this.supportDataGridViewTextBoxColumn1.HeaderText = "support";
            this.supportDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.supportDataGridViewTextBoxColumn1.Name = "supportDataGridViewTextBoxColumn1";
            this.supportDataGridViewTextBoxColumn1.ReadOnly = true;
            this.supportDataGridViewTextBoxColumn1.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            this.startDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // estimatedEndDateDataGridViewTextBoxColumn1
            // 
            this.estimatedEndDateDataGridViewTextBoxColumn1.DataPropertyName = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn1.HeaderText = "estimatedEndDate";
            this.estimatedEndDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.estimatedEndDateDataGridViewTextBoxColumn1.Name = "estimatedEndDateDataGridViewTextBoxColumn1";
            this.estimatedEndDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estimatedEndDateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // isCompletedDataGridViewCheckBoxColumn1
            // 
            this.isCompletedDataGridViewCheckBoxColumn1.DataPropertyName = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn1.HeaderText = "isCompleted";
            this.isCompletedDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.isCompletedDataGridViewCheckBoxColumn1.Name = "isCompletedDataGridViewCheckBoxColumn1";
            this.isCompletedDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.isCompletedDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // gbCollaborators
            // 
            this.gbCollaborators.Controls.Add(this.txtSearchDev2);
            this.gbCollaborators.Controls.Add(this.label20);
            this.gbCollaborators.Controls.Add(this.btnMCollabRequest);
            this.gbCollaborators.Controls.Add(this.groupBox1);
            this.gbCollaborators.Controls.Add(this.dgvCollaborators);
            this.gbCollaborators.Location = new System.Drawing.Point(9, 215);
            this.gbCollaborators.Name = "gbCollaborators";
            this.gbCollaborators.Size = new System.Drawing.Size(831, 168);
            this.gbCollaborators.TabIndex = 23;
            this.gbCollaborators.TabStop = false;
            this.gbCollaborators.Text = "COLLABORATORS         ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRequests);
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Location = new System.Drawing.Point(644, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 110);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTERS  ";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 21);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(127, 20);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Collaborators";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbRequests
            // 
            this.rbRequests.AutoSize = true;
            this.rbRequests.Location = new System.Drawing.Point(6, 61);
            this.rbRequests.Name = "rbRequests";
            this.rbRequests.Size = new System.Drawing.Size(163, 20);
            this.rbRequests.TabIndex = 1;
            this.rbRequests.Text = "Collaborator Requests";
            this.rbRequests.UseVisualStyleBackColor = true;
            // 
            // btnMCollabRequest
            // 
            this.btnMCollabRequest.Location = new System.Drawing.Point(650, 132);
            this.btnMCollabRequest.Name = "btnMCollabRequest";
            this.btnMCollabRequest.Size = new System.Drawing.Size(142, 34);
            this.btnMCollabRequest.TabIndex = 24;
            this.btnMCollabRequest.Text = "Approve Request";
            this.btnMCollabRequest.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Controls.Add(this.dtpStartDate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtProjTitle);
            this.groupBox2.Controls.Add(this.txtDevName);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.rtbDescrip);
            this.groupBox2.Controls.Add(this.chkAllComments);
            this.groupBox2.Controls.Add(this.txtSearchDevName);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dgvComments);
            this.groupBox2.Location = new System.Drawing.Point(846, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 360);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMMENTS     ";
            // 
            // collaborationBindingSource
            // 
            this.collaborationBindingSource.DataMember = "Collaboration";
            this.collaborationBindingSource.DataSource = this.devApp1;
            // 
            // collaborationTableAdapter
            // 
            this.collaborationTableAdapter.ClearBeforeFill = true;
            // 
            // devIDDataGridViewTextBoxColumn1
            // 
            this.devIDDataGridViewTextBoxColumn1.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn1.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn1.Name = "devIDDataGridViewTextBoxColumn1";
            this.devIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn1.Visible = false;
            this.devIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dgvCollaborators
            // 
            this.dgvCollaborators.AllowUserToAddRows = false;
            this.dgvCollaborators.AllowUserToDeleteRows = false;
            this.dgvCollaborators.AutoGenerateColumns = false;
            this.dgvCollaborators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollaborators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvCollaborators.DataSource = this.developerBindingSource;
            this.dgvCollaborators.Location = new System.Drawing.Point(6, 40);
            this.dgvCollaborators.Name = "dgvCollaborators";
            this.dgvCollaborators.ReadOnly = true;
            this.dgvCollaborators.RowHeadersWidth = 51;
            this.dgvCollaborators.RowTemplate.Height = 24;
            this.dgvCollaborators.Size = new System.Drawing.Size(632, 126);
            this.dgvCollaborators.TabIndex = 22;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AutoGenerateColumns = false;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentIDDataGridViewTextBoxColumn,
            this.devIDDataGridViewTextBoxColumn3,
            this.projIDDataGridViewTextBoxColumn3,
            this.descriptionDataGridViewTextBoxColumn2,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.dgvComments.DataSource = this.commentBindingSource;
            this.dgvComments.Location = new System.Drawing.Point(6, 84);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.ReadOnly = true;
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.Size = new System.Drawing.Size(384, 149);
            this.dgvComments.TabIndex = 0;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataMember = "Comment";
            this.commentBindingSource.DataSource = this.devApp1;
            // 
            // commentTableAdapter
            // 
            this.commentTableAdapter.ClearBeforeFill = true;
            // 
            // commentIDDataGridViewTextBoxColumn
            // 
            this.commentIDDataGridViewTextBoxColumn.DataPropertyName = "commentID";
            this.commentIDDataGridViewTextBoxColumn.HeaderText = "commentID";
            this.commentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentIDDataGridViewTextBoxColumn.Name = "commentIDDataGridViewTextBoxColumn";
            this.commentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentIDDataGridViewTextBoxColumn.Visible = false;
            this.commentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // devIDDataGridViewTextBoxColumn3
            // 
            this.devIDDataGridViewTextBoxColumn3.DataPropertyName = "devID";
            this.devIDDataGridViewTextBoxColumn3.HeaderText = "devID";
            this.devIDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.devIDDataGridViewTextBoxColumn3.Name = "devIDDataGridViewTextBoxColumn3";
            this.devIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.devIDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // projIDDataGridViewTextBoxColumn3
            // 
            this.projIDDataGridViewTextBoxColumn3.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn3.HeaderText = "projID";
            this.projIDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.projIDDataGridViewTextBoxColumn3.Name = "projIDDataGridViewTextBoxColumn3";
            this.projIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.projIDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateCreatedDataGridViewTextBoxColumn.Width = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Search by Dev Name :";
            // 
            // txtSearchDevName
            // 
            this.txtSearchDevName.Location = new System.Drawing.Point(154, 23);
            this.txtSearchDevName.Name = "txtSearchDevName";
            this.txtSearchDevName.Size = new System.Drawing.Size(120, 22);
            this.txtSearchDevName.TabIndex = 2;
            this.txtSearchDevName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chkAllComments
            // 
            this.chkAllComments.AutoSize = true;
            this.chkAllComments.Location = new System.Drawing.Point(279, 24);
            this.chkAllComments.Name = "chkAllComments";
            this.chkAllComments.Size = new System.Drawing.Size(111, 20);
            this.chkAllComments.TabIndex = 3;
            this.chkAllComments.Text = "All Comments";
            this.chkAllComments.UseVisualStyleBackColor = true;
            // 
            // rtbDescrip
            // 
            this.rtbDescrip.Location = new System.Drawing.Point(168, 262);
            this.rtbDescrip.Name = "rtbDescrip";
            this.rtbDescrip.Size = new System.Drawing.Size(218, 92);
            this.rtbDescrip.TabIndex = 4;
            this.rtbDescrip.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(151, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "Description";
            // 
            // txtDevName
            // 
            this.txtDevName.Location = new System.Drawing.Point(26, 265);
            this.txtDevName.Name = "txtDevName";
            this.txtDevName.Size = new System.Drawing.Size(136, 22);
            this.txtDevName.TabIndex = 6;
            // 
            // txtProjTitle
            // 
            this.txtProjTitle.Location = new System.Drawing.Point(18, 317);
            this.txtProjTitle.Name = "txtProjTitle";
            this.txtProjTitle.Size = new System.Drawing.Size(144, 22);
            this.txtProjTitle.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Developer Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Project Title";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(74, 57);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(121, 22);
            this.dtpStartDate.TabIndex = 10;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(265, 57);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(121, 22);
            this.dtpEndDate.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "Start Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(201, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 16);
            this.label19.TabIndex = 13;
            this.label19.Text = "End Date";
            // 
            // txtSearchDev2
            // 
            this.txtSearchDev2.Location = new System.Drawing.Point(167, 14);
            this.txtSearchDev2.Name = "txtSearchDev2";
            this.txtSearchDev2.Size = new System.Drawing.Size(244, 22);
            this.txtSearchDev2.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 16);
            this.label20.TabIndex = 25;
            this.label20.Text = "Search by Dev Name :";
            // 
            // txtProjTitleSearch
            // 
            this.txtProjTitleSearch.Location = new System.Drawing.Point(163, 7);
            this.txtProjTitleSearch.Name = "txtProjTitleSearch";
            this.txtProjTitleSearch.Size = new System.Drawing.Size(367, 22);
            this.txtProjTitleSearch.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 16);
            this.label21.TabIndex = 6;
            this.label21.Text = "Search by Project Title";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 16);
            this.label22.TabIndex = 8;
            this.label22.Text = "Search by Project Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.dateTimePicker4);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.dateTimePicker5);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Location = new System.Drawing.Point(10, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1245, 426);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETAILS:        ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(619, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 254);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ADD A COMMENT TO SELECTED PROJECT     ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 16);
            this.label27.TabIndex = 5;
            this.label27.Text = "Comment ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 185);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(9, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(604, 205);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "COLLABORATORS         ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(167, 14);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(244, 22);
            this.textBox6.TabIndex = 26;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(142, 16);
            this.label29.TabIndex = 25;
            this.label29.Text = "Search by Dev Name :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 38);
            this.button4.TabIndex = 24;
            this.button4.Text = "Request Collaboration";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView3.DataSource = this.developerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 58);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(584, 141);
            this.dataGridView3.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "devID";
            this.dataGridViewTextBoxColumn6.HeaderText = "devID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn7.HeaderText = "name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn8.HeaderText = "surname";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn9.HeaderText = "email";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn10.HeaderText = "password";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox2);
            this.groupBox7.Controls.Add(this.checkBox3);
            this.groupBox7.Location = new System.Drawing.Point(917, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 114);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "is Completed?    ";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(25, 27);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Yes";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(643, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(63, 16);
            this.label30.TabIndex = 15;
            this.label30.Text = "End Date";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(656, 105);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker4.TabIndex = 14;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(643, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 16);
            this.label31.TabIndex = 12;
            this.label31.Text = "Start Date";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(656, 40);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(341, 105);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 22);
            this.textBox7.TabIndex = 10;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(323, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 16);
            this.label32.TabIndex = 9;
            this.label32.Text = "Support";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(323, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 16);
            this.label33.TabIndex = 8;
            this.label33.Text = "Stage";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Planning",
            "Design",
            "Development",
            "Testing",
            "Deployment",
            "Maintenance"});
            this.comboBox2.Location = new System.Drawing.Point(341, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(262, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(31, 82);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(262, 103);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(31, 37);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(262, 22);
            this.textBox9.TabIndex = 5;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 62);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 16);
            this.label34.TabIndex = 4;
            this.label34.Text = "Description";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(33, 16);
            this.label35.TabIndex = 3;
            this.label35.Text = "Title";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 880);
            this.Controls.Add(this.tcProjects);
            this.Controls.Add(this.pnlDetails);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devApp1)).EndInit();
            this.tcProjects.ResumeLayout(false);
            this.tpMyProj.ResumeLayout(false);
            this.tpOtherProj.ResumeLayout(false);
            this.tpOtherProj.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.gbMyProjDet.ResumeLayout(false);
            this.gbMyProjDet.PerformLayout();
            this.gbMCompleted.ResumeLayout(false);
            this.gbMCompleted.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilestones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milestoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).EndInit();
            this.gbCollaborators.ResumeLayout(false);
            this.gbCollaborators.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollaborators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPassword;
        private DevApp devApp1;
        private DevAppTableAdapters.DeveloperTableAdapter developerTableAdapter1;
        private DevAppTableAdapters.ProjectTableAdapter projectTableAdapter1;
        private System.Windows.Forms.TabControl tcProjects;
        private System.Windows.Forms.TabPage tpMyProj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpOtherProj;
        private System.Windows.Forms.DataGridView dgvMyProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.GroupBox gbMyProjDet;
        private System.Windows.Forms.TextBox txtMDescrip;
        private System.Windows.Forms.TextBox txtMTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMStage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpMEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpMStartDate;
        private System.Windows.Forms.TextBox txtMSupport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbMCompleted;
        private System.Windows.Forms.CheckBox chkMNo;
        private System.Windows.Forms.CheckBox chkMYes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMilestones;
        private System.Windows.Forms.DataGridViewTextBoxColumn milestoneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAchievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource milestoneBindingSource;
        private DevAppTableAdapters.MilestoneTableAdapter milestoneTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supportDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompletedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource projectBindingSource1;
        private System.Windows.Forms.GroupBox gbCollaborators;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRequests;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnMCollabRequest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource collaborationBindingSource;
        private DevAppTableAdapters.CollaborationTableAdapter collaborationTableAdapter;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.DataGridView dgvCollaborators;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private DevAppTableAdapters.CommentTableAdapter commentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchDevName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkAllComments;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtProjTitle;
        private System.Windows.Forms.TextBox txtDevName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rtbDescrip;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtProjTitleSearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSearchDev2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
    }
}