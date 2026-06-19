namespace CSMS.Transaction
{
    partial class WorkerPayment
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
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.lblwsalary = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtwname = new System.Windows.Forms.ComboBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet21 = new CSMS.CSMSDBDataSet21();
            this.txtwpid = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblwpname = new System.Windows.Forms.Label();
            this.lblwpid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wpidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet20 = new CSMS.CSMSDBDataSet20();
            this.workerPaymentTableAdapter = new CSMS.CSMSDBDataSet20TableAdapters.WorkerPaymentTableAdapter();
            this.workerTableAdapter = new CSMS.CSMSDBDataSet21TableAdapters.WorkerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-1, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(845, 36);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Worker Payment";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtsalary);
            this.panel1.Controls.Add(this.lblwsalary);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtwname);
            this.panel1.Controls.Add(this.txtwpid);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lblwpname);
            this.panel1.Controls.Add(this.lblwpid);
            this.panel1.Location = new System.Drawing.Point(25, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 307);
            this.panel1.TabIndex = 1;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(231, 155);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(185, 22);
            this.txtsalary.TabIndex = 12;
            this.txtsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalary_KeyPress);
            // 
            // lblwsalary
            // 
            this.lblwsalary.AutoSize = true;
            this.lblwsalary.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwsalary.Location = new System.Drawing.Point(21, 154);
            this.lblwsalary.Name = "lblwsalary";
            this.lblwsalary.Size = new System.Drawing.Size(91, 21);
            this.lblwsalary.TabIndex = 11;
            this.lblwsalary.Text = "Salary Is";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(591, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // txtwname
            // 
            this.txtwname.DataSource = this.workerBindingSource;
            this.txtwname.DisplayMember = "workername";
            this.txtwname.FormattingEnabled = true;
            this.txtwname.Location = new System.Drawing.Point(231, 104);
            this.txtwname.Name = "txtwname";
            this.txtwname.Size = new System.Drawing.Size(185, 24);
            this.txtwname.TabIndex = 9;
            this.txtwname.ValueMember = "workerid";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.cSMSDBDataSet21;
            // 
            // cSMSDBDataSet21
            // 
            this.cSMSDBDataSet21.DataSetName = "CSMSDBDataSet21";
            this.cSMSDBDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtwpid
            // 
            this.txtwpid.Enabled = false;
            this.txtwpid.Location = new System.Drawing.Point(231, 59);
            this.txtwpid.Name = "txtwpid";
            this.txtwpid.Size = new System.Drawing.Size(185, 22);
            this.txtwpid.TabIndex = 8;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Teal;
            this.btnclear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(467, 240);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(99, 40);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Cancel";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(309, 240);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(107, 40);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(142, 240);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(104, 40);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(463, 58);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(52, 21);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "Date";
            // 
            // lblwpname
            // 
            this.lblwpname.AutoSize = true;
            this.lblwpname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwpname.Location = new System.Drawing.Point(21, 102);
            this.lblwpname.Name = "lblwpname";
            this.lblwpname.Size = new System.Drawing.Size(136, 21);
            this.lblwpname.TabIndex = 1;
            this.lblwpname.Text = "Worker Name";
            // 
            // lblwpid
            // 
            this.lblwpid.AutoSize = true;
            this.lblwpid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwpid.Location = new System.Drawing.Point(21, 60);
            this.lblwpid.Name = "lblwpid";
            this.lblwpid.Size = new System.Drawing.Size(191, 21);
            this.lblwpid.TabIndex = 0;
            this.lblwpid.Text = "Worker Payment ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wpidDataGridViewTextBoxColumn,
            this.wnameDataGridViewTextBoxColumn,
            this.wpsalaryDataGridViewTextBoxColumn,
            this.wpdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerPaymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 202);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wpidDataGridViewTextBoxColumn
            // 
            this.wpidDataGridViewTextBoxColumn.DataPropertyName = "wpid";
            this.wpidDataGridViewTextBoxColumn.HeaderText = "wpid";
            this.wpidDataGridViewTextBoxColumn.Name = "wpidDataGridViewTextBoxColumn";
            // 
            // wnameDataGridViewTextBoxColumn
            // 
            this.wnameDataGridViewTextBoxColumn.DataPropertyName = "wname";
            this.wnameDataGridViewTextBoxColumn.HeaderText = "wname";
            this.wnameDataGridViewTextBoxColumn.Name = "wnameDataGridViewTextBoxColumn";
            // 
            // wpsalaryDataGridViewTextBoxColumn
            // 
            this.wpsalaryDataGridViewTextBoxColumn.DataPropertyName = "wpsalary";
            this.wpsalaryDataGridViewTextBoxColumn.HeaderText = "wpsalary";
            this.wpsalaryDataGridViewTextBoxColumn.Name = "wpsalaryDataGridViewTextBoxColumn";
            // 
            // wpdateDataGridViewTextBoxColumn
            // 
            this.wpdateDataGridViewTextBoxColumn.DataPropertyName = "wpdate";
            this.wpdateDataGridViewTextBoxColumn.HeaderText = "wpdate";
            this.wpdateDataGridViewTextBoxColumn.Name = "wpdateDataGridViewTextBoxColumn";
            // 
            // workerPaymentBindingSource
            // 
            this.workerPaymentBindingSource.DataMember = "WorkerPayment";
            this.workerPaymentBindingSource.DataSource = this.cSMSDBDataSet20;
            // 
            // cSMSDBDataSet20
            // 
            this.cSMSDBDataSet20.DataSetName = "CSMSDBDataSet20";
            this.cSMSDBDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerPaymentTableAdapter
            // 
            this.workerPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // WorkerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Name = "WorkerPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerPayment";
            this.Load += new System.EventHandler(this.WorkerPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblwpid;
        private System.Windows.Forms.Label lblwpname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox txtwname;
        private System.Windows.Forms.TextBox txtwpid;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblwsalary;
        private System.Windows.Forms.TextBox txtsalary;
        private CSMSDBDataSet20 cSMSDBDataSet20;
        private System.Windows.Forms.BindingSource workerPaymentBindingSource;
        private CSMSDBDataSet20TableAdapters.WorkerPaymentTableAdapter workerPaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpdateDataGridViewTextBoxColumn;
        private CSMSDBDataSet21 cSMSDBDataSet21;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private CSMSDBDataSet21TableAdapters.WorkerTableAdapter workerTableAdapter;
    }
}