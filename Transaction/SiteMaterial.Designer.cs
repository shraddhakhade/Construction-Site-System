namespace CSMS.Transaction
{
    partial class SiteMaterial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblmprice = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmname = new System.Windows.Forms.ComboBox();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet43 = new CSMS.CSMSDBDataSet43();
            this.cmbsiteid = new System.Windows.Forms.ComboBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet27 = new CSMS.CSMSDBDataSet27();
            this.txtsmid = new System.Windows.Forms.TextBox();
            this.txtmqty = new System.Windows.Forms.TextBox();
            this.lblmquantity = new System.Windows.Forms.Label();
            this.lblmid = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.lblsmid = new System.Windows.Forms.Label();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet28 = new CSMS.CSMSDBDataSet28();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siteMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet26 = new CSMS.CSMSDBDataSet26();
            this.lbltitle = new System.Windows.Forms.Label();
            this.siteMaterialTableAdapter = new CSMS.CSMSDBDataSet26TableAdapters.SiteMaterialTableAdapter();
            this.siteTableAdapter = new CSMS.CSMSDBDataSet27TableAdapters.SiteTableAdapter();
            this.materialTableAdapter = new CSMS.CSMSDBDataSet28TableAdapters.MaterialTableAdapter();
            this.materialTableAdapter1 = new CSMS.CSMSDBDataSet43TableAdapters.MaterialTableAdapter();
            this.lbltotal2 = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.sitematerialid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet26)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.lbltotal1);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.lblmprice);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbmname);
            this.panel1.Controls.Add(this.cmbsiteid);
            this.panel1.Controls.Add(this.txtsmid);
            this.panel1.Controls.Add(this.txtmqty);
            this.panel1.Controls.Add(this.lblmquantity);
            this.panel1.Controls.Add(this.lblmid);
            this.panel1.Controls.Add(this.lblsid);
            this.panel1.Controls.Add(this.lblsmid);
            this.panel1.Location = new System.Drawing.Point(36, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 326);
            this.panel1.TabIndex = 0;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(608, 210);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(163, 22);
            this.txttotal.TabIndex = 34;
            // 
            // lbltotal1
            // 
            this.lbltotal1.AutoSize = true;
            this.lbltotal1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal1.Location = new System.Drawing.Point(442, 197);
            this.lbltotal1.Name = "lbltotal1";
            this.lbltotal1.Size = new System.Drawing.Size(58, 21);
            this.lbltotal1.TabIndex = 33;
            this.lbltotal1.Text = "Total";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(608, 148);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(163, 22);
            this.txtprice.TabIndex = 32;
            // 
            // lblmprice
            // 
            this.lblmprice.AutoSize = true;
            this.lblmprice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmprice.Location = new System.Drawing.Point(432, 147);
            this.lblmprice.Name = "lblmprice";
            this.lblmprice.Size = new System.Drawing.Size(141, 21);
            this.lblmprice.TabIndex = 31;
            this.lblmprice.Text = "Material Price";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Teal;
            this.btnadd.Enabled = false;
            this.btnadd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(22, 263);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 37);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date";
            // 
            // cmbmname
            // 
            this.cmbmname.DataSource = this.materialBindingSource1;
            this.cmbmname.DisplayMember = "mname";
            this.cmbmname.FormattingEnabled = true;
            this.cmbmname.Location = new System.Drawing.Point(190, 144);
            this.cmbmname.Name = "cmbmname";
            this.cmbmname.Size = new System.Drawing.Size(163, 24);
            this.cmbmname.TabIndex = 12;
            this.cmbmname.ValueMember = "mid";
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.cSMSDBDataSet43;
            // 
            // cSMSDBDataSet43
            // 
            this.cSMSDBDataSet43.DataSetName = "CSMSDBDataSet43";
            this.cSMSDBDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbsiteid
            // 
            this.cmbsiteid.DataSource = this.siteBindingSource;
            this.cmbsiteid.DisplayMember = "sitename";
            this.cmbsiteid.FormattingEnabled = true;
            this.cmbsiteid.Location = new System.Drawing.Point(190, 66);
            this.cmbsiteid.Name = "cmbsiteid";
            this.cmbsiteid.Size = new System.Drawing.Size(163, 24);
            this.cmbsiteid.TabIndex = 11;
            this.cmbsiteid.ValueMember = "siteid";
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.cSMSDBDataSet27;
            // 
            // cSMSDBDataSet27
            // 
            this.cSMSDBDataSet27.DataSetName = "CSMSDBDataSet27";
            this.cSMSDBDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsmid
            // 
            this.txtsmid.Location = new System.Drawing.Point(190, 16);
            this.txtsmid.Name = "txtsmid";
            this.txtsmid.Size = new System.Drawing.Size(163, 22);
            this.txtsmid.TabIndex = 10;
            // 
            // txtmqty
            // 
            this.txtmqty.Location = new System.Drawing.Point(190, 196);
            this.txtmqty.Name = "txtmqty";
            this.txtmqty.Size = new System.Drawing.Size(163, 22);
            this.txtmqty.TabIndex = 9;
            this.txtmqty.TextChanged += new System.EventHandler(this.txtmqty_TextChanged);
            // 
            // lblmquantity
            // 
            this.lblmquantity.AutoSize = true;
            this.lblmquantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmquantity.Location = new System.Drawing.Point(18, 196);
            this.lblmquantity.Name = "lblmquantity";
            this.lblmquantity.Size = new System.Drawing.Size(173, 21);
            this.lblmquantity.TabIndex = 8;
            this.lblmquantity.Text = "Material Quantity";
            // 
            // lblmid
            // 
            this.lblmid.AutoSize = true;
            this.lblmid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmid.Location = new System.Drawing.Point(18, 144);
            this.lblmid.Name = "lblmid";
            this.lblmid.Size = new System.Drawing.Size(146, 21);
            this.lblmid.TabIndex = 7;
            this.lblmid.Text = "Material Name";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.Location = new System.Drawing.Point(18, 65);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(75, 21);
            this.lblsid.TabIndex = 6;
            this.lblsid.Text = "Site ID";
            // 
            // lblsmid
            // 
            this.lblsmid.AutoSize = true;
            this.lblsmid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmid.Location = new System.Drawing.Point(18, 17);
            this.lblsmid.Name = "lblsmid";
            this.lblsmid.Size = new System.Drawing.Size(159, 21);
            this.lblsmid.TabIndex = 5;
            this.lblsmid.Text = "Site Material ID";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.cSMSDBDataSet28;
            // 
            // cSMSDBDataSet28
            // 
            this.cSMSDBDataSet28.DataSetName = "CSMSDBDataSet28";
            this.cSMSDBDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Teal;
            this.btncancle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(88, 661);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(102, 37);
            this.btncancle.TabIndex = 4;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(187, 596);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 37);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(27, 596);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(102, 37);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sitematerialid,
            this.siteid,
            this.materialname,
            this.materialqty,
            this.materialprice,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(33, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 159);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siteMaterialBindingSource
            // 
            this.siteMaterialBindingSource.DataMember = "SiteMaterial";
            this.siteMaterialBindingSource.DataSource = this.cSMSDBDataSet26;
            // 
            // cSMSDBDataSet26
            // 
            this.cSMSDBDataSet26.DataSetName = "CSMSDBDataSet26";
            this.cSMSDBDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-2, 22);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(899, 42);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Site Material";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siteMaterialTableAdapter
            // 
            this.siteMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter1
            // 
            this.materialTableAdapter1.ClearBeforeFill = true;
            // 
            // lbltotal2
            // 
            this.lbltotal2.AutoSize = true;
            this.lbltotal2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal2.Location = new System.Drawing.Point(328, 602);
            this.lbltotal2.Name = "lbltotal2";
            this.lbltotal2.Size = new System.Drawing.Size(58, 21);
            this.lbltotal2.TabIndex = 20;
            this.lbltotal2.Text = "Total";
            // 
            // txtfinal
            // 
            this.txtfinal.Enabled = false;
            this.txtfinal.Location = new System.Drawing.Point(426, 601);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(140, 22);
            this.txtfinal.TabIndex = 21;
            // 
            // sitematerialid
            // 
            this.sitematerialid.HeaderText = "sitematerialid";
            this.sitematerialid.Name = "sitematerialid";
            // 
            // siteid
            // 
            this.siteid.HeaderText = "siteid";
            this.siteid.Name = "siteid";
            // 
            // materialname
            // 
            this.materialname.DataPropertyName = "sitematerialid";
            this.materialname.HeaderText = "materialname";
            this.materialname.Name = "materialname";
            // 
            // materialqty
            // 
            this.materialqty.HeaderText = "materialqty";
            this.materialqty.Name = "materialqty";
            // 
            // materialprice
            // 
            this.materialprice.DataPropertyName = "sitematerialid";
            this.materialprice.HeaderText = "materialprice";
            this.materialprice.Name = "materialprice";
            // 
            // total
            // 
            this.total.DataPropertyName = "sitematerialid";
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // SiteMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 719);
            this.Controls.Add(this.lbltotal2);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnnew);
            this.Name = "SiteMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiteMaterial";
            this.Load += new System.EventHandler(this.SiteMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet26)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltitle;
        private CSMSDBDataSet26 cSMSDBDataSet26;
        private System.Windows.Forms.BindingSource siteMaterialBindingSource;
        private CSMSDBDataSet26TableAdapters.SiteMaterialTableAdapter siteMaterialTableAdapter;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ComboBox cmbmname;
        private System.Windows.Forms.ComboBox cmbsiteid;
        private System.Windows.Forms.TextBox txtsmid;
        private System.Windows.Forms.TextBox txtmqty;
        private System.Windows.Forms.Label lblmquantity;
        private System.Windows.Forms.Label lblmid;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label lblsmid;
        private CSMSDBDataSet27 cSMSDBDataSet27;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private CSMSDBDataSet27TableAdapters.SiteTableAdapter siteTableAdapter;
        private CSMSDBDataSet28 cSMSDBDataSet28;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private CSMSDBDataSet28TableAdapters.MaterialTableAdapter materialTableAdapter;
        private CSMSDBDataSet43 cSMSDBDataSet43;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private CSMSDBDataSet43TableAdapters.MaterialTableAdapter materialTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblmprice;
        private System.Windows.Forms.Label lbltotal2;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitematerialid;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteid;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}