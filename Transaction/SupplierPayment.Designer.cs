namespace CSMS.Transaction
{
    partial class SupplierPayment
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
            this.lblspid = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.lblsptotal = new System.Windows.Forms.Label();
            this.lblspaidamount = new System.Windows.Forms.Label();
            this.lblpdue = new System.Windows.Forms.Label();
            this.lblpdate = new System.Windows.Forms.Label();
            this.lblspstatus = new System.Windows.Forms.Label();
            this.lblpdescription = new System.Windows.Forms.Label();
            this.lblbankname = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtspid = new System.Windows.Forms.TextBox();
            this.txtsptotal = new System.Windows.Forms.TextBox();
            this.txtspaidamount = new System.Windows.Forms.TextBox();
            this.txtspdue = new System.Windows.Forms.TextBox();
            this.txtspdescription = new System.Windows.Forms.TextBox();
            this.txtsbankname = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet23 = new CSMS.CSMSDBDataSet23();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sptotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sppaidamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spdueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spbanknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet22 = new CSMS.CSMSDBDataSet22();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.cmborderid = new System.Windows.Forms.ComboBox();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet35 = new CSMS.CSMSDBDataSet35();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.supplier_PaymentTableAdapter = new CSMS.CSMSDBDataSet22TableAdapters.Supplier_PaymentTableAdapter();
            this.supplierTableAdapter = new CSMS.CSMSDBDataSet23TableAdapters.SupplierTableAdapter();
            this.purchase_OrderTableAdapter = new CSMS.CSMSDBDataSet35TableAdapters.Purchase_OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet22)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet35)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-2, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(864, 43);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Supplier Payment";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblspid
            // 
            this.lblspid.AutoSize = true;
            this.lblspid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspid.Location = new System.Drawing.Point(16, 1);
            this.lblspid.Name = "lblspid";
            this.lblspid.Size = new System.Drawing.Size(200, 21);
            this.lblspid.TabIndex = 1;
            this.lblspid.Text = "Supplier Payment ID";
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.Location = new System.Drawing.Point(16, 48);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(145, 21);
            this.lblsname.TabIndex = 2;
            this.lblsname.Text = "Supplier Name";
            // 
            // lblsptotal
            // 
            this.lblsptotal.AutoSize = true;
            this.lblsptotal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsptotal.Location = new System.Drawing.Point(16, 167);
            this.lblsptotal.Name = "lblsptotal";
            this.lblsptotal.Size = new System.Drawing.Size(136, 21);
            this.lblsptotal.TabIndex = 3;
            this.lblsptotal.Text = "Total Amount";
            // 
            // lblspaidamount
            // 
            this.lblspaidamount.AutoSize = true;
            this.lblspaidamount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspaidamount.Location = new System.Drawing.Point(16, 213);
            this.lblspaidamount.Name = "lblspaidamount";
            this.lblspaidamount.Size = new System.Drawing.Size(127, 21);
            this.lblspaidamount.TabIndex = 4;
            this.lblspaidamount.Text = "paid Amount";
            // 
            // lblpdue
            // 
            this.lblpdue.AutoSize = true;
            this.lblpdue.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdue.Location = new System.Drawing.Point(16, 265);
            this.lblpdue.Name = "lblpdue";
            this.lblpdue.Size = new System.Drawing.Size(130, 21);
            this.lblpdue.TabIndex = 5;
            this.lblpdue.Text = "Payment Due";
            // 
            // lblpdate
            // 
            this.lblpdate.AutoSize = true;
            this.lblpdate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdate.Location = new System.Drawing.Point(450, 1);
            this.lblpdate.Name = "lblpdate";
            this.lblpdate.Size = new System.Drawing.Size(52, 21);
            this.lblpdate.TabIndex = 6;
            this.lblpdate.Text = "Date";
            // 
            // lblspstatus
            // 
            this.lblspstatus.AutoSize = true;
            this.lblspstatus.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspstatus.Location = new System.Drawing.Point(450, 48);
            this.lblspstatus.Name = "lblspstatus";
            this.lblspstatus.Size = new System.Drawing.Size(66, 21);
            this.lblspstatus.TabIndex = 7;
            this.lblspstatus.Text = "Status";
            // 
            // lblpdescription
            // 
            this.lblpdescription.AutoSize = true;
            this.lblpdescription.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdescription.Location = new System.Drawing.Point(450, 167);
            this.lblpdescription.Name = "lblpdescription";
            this.lblpdescription.Size = new System.Drawing.Size(116, 21);
            this.lblpdescription.TabIndex = 8;
            this.lblpdescription.Text = "Description";
            // 
            // lblbankname
            // 
            this.lblbankname.AutoSize = true;
            this.lblbankname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbankname.Location = new System.Drawing.Point(450, 213);
            this.lblbankname.Name = "lblbankname";
            this.lblbankname.Size = new System.Drawing.Size(114, 21);
            this.lblbankname.TabIndex = 9;
            this.lblbankname.Text = "Bank Name";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(64, 316);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(97, 34);
            this.btnnew.TabIndex = 10;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(200, 316);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 34);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Teal;
            this.btnclear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(347, 316);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(97, 34);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtspid
            // 
            this.txtspid.Location = new System.Drawing.Point(232, 3);
            this.txtspid.Name = "txtspid";
            this.txtspid.Size = new System.Drawing.Size(159, 22);
            this.txtspid.TabIndex = 14;
            // 
            // txtsptotal
            // 
            this.txtsptotal.Location = new System.Drawing.Point(234, 164);
            this.txtsptotal.Name = "txtsptotal";
            this.txtsptotal.ReadOnly = true;
            this.txtsptotal.Size = new System.Drawing.Size(159, 22);
            this.txtsptotal.TabIndex = 15;
            this.txtsptotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsptotal_KeyPress);
            // 
            // txtspaidamount
            // 
            this.txtspaidamount.Location = new System.Drawing.Point(234, 208);
            this.txtspaidamount.Name = "txtspaidamount";
            this.txtspaidamount.Size = new System.Drawing.Size(159, 22);
            this.txtspaidamount.TabIndex = 16;
            this.txtspaidamount.TextChanged += new System.EventHandler(this.txtspaidamount_TextChanged);
            this.txtspaidamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtspaidamount_KeyPress);
            // 
            // txtspdue
            // 
            this.txtspdue.Location = new System.Drawing.Point(234, 260);
            this.txtspdue.Name = "txtspdue";
            this.txtspdue.ReadOnly = true;
            this.txtspdue.Size = new System.Drawing.Size(159, 22);
            this.txtspdue.TabIndex = 17;
            this.txtspdue.TextChanged += new System.EventHandler(this.txtspdue_TextChanged);
            this.txtspdue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtspdue_KeyPress);
            // 
            // txtspdescription
            // 
            this.txtspdescription.Location = new System.Drawing.Point(593, 162);
            this.txtspdescription.Name = "txtspdescription";
            this.txtspdescription.Size = new System.Drawing.Size(157, 22);
            this.txtspdescription.TabIndex = 19;
            // 
            // txtsbankname
            // 
            this.txtsbankname.Location = new System.Drawing.Point(593, 213);
            this.txtsbankname.Name = "txtsbankname";
            this.txtsbankname.Size = new System.Drawing.Size(157, 22);
            this.txtsbankname.TabIndex = 20;
            this.txtsbankname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsbankname_KeyPress);
            // 
            // txtsid
            // 
            this.txtsid.DataSource = this.supplierBindingSource;
            this.txtsid.DisplayMember = "sname";
            this.txtsid.FormattingEnabled = true;
            this.txtsid.Location = new System.Drawing.Point(232, 49);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(159, 24);
            this.txtsid.TabIndex = 22;
            this.txtsid.ValueMember = "sid";
            this.txtsid.SelectionChangeCommitted += new System.EventHandler(this.txtsid_SelectionChangeCommitted);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.cSMSDBDataSet23;
            // 
            // cSMSDBDataSet23
            // 
            this.cSMSDBDataSet23.DataSetName = "CSMSDBDataSet23";
            this.cSMSDBDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.sptotalDataGridViewTextBoxColumn,
            this.sppaidamountDataGridViewTextBoxColumn,
            this.spdueDataGridViewTextBoxColumn,
            this.spstatusDataGridViewTextBoxColumn,
            this.spdescriptionDataGridViewTextBoxColumn,
            this.spbanknameDataGridViewTextBoxColumn,
            this.spdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierPaymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 475);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 194);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // spidDataGridViewTextBoxColumn
            // 
            this.spidDataGridViewTextBoxColumn.DataPropertyName = "spid";
            this.spidDataGridViewTextBoxColumn.HeaderText = "spid";
            this.spidDataGridViewTextBoxColumn.Name = "spidDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // sptotalDataGridViewTextBoxColumn
            // 
            this.sptotalDataGridViewTextBoxColumn.DataPropertyName = "sptotal";
            this.sptotalDataGridViewTextBoxColumn.HeaderText = "sptotal";
            this.sptotalDataGridViewTextBoxColumn.Name = "sptotalDataGridViewTextBoxColumn";
            // 
            // sppaidamountDataGridViewTextBoxColumn
            // 
            this.sppaidamountDataGridViewTextBoxColumn.DataPropertyName = "sppaidamount";
            this.sppaidamountDataGridViewTextBoxColumn.HeaderText = "sppaidamount";
            this.sppaidamountDataGridViewTextBoxColumn.Name = "sppaidamountDataGridViewTextBoxColumn";
            // 
            // spdueDataGridViewTextBoxColumn
            // 
            this.spdueDataGridViewTextBoxColumn.DataPropertyName = "spdue";
            this.spdueDataGridViewTextBoxColumn.HeaderText = "spdue";
            this.spdueDataGridViewTextBoxColumn.Name = "spdueDataGridViewTextBoxColumn";
            // 
            // spstatusDataGridViewTextBoxColumn
            // 
            this.spstatusDataGridViewTextBoxColumn.DataPropertyName = "spstatus";
            this.spstatusDataGridViewTextBoxColumn.HeaderText = "spstatus";
            this.spstatusDataGridViewTextBoxColumn.Name = "spstatusDataGridViewTextBoxColumn";
            // 
            // spdescriptionDataGridViewTextBoxColumn
            // 
            this.spdescriptionDataGridViewTextBoxColumn.DataPropertyName = "spdescription";
            this.spdescriptionDataGridViewTextBoxColumn.HeaderText = "spdescription";
            this.spdescriptionDataGridViewTextBoxColumn.Name = "spdescriptionDataGridViewTextBoxColumn";
            // 
            // spbanknameDataGridViewTextBoxColumn
            // 
            this.spbanknameDataGridViewTextBoxColumn.DataPropertyName = "spbankname";
            this.spbanknameDataGridViewTextBoxColumn.HeaderText = "spbankname";
            this.spbanknameDataGridViewTextBoxColumn.Name = "spbanknameDataGridViewTextBoxColumn";
            // 
            // spdateDataGridViewTextBoxColumn
            // 
            this.spdateDataGridViewTextBoxColumn.DataPropertyName = "spdate";
            this.spdateDataGridViewTextBoxColumn.HeaderText = "spdate";
            this.spdateDataGridViewTextBoxColumn.Name = "spdateDataGridViewTextBoxColumn";
            // 
            // supplierPaymentBindingSource
            // 
            this.supplierPaymentBindingSource.DataMember = "Supplier_Payment";
            this.supplierPaymentBindingSource.DataSource = this.cSMSDBDataSet22;
            // 
            // cSMSDBDataSet22
            // 
            this.cSMSDBDataSet22.DataSetName = "CSMSDBDataSet22";
            this.cSMSDBDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOrderStatus);
            this.panel1.Controls.Add(this.cmborderid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtsid);
            this.panel1.Controls.Add(this.txtsbankname);
            this.panel1.Controls.Add(this.txtspdescription);
            this.panel1.Controls.Add(this.txtspdue);
            this.panel1.Controls.Add(this.txtspaidamount);
            this.panel1.Controls.Add(this.txtsptotal);
            this.panel1.Controls.Add(this.txtspid);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.lblbankname);
            this.panel1.Controls.Add(this.lblpdescription);
            this.panel1.Controls.Add(this.lblspstatus);
            this.panel1.Controls.Add(this.lblpdate);
            this.panel1.Controls.Add(this.lblpdue);
            this.panel1.Controls.Add(this.lblspaidamount);
            this.panel1.Controls.Add(this.lblsptotal);
            this.panel1.Controls.Add(this.lblsname);
            this.panel1.Controls.Add(this.lblspid);
            this.panel1.Location = new System.Drawing.Point(27, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 373);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Location = new System.Drawing.Point(593, 46);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.ReadOnly = true;
            this.txtOrderStatus.Size = new System.Drawing.Size(157, 22);
            this.txtOrderStatus.TabIndex = 29;
            // 
            // cmborderid
            // 
            this.cmborderid.DataSource = this.purchaseOrderBindingSource;
            this.cmborderid.DisplayMember = "poid";
            this.cmborderid.FormattingEnabled = true;
            this.cmborderid.Location = new System.Drawing.Point(232, 104);
            this.cmborderid.Name = "cmborderid";
            this.cmborderid.Size = new System.Drawing.Size(159, 24);
            this.cmborderid.TabIndex = 28;
            this.cmborderid.ValueMember = "poid";
            this.cmborderid.SelectedIndexChanged += new System.EventHandler(this.cmborderid_SelectedIndexChanged);
            this.cmborderid.SelectionChangeCommitted += new System.EventHandler(this.cmborderid_SelectionChangeCommitted);
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "Purchase_Order";
            this.purchaseOrderBindingSource.DataSource = this.cSMSDBDataSet35;
            // 
            // cSMSDBDataSet35
            // 
            this.cSMSDBDataSet35.DataSetName = "CSMSDBDataSet35";
            this.cSMSDBDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Purchase Order Id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(593, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // supplier_PaymentTableAdapter
            // 
            this.supplier_PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_OrderTableAdapter
            // 
            this.purchase_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltitle);
            this.Name = "SupplierPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierPayment";
            this.Load += new System.EventHandler(this.SupplierPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet22)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet35)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblspid;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblsptotal;
        private System.Windows.Forms.Label lblspaidamount;
        private System.Windows.Forms.Label lblpdue;
        private System.Windows.Forms.Label lblpdate;
        private System.Windows.Forms.Label lblspstatus;
        private System.Windows.Forms.Label lblpdescription;
        private System.Windows.Forms.Label lblbankname;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtspid;
        private System.Windows.Forms.TextBox txtsptotal;
        private System.Windows.Forms.TextBox txtspaidamount;
        private System.Windows.Forms.TextBox txtspdue;
        private System.Windows.Forms.TextBox txtspdescription;
        private System.Windows.Forms.TextBox txtsbankname;
        private System.Windows.Forms.ComboBox txtsid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CSMSDBDataSet22 cSMSDBDataSet22;
        private System.Windows.Forms.BindingSource supplierPaymentBindingSource;
        private CSMSDBDataSet22TableAdapters.Supplier_PaymentTableAdapter supplier_PaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn spidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sptotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sppaidamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spdueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spbanknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spdateDataGridViewTextBoxColumn;
        private CSMSDBDataSet23 cSMSDBDataSet23;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private CSMSDBDataSet23TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.ComboBox cmborderid;
        private System.Windows.Forms.Label label1;
        private CSMSDBDataSet35 cSMSDBDataSet35;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private CSMSDBDataSet35TableAdapters.Purchase_OrderTableAdapter purchase_OrderTableAdapter;
        private System.Windows.Forms.TextBox txtOrderStatus;
    }
}