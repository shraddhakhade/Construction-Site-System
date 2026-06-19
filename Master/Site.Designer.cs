namespace CSMS.Master
{
    partial class Site
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbcname = new System.Windows.Forms.ComboBox();
            this.enquiryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet47 = new CSMS.CSMSDBDataSet47();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotalbudget = new System.Windows.Forms.TextBox();
            this.txtsquarefeet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsitemanager = new System.Windows.Forms.ComboBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet34 = new CSMS.CSMSDBDataSet34();
            this.txtenddate = new System.Windows.Forms.DateTimePicker();
            this.txtstartdate = new System.Windows.Forms.DateTimePicker();
            this.txtsiteaddress = new System.Windows.Forms.TextBox();
            this.txtsitename = new System.Windows.Forms.TextBox();
            this.txtsiteid = new System.Windows.Forms.TextBox();
            this.lblsenddate = new System.Windows.Forms.Label();
            this.lblsmanager = new System.Windows.Forms.Label();
            this.lblsstartdate = new System.Windows.Forms.Label();
            this.lblsaddress = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitestartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitemanagernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteexceptedenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitebudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet48 = new CSMS.CSMSDBDataSet48();
            this.workerTableAdapter = new CSMS.CSMSDBDataSet34TableAdapters.WorkerTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enquiryTableAdapter = new CSMS.CSMSDBDataSet47TableAdapters.EnquiryTableAdapter();
            this.siteTableAdapter = new CSMS.CSMSDBDataSet48TableAdapters.SiteTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet48)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-1, 25);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(894, 45);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Site Details";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txttotalbudget);
            this.panel1.Controls.Add(this.txtsquarefeet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsitemanager);
            this.panel1.Controls.Add(this.txtenddate);
            this.panel1.Controls.Add(this.txtstartdate);
            this.panel1.Controls.Add(this.txtsiteaddress);
            this.panel1.Controls.Add(this.txtsitename);
            this.panel1.Controls.Add(this.txtsiteid);
            this.panel1.Controls.Add(this.lblsenddate);
            this.panel1.Controls.Add(this.lblsmanager);
            this.panel1.Controls.Add(this.lblsstartdate);
            this.panel1.Controls.Add(this.lblsaddress);
            this.panel1.Controls.Add(this.lblsname);
            this.panel1.Controls.Add(this.lblsid);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btncancle);
            this.panel1.Location = new System.Drawing.Point(31, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 291);
            this.panel1.TabIndex = 1;
            // 
            // cmbcname
            // 
            this.cmbcname.DataSource = this.enquiryBindingSource;
            this.cmbcname.DisplayMember = "name";
            this.cmbcname.FormattingEnabled = true;
            this.cmbcname.Location = new System.Drawing.Point(194, 105);
            this.cmbcname.Margin = new System.Windows.Forms.Padding(2);
            this.cmbcname.Name = "cmbcname";
            this.cmbcname.Size = new System.Drawing.Size(174, 24);
            this.cmbcname.TabIndex = 5;
            this.cmbcname.ValueMember = "name";
            // 
            // enquiryBindingSource
            // 
            this.enquiryBindingSource.DataMember = "Enquiry";
            this.enquiryBindingSource.DataSource = this.cSMSDBDataSet47;
            // 
            // cSMSDBDataSet47
            // 
            this.cSMSDBDataSet47.DataSetName = "CSMSDBDataSet47";
            this.cSMSDBDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Customer Name";
            // 
            // txttotalbudget
            // 
            this.txttotalbudget.Location = new System.Drawing.Point(615, 169);
            this.txttotalbudget.Name = "txttotalbudget";
            this.txttotalbudget.Size = new System.Drawing.Size(174, 22);
            this.txttotalbudget.TabIndex = 23;
            // 
            // txtsquarefeet
            // 
            this.txtsquarefeet.Location = new System.Drawing.Point(194, 193);
            this.txtsquarefeet.Name = "txtsquarefeet";
            this.txtsquarefeet.Size = new System.Drawing.Size(174, 22);
            this.txtsquarefeet.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Budget Rs. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Total Square Feet";
            // 
            // txtsitemanager
            // 
            this.txtsitemanager.DataSource = this.workerBindingSource;
            this.txtsitemanager.DisplayMember = "workername";
            this.txtsitemanager.FormattingEnabled = true;
            this.txtsitemanager.Location = new System.Drawing.Point(615, 67);
            this.txtsitemanager.Name = "txtsitemanager";
            this.txtsitemanager.Size = new System.Drawing.Size(166, 24);
            this.txtsitemanager.TabIndex = 19;
            this.txtsitemanager.ValueMember = "workername";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.cSMSDBDataSet34;
            // 
            // cSMSDBDataSet34
            // 
            this.cSMSDBDataSet34.DataSetName = "CSMSDBDataSet34";
            this.cSMSDBDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtenddate
            // 
            this.txtenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtenddate.Location = new System.Drawing.Point(615, 117);
            this.txtenddate.Name = "txtenddate";
            this.txtenddate.Size = new System.Drawing.Size(166, 22);
            this.txtenddate.TabIndex = 18;
            // 
            // txtstartdate
            // 
            this.txtstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtstartdate.Location = new System.Drawing.Point(615, 14);
            this.txtstartdate.Name = "txtstartdate";
            this.txtstartdate.Size = new System.Drawing.Size(166, 22);
            this.txtstartdate.TabIndex = 17;
            // 
            // txtsiteaddress
            // 
            this.txtsiteaddress.Location = new System.Drawing.Point(194, 146);
            this.txtsiteaddress.Name = "txtsiteaddress";
            this.txtsiteaddress.Size = new System.Drawing.Size(174, 22);
            this.txtsiteaddress.TabIndex = 15;
            // 
            // txtsitename
            // 
            this.txtsitename.Location = new System.Drawing.Point(194, 61);
            this.txtsitename.Name = "txtsitename";
            this.txtsitename.Size = new System.Drawing.Size(174, 22);
            this.txtsitename.TabIndex = 14;
            // 
            // txtsiteid
            // 
            this.txtsiteid.Enabled = false;
            this.txtsiteid.Location = new System.Drawing.Point(194, 14);
            this.txtsiteid.Name = "txtsiteid";
            this.txtsiteid.Size = new System.Drawing.Size(174, 22);
            this.txtsiteid.TabIndex = 13;
            // 
            // lblsenddate
            // 
            this.lblsenddate.AutoSize = true;
            this.lblsenddate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenddate.Location = new System.Drawing.Point(410, 117);
            this.lblsenddate.Name = "lblsenddate";
            this.lblsenddate.Size = new System.Drawing.Size(182, 21);
            this.lblsenddate.TabIndex = 12;
            this.lblsenddate.Text = "Excepted End Date";
            // 
            // lblsmanager
            // 
            this.lblsmanager.AutoSize = true;
            this.lblsmanager.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmanager.Location = new System.Drawing.Point(410, 61);
            this.lblsmanager.Name = "lblsmanager";
            this.lblsmanager.Size = new System.Drawing.Size(147, 21);
            this.lblsmanager.TabIndex = 11;
            this.lblsmanager.Text = "Manager Name";
            // 
            // lblsstartdate
            // 
            this.lblsstartdate.AutoSize = true;
            this.lblsstartdate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsstartdate.Location = new System.Drawing.Point(410, 14);
            this.lblsstartdate.Name = "lblsstartdate";
            this.lblsstartdate.Size = new System.Drawing.Size(102, 21);
            this.lblsstartdate.TabIndex = 10;
            this.lblsstartdate.Text = "Start Date";
            // 
            // lblsaddress
            // 
            this.lblsaddress.AutoSize = true;
            this.lblsaddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaddress.Location = new System.Drawing.Point(40, 152);
            this.lblsaddress.Name = "lblsaddress";
            this.lblsaddress.Size = new System.Drawing.Size(83, 21);
            this.lblsaddress.TabIndex = 9;
            this.lblsaddress.Text = "Address";
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.Location = new System.Drawing.Point(40, 71);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(104, 21);
            this.lblsname.TabIndex = 8;
            this.lblsname.Text = "Site Name";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.Location = new System.Drawing.Point(40, 19);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(75, 21);
            this.lblsid.TabIndex = 7;
            this.lblsid.Text = "Site ID";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(86, 229);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(109, 42);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(228, 229);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(109, 42);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(356, 228);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 42);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Teal;
            this.btndelete.Enabled = false;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(499, 228);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(109, 42);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Teal;
            this.btncancle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(632, 229);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(109, 42);
            this.btncancle.TabIndex = 6;
            this.btncancle.Text = "cancel";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteidDataGridViewTextBoxColumn,
            this.sitenameDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.siteaddressDataGridViewTextBoxColumn,
            this.sitestartdateDataGridViewTextBoxColumn,
            this.sitemanagernameDataGridViewTextBoxColumn,
            this.siteexceptedenddateDataGridViewTextBoxColumn,
            this.siteareaDataGridViewTextBoxColumn,
            this.sitebudgetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 476);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siteidDataGridViewTextBoxColumn
            // 
            this.siteidDataGridViewTextBoxColumn.DataPropertyName = "siteid";
            this.siteidDataGridViewTextBoxColumn.HeaderText = "siteid";
            this.siteidDataGridViewTextBoxColumn.Name = "siteidDataGridViewTextBoxColumn";
            // 
            // sitenameDataGridViewTextBoxColumn
            // 
            this.sitenameDataGridViewTextBoxColumn.DataPropertyName = "sitename";
            this.sitenameDataGridViewTextBoxColumn.HeaderText = "sitename";
            this.sitenameDataGridViewTextBoxColumn.Name = "sitenameDataGridViewTextBoxColumn";
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "cname";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // siteaddressDataGridViewTextBoxColumn
            // 
            this.siteaddressDataGridViewTextBoxColumn.DataPropertyName = "siteaddress";
            this.siteaddressDataGridViewTextBoxColumn.HeaderText = "siteaddress";
            this.siteaddressDataGridViewTextBoxColumn.Name = "siteaddressDataGridViewTextBoxColumn";
            // 
            // sitestartdateDataGridViewTextBoxColumn
            // 
            this.sitestartdateDataGridViewTextBoxColumn.DataPropertyName = "sitestartdate";
            this.sitestartdateDataGridViewTextBoxColumn.HeaderText = "sitestartdate";
            this.sitestartdateDataGridViewTextBoxColumn.Name = "sitestartdateDataGridViewTextBoxColumn";
            // 
            // sitemanagernameDataGridViewTextBoxColumn
            // 
            this.sitemanagernameDataGridViewTextBoxColumn.DataPropertyName = "sitemanagername";
            this.sitemanagernameDataGridViewTextBoxColumn.HeaderText = "sitemanagername";
            this.sitemanagernameDataGridViewTextBoxColumn.Name = "sitemanagernameDataGridViewTextBoxColumn";
            // 
            // siteexceptedenddateDataGridViewTextBoxColumn
            // 
            this.siteexceptedenddateDataGridViewTextBoxColumn.DataPropertyName = "siteexceptedenddate";
            this.siteexceptedenddateDataGridViewTextBoxColumn.HeaderText = "siteexceptedenddate";
            this.siteexceptedenddateDataGridViewTextBoxColumn.Name = "siteexceptedenddateDataGridViewTextBoxColumn";
            // 
            // siteareaDataGridViewTextBoxColumn
            // 
            this.siteareaDataGridViewTextBoxColumn.DataPropertyName = "sitearea";
            this.siteareaDataGridViewTextBoxColumn.HeaderText = "sitearea";
            this.siteareaDataGridViewTextBoxColumn.Name = "siteareaDataGridViewTextBoxColumn";
            // 
            // sitebudgetDataGridViewTextBoxColumn
            // 
            this.sitebudgetDataGridViewTextBoxColumn.DataPropertyName = "sitebudget";
            this.sitebudgetDataGridViewTextBoxColumn.HeaderText = "sitebudget";
            this.sitebudgetDataGridViewTextBoxColumn.Name = "sitebudgetDataGridViewTextBoxColumn";
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.cSMSDBDataSet48;
            // 
            // cSMSDBDataSet48
            // 
            this.cSMSDBDataSet48.DataSetName = "CSMSDBDataSet48";
            this.cSMSDBDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(893, 27);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Searching";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(492, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 28);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Site Name";
            // 
            // enquiryTableAdapter
            // 
            this.enquiryTableAdapter.ClearBeforeFill = true;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "Site";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Site";
            this.Load += new System.EventHandler(this.Site_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet48)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.DateTimePicker txtenddate;
        private System.Windows.Forms.DateTimePicker txtstartdate;
        private System.Windows.Forms.TextBox txtsiteaddress;
        private System.Windows.Forms.TextBox txtsitename;
        private System.Windows.Forms.TextBox txtsiteid;
        private System.Windows.Forms.Label lblsenddate;
        private System.Windows.Forms.Label lblsmanager;
        private System.Windows.Forms.Label lblsstartdate;
        private System.Windows.Forms.Label lblsaddress;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.ComboBox txtsitemanager;
        private CSMSDBDataSet34 cSMSDBDataSet34;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private CSMSDBDataSet34TableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalbudget;
        private System.Windows.Forms.TextBox txtsquarefeet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcname;
        private CSMSDBDataSet47 cSMSDBDataSet47;
        private System.Windows.Forms.BindingSource enquiryBindingSource;
        private CSMSDBDataSet47TableAdapters.EnquiryTableAdapter enquiryTableAdapter;
        private CSMSDBDataSet48 cSMSDBDataSet48;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private CSMSDBDataSet48TableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitestartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitemanagernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteexceptedenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitebudgetDataGridViewTextBoxColumn;
    }
}