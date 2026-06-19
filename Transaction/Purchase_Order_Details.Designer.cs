namespace CSMS.Transaction
{
    partial class Purchase_Order_Details
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
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet32 = new CSMS.CSMSDBDataSet32();
            this.lbldate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblpoid = new System.Windows.Forms.Label();
            this.txtpoid = new System.Windows.Forms.TextBox();
            this.lblsname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblfamount = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lbltotal2 = new System.Windows.Forms.Label();
            this.lblmquantity = new System.Windows.Forms.Label();
            this.lblmprice = new System.Windows.Forms.Label();
            this.txtgrand = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbmname = new System.Windows.Forms.ComboBox();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet42 = new CSMS.CSMSDBDataSet42();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblmname = new System.Windows.Forms.Label();
            this.txtpodid = new System.Windows.Forms.TextBox();
            this.txtst2 = new System.Windows.Forms.TextBox();
            this.txtst1 = new System.Windows.Forms.TextBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet33 = new CSMS.CSMSDBDataSet33();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtgst = new System.Windows.Forms.TextBox();
            this.lblgst = new System.Windows.Forms.Label();
            this.lblgst2 = new System.Windows.Forms.Label();
            this.supplierTableAdapter = new CSMS.CSMSDBDataSet32TableAdapters.SupplierTableAdapter();
            this.materialTableAdapter = new CSMS.CSMSDBDataSet33TableAdapters.MaterialTableAdapter();
            this.materialTableAdapter1 = new CSMS.CSMSDBDataSet42TableAdapters.MaterialTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet33)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-3, 7);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(908, 39);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Purchase Order Details";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbsname);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblpoid);
            this.panel1.Controls.Add(this.txtpoid);
            this.panel1.Controls.Add(this.lblsname);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 109);
            this.panel1.TabIndex = 1;
            // 
            // cmbsname
            // 
            this.cmbsname.DataSource = this.supplierBindingSource;
            this.cmbsname.DisplayMember = "sname";
            this.cmbsname.FormattingEnabled = true;
            this.cmbsname.Location = new System.Drawing.Point(235, 66);
            this.cmbsname.Name = "cmbsname";
            this.cmbsname.Size = new System.Drawing.Size(175, 24);
            this.cmbsname.TabIndex = 17;
            this.cmbsname.ValueMember = "sid";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.cSMSDBDataSet32;
            // 
            // cSMSDBDataSet32
            // 
            this.cSMSDBDataSet32.DataSetName = "CSMSDBDataSet32";
            this.cSMSDBDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(524, 19);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(52, 21);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(623, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // lblpoid
            // 
            this.lblpoid.AutoSize = true;
            this.lblpoid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpoid.Location = new System.Drawing.Point(19, 20);
            this.lblpoid.Name = "lblpoid";
            this.lblpoid.Size = new System.Drawing.Size(174, 21);
            this.lblpoid.TabIndex = 5;
            this.lblpoid.Text = "Purchase order ID";
            // 
            // txtpoid
            // 
            this.txtpoid.Location = new System.Drawing.Point(235, 19);
            this.txtpoid.Name = "txtpoid";
            this.txtpoid.Size = new System.Drawing.Size(175, 22);
            this.txtpoid.TabIndex = 16;
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.Location = new System.Drawing.Point(19, 69);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(145, 21);
            this.lblsname.TabIndex = 6;
            this.lblsname.Text = "Supplier Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialName,
            this.Price,
            this.Quantity,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(23, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 154);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaterialName
            // 
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.Name = "MaterialName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(12, 24);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(104, 41);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(147, 24);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 41);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Teal;
            this.btncancle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(78, 93);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(103, 41);
            this.btncancle.TabIndex = 3;
            this.btncancle.Text = "Cancel";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Teal;
            this.btnadd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(40, 162);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(103, 41);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblfamount
            // 
            this.lblfamount.AutoSize = true;
            this.lblfamount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfamount.Location = new System.Drawing.Point(559, 93);
            this.lblfamount.Name = "lblfamount";
            this.lblfamount.Size = new System.Drawing.Size(135, 21);
            this.lblfamount.TabIndex = 8;
            this.lblfamount.Text = "Final Amount";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(285, 93);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(91, 21);
            this.lbldiscount.TabIndex = 9;
            this.lbldiscount.Text = "Discount";
            // 
            // lbltotal2
            // 
            this.lbltotal2.AutoSize = true;
            this.lbltotal2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal2.Location = new System.Drawing.Point(285, 36);
            this.lbltotal2.Name = "lbltotal2";
            this.lbltotal2.Size = new System.Drawing.Size(58, 21);
            this.lbltotal2.TabIndex = 10;
            this.lbltotal2.Text = "Total";
            // 
            // lblmquantity
            // 
            this.lblmquantity.AutoSize = true;
            this.lblmquantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmquantity.Location = new System.Drawing.Point(20, 97);
            this.lblmquantity.Name = "lblmquantity";
            this.lblmquantity.Size = new System.Drawing.Size(173, 21);
            this.lblmquantity.TabIndex = 12;
            this.lblmquantity.Text = "Material Quantity";
            // 
            // lblmprice
            // 
            this.lblmprice.AutoSize = true;
            this.lblmprice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmprice.Location = new System.Drawing.Point(447, 19);
            this.lblmprice.Name = "lblmprice";
            this.lblmprice.Size = new System.Drawing.Size(141, 21);
            this.lblmprice.TabIndex = 13;
            this.lblmprice.Text = "Material Price";
            // 
            // txtgrand
            // 
            this.txtgrand.Location = new System.Drawing.Point(715, 94);
            this.txtgrand.Name = "txtgrand";
            this.txtgrand.Size = new System.Drawing.Size(138, 22);
            this.txtgrand.TabIndex = 15;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(383, 94);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(140, 22);
            this.txtdiscount.TabIndex = 18;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(383, 35);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(140, 22);
            this.txtfinal.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbmname);
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.lbltotal1);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.lblmname);
            this.panel2.Controls.Add(this.txtpodid);
            this.panel2.Controls.Add(this.txtst2);
            this.panel2.Controls.Add(this.txtst1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.lblmprice);
            this.panel2.Controls.Add(this.lblmquantity);
            this.panel2.Location = new System.Drawing.Point(12, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 395);
            this.panel2.TabIndex = 20;
            // 
            // cmbmname
            // 
            this.cmbmname.DataSource = this.materialBindingSource1;
            this.cmbmname.DisplayMember = "mname";
            this.cmbmname.FormattingEnabled = true;
            this.cmbmname.Location = new System.Drawing.Point(200, 31);
            this.cmbmname.Name = "cmbmname";
            this.cmbmname.Size = new System.Drawing.Size(143, 24);
            this.cmbmname.TabIndex = 31;
            this.cmbmname.ValueMember = "mid";
            this.cmbmname.SelectionChangeCommitted += new System.EventHandler(this.cmbmname_SelectionChangeCommitted);
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.cSMSDBDataSet42;
            // 
            // cSMSDBDataSet42
            // 
            this.cSMSDBDataSet42.DataSetName = "CSMSDBDataSet42";
            this.cSMSDBDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(623, 80);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(163, 22);
            this.txttotal.TabIndex = 30;
            // 
            // lbltotal1
            // 
            this.lbltotal1.AutoSize = true;
            this.lbltotal1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal1.Location = new System.Drawing.Point(447, 79);
            this.lbltotal1.Name = "lbltotal1";
            this.lbltotal1.Size = new System.Drawing.Size(58, 21);
            this.lbltotal1.TabIndex = 29;
            this.lbltotal1.Text = "Total";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(623, 18);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(163, 22);
            this.txtprice.TabIndex = 26;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(199, 96);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(144, 22);
            this.txtqty.TabIndex = 25;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // lblmname
            // 
            this.lblmname.AutoSize = true;
            this.lblmname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmname.Location = new System.Drawing.Point(19, 30);
            this.lblmname.Name = "lblmname";
            this.lblmname.Size = new System.Drawing.Size(146, 21);
            this.lblmname.TabIndex = 24;
            this.lblmname.Text = "Material Name";
            // 
            // txtpodid
            // 
            this.txtpodid.Location = new System.Drawing.Point(190, 173);
            this.txtpodid.Name = "txtpodid";
            this.txtpodid.Size = new System.Drawing.Size(110, 22);
            this.txtpodid.TabIndex = 21;
            // 
            // txtst2
            // 
            this.txtst2.Location = new System.Drawing.Point(510, 173);
            this.txtst2.Name = "txtst2";
            this.txtst2.Size = new System.Drawing.Size(100, 22);
            this.txtst2.TabIndex = 22;
            // 
            // txtst1
            // 
            this.txtst1.Location = new System.Drawing.Point(353, 173);
            this.txtst1.Name = "txtst1";
            this.txtst1.Size = new System.Drawing.Size(100, 22);
            this.txtst1.TabIndex = 23;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.cSMSDBDataSet33;
            // 
            // cSMSDBDataSet33
            // 
            this.cSMSDBDataSet33.DataSetName = "CSMSDBDataSet33";
            this.cSMSDBDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtgst);
            this.panel3.Controls.Add(this.lblgst);
            this.panel3.Controls.Add(this.lblgst2);
            this.panel3.Controls.Add(this.lbltotal2);
            this.panel3.Controls.Add(this.txtfinal);
            this.panel3.Controls.Add(this.btncancle);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.btnnew);
            this.panel3.Controls.Add(this.lbldiscount);
            this.panel3.Controls.Add(this.txtdiscount);
            this.panel3.Controls.Add(this.lblfamount);
            this.panel3.Controls.Add(this.txtgrand);
            this.panel3.Location = new System.Drawing.Point(12, 575);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 161);
            this.panel3.TabIndex = 5;
            // 
            // txtgst
            // 
            this.txtgst.Location = new System.Drawing.Point(715, 37);
            this.txtgst.Name = "txtgst";
            this.txtgst.Size = new System.Drawing.Size(105, 22);
            this.txtgst.TabIndex = 20;
            // 
            // lblgst
            // 
            this.lblgst.AutoSize = true;
            this.lblgst.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgst.Location = new System.Drawing.Point(560, 35);
            this.lblgst.Name = "lblgst";
            this.lblgst.Size = new System.Drawing.Size(50, 21);
            this.lblgst.TabIndex = 14;
            this.lblgst.Text = "GST";
            // 
            // lblgst2
            // 
            this.lblgst2.AutoSize = true;
            this.lblgst2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgst2.Location = new System.Drawing.Point(826, 35);
            this.lblgst2.Name = "lblgst2";
            this.lblgst2.Size = new System.Drawing.Size(27, 21);
            this.lblgst2.TabIndex = 15;
            this.lblgst2.Text = "%";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter1
            // 
            this.materialTableAdapter1.ClearBeforeFill = true;
            // 
            // Purchase_Order_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 748);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Name = "Purchase_Order_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_Order_Details";
            this.Load += new System.EventHandler(this.Purchase_Order_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet33)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtpoid;
        private System.Windows.Forms.TextBox txtgrand;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblmprice;
        private System.Windows.Forms.Label lblmquantity;
        private System.Windows.Forms.Label lbltotal2;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblfamount;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblpoid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtgst;
        private System.Windows.Forms.Label lblgst;
        private System.Windows.Forms.Label lblgst2;
        private System.Windows.Forms.TextBox txtpodid;
        private System.Windows.Forms.TextBox txtst2;
        private System.Windows.Forms.TextBox txtst1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lbltotal1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cmbsname;
        private System.Windows.Forms.ComboBox cmbmname;
        private CSMSDBDataSet32 cSMSDBDataSet32;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private CSMSDBDataSet32TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private CSMSDBDataSet33 cSMSDBDataSet33;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private CSMSDBDataSet33TableAdapters.MaterialTableAdapter materialTableAdapter;
        private CSMSDBDataSet42 cSMSDBDataSet42;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private CSMSDBDataSet42TableAdapters.MaterialTableAdapter materialTableAdapter1;
    }
}