namespace CSMS.Transaction
{
    partial class CustomerPayment
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
            this.cmbsname = new System.Windows.Forms.ComboBox();
            this.cmbcname = new System.Windows.Forms.ComboBox();
            this.enquiryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet44 = new CSMS.CSMSDBDataSet44();
            this.txtoamount = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.lbloamount = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsorder = new System.Windows.Forms.Label();
            this.lblcname = new System.Windows.Forms.Label();
            this.lblcpid = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet45 = new CSMS.CSMSDBDataSet45();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cpidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpsitenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cporderamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet46 = new CSMS.CSMSDBDataSet46();
            this.enquiryTableAdapter = new CSMS.CSMSDBDataSet44TableAdapters.EnquiryTableAdapter();
            this.siteTableAdapter = new CSMS.CSMSDBDataSet45TableAdapters.SiteTableAdapter();
            this.customerPaymentTableAdapter = new CSMS.CSMSDBDataSet46TableAdapters.CustomerPaymentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet46)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-4, 22);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(849, 36);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Customer Payment";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbsname);
            this.panel1.Controls.Add(this.cmbcname);
            this.panel1.Controls.Add(this.txtoamount);
            this.panel1.Controls.Add(this.txtcid);
            this.panel1.Controls.Add(this.lbloamount);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lblsorder);
            this.panel1.Controls.Add(this.lblcname);
            this.panel1.Controls.Add(this.lblcpid);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Location = new System.Drawing.Point(23, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 301);
            this.panel1.TabIndex = 1;
            // 
            // cmbsname
            // 
            this.cmbsname.FormattingEnabled = true;
            this.cmbsname.Location = new System.Drawing.Point(228, 147);
            this.cmbsname.Name = "cmbsname";
            this.cmbsname.Size = new System.Drawing.Size(172, 24);
            this.cmbsname.TabIndex = 20;
            this.cmbsname.SelectedIndexChanged += new System.EventHandler(this.cmbsname_SelectedIndexChanged);
            this.cmbsname.SelectionChangeCommitted += new System.EventHandler(this.cmbsname_SelectionChangeCommitted);
            // 
            // cmbcname
            // 
            this.cmbcname.DataSource = this.enquiryBindingSource;
            this.cmbcname.DisplayMember = "name";
            this.cmbcname.FormattingEnabled = true;
            this.cmbcname.Location = new System.Drawing.Point(228, 97);
            this.cmbcname.Name = "cmbcname";
            this.cmbcname.Size = new System.Drawing.Size(172, 24);
            this.cmbcname.TabIndex = 19;
            this.cmbcname.ValueMember = "name";
            this.cmbcname.SelectionChangeCommitted += new System.EventHandler(this.cmbcname_SelectionChangeCommitted);
            // 
            // enquiryBindingSource
            // 
            this.enquiryBindingSource.DataMember = "Enquiry";
            this.enquiryBindingSource.DataSource = this.cSMSDBDataSet44;
            // 
            // cSMSDBDataSet44
            // 
            this.cSMSDBDataSet44.DataSetName = "CSMSDBDataSet44";
            this.cSMSDBDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtoamount
            // 
            this.txtoamount.Enabled = false;
            this.txtoamount.Location = new System.Drawing.Point(595, 44);
            this.txtoamount.Name = "txtoamount";
            this.txtoamount.Size = new System.Drawing.Size(172, 22);
            this.txtoamount.TabIndex = 16;
            this.txtoamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoamount_KeyPress);
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(228, 43);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(172, 22);
            this.txtcid.TabIndex = 13;
            // 
            // lbloamount
            // 
            this.lbloamount.AutoSize = true;
            this.lbloamount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloamount.Location = new System.Drawing.Point(437, 46);
            this.lbloamount.Name = "lbloamount";
            this.lbloamount.Size = new System.Drawing.Size(140, 21);
            this.lbloamount.TabIndex = 12;
            this.lbloamount.Text = "Order Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(597, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(446, 96);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(52, 21);
            this.lbldate.TabIndex = 10;
            this.lbldate.Text = "Date";
            // 
            // lblsorder
            // 
            this.lblsorder.AutoSize = true;
            this.lblsorder.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsorder.Location = new System.Drawing.Point(12, 146);
            this.lblsorder.Name = "lblsorder";
            this.lblsorder.Size = new System.Drawing.Size(104, 21);
            this.lblsorder.TabIndex = 9;
            this.lblsorder.Text = "Site Name";
            // 
            // lblcname
            // 
            this.lblcname.AutoSize = true;
            this.lblcname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcname.Location = new System.Drawing.Point(12, 95);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(155, 21);
            this.lblcname.TabIndex = 8;
            this.lblcname.Text = "Customer Name";
            // 
            // lblcpid
            // 
            this.lblcpid.AutoSize = true;
            this.lblcpid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpid.Location = new System.Drawing.Point(12, 48);
            this.lblcpid.Name = "lblcpid";
            this.lblcpid.Size = new System.Drawing.Size(206, 21);
            this.lblcpid.TabIndex = 7;
            this.lblcpid.Text = "Customer Payment Id";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(185, 231);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(108, 39);
            this.btnnew.TabIndex = 3;
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
            this.btnsave.Location = new System.Drawing.Point(338, 231);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(108, 39);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Teal;
            this.btnclear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(496, 231);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(108, 39);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.cSMSDBDataSet45;
            // 
            // cSMSDBDataSet45
            // 
            this.cSMSDBDataSet45.DataSetName = "CSMSDBDataSet45";
            this.cSMSDBDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpidDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.cpsitenameDataGridViewTextBoxColumn,
            this.cporderamountDataGridViewTextBoxColumn,
            this.cpdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerPaymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 197);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cpidDataGridViewTextBoxColumn
            // 
            this.cpidDataGridViewTextBoxColumn.DataPropertyName = "cpid";
            this.cpidDataGridViewTextBoxColumn.HeaderText = "cpid";
            this.cpidDataGridViewTextBoxColumn.Name = "cpidDataGridViewTextBoxColumn";
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customername";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customername";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // cpsitenameDataGridViewTextBoxColumn
            // 
            this.cpsitenameDataGridViewTextBoxColumn.DataPropertyName = "cpsitename";
            this.cpsitenameDataGridViewTextBoxColumn.HeaderText = "cpsitename";
            this.cpsitenameDataGridViewTextBoxColumn.Name = "cpsitenameDataGridViewTextBoxColumn";
            // 
            // cporderamountDataGridViewTextBoxColumn
            // 
            this.cporderamountDataGridViewTextBoxColumn.DataPropertyName = "cporderamount";
            this.cporderamountDataGridViewTextBoxColumn.HeaderText = "cporderamount";
            this.cporderamountDataGridViewTextBoxColumn.Name = "cporderamountDataGridViewTextBoxColumn";
            // 
            // cpdateDataGridViewTextBoxColumn
            // 
            this.cpdateDataGridViewTextBoxColumn.DataPropertyName = "cpdate";
            this.cpdateDataGridViewTextBoxColumn.HeaderText = "cpdate";
            this.cpdateDataGridViewTextBoxColumn.Name = "cpdateDataGridViewTextBoxColumn";
            // 
            // customerPaymentBindingSource
            // 
            this.customerPaymentBindingSource.DataMember = "CustomerPayment";
            this.customerPaymentBindingSource.DataSource = this.cSMSDBDataSet46;
            // 
            // cSMSDBDataSet46
            // 
            this.cSMSDBDataSet46.DataSetName = "CSMSDBDataSet46";
            this.cSMSDBDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enquiryTableAdapter
            // 
            this.enquiryTableAdapter.ClearBeforeFill = true;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // customerPaymentTableAdapter
            // 
            this.customerPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Name = "CustomerPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPayment";
            this.Load += new System.EventHandler(this.CustomerPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet46)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsorder;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.Label lblcpid;
        private System.Windows.Forms.Label lbloamount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtoamount;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.ComboBox cmbcname;
        private CSMSDBDataSet44 cSMSDBDataSet44;
        private System.Windows.Forms.BindingSource enquiryBindingSource;
        private CSMSDBDataSet44TableAdapters.EnquiryTableAdapter enquiryTableAdapter;
        private System.Windows.Forms.ComboBox cmbsname;
        private CSMSDBDataSet45 cSMSDBDataSet45;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private CSMSDBDataSet45TableAdapters.SiteTableAdapter siteTableAdapter;
        private CSMSDBDataSet46 cSMSDBDataSet46;
        private System.Windows.Forms.BindingSource customerPaymentBindingSource;
        private CSMSDBDataSet46TableAdapters.CustomerPaymentTableAdapter customerPaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpsitenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cporderamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpdateDataGridViewTextBoxColumn;
    }
}