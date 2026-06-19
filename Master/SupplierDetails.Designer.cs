namespace CSMS.Master
{
    partial class SupplierDetails
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
            this.btncancle = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtsgstno = new System.Windows.Forms.TextBox();
            this.txtsifsccode = new System.Windows.Forms.TextBox();
            this.txtsaccno = new System.Windows.Forms.TextBox();
            this.txtsbankname = new System.Windows.Forms.TextBox();
            this.txtsemail = new System.Windows.Forms.TextBox();
            this.txtsmobno = new System.Windows.Forms.TextBox();
            this.txtscity = new System.Windows.Forms.TextBox();
            this.txtsaddress = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.lblsgst = new System.Windows.Forms.Label();
            this.lblsifsccode = new System.Windows.Forms.Label();
            this.lblsaccno = new System.Windows.Forms.Label();
            this.lblsbankname = new System.Windows.Forms.Label();
            this.lblsemail = new System.Windows.Forms.Label();
            this.lblsmobno = new System.Windows.Forms.Label();
            this.lblscity = new System.Windows.Forms.Label();
            this.lblsaddress = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet3 = new CSMS.CSMSDBDataSet3();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet2 = new CSMS.CSMSDBDataSet2();
            this.supplierTableAdapter = new CSMS.CSMSDBDataSet2TableAdapters.SupplierTableAdapter();
            this.supplierTableAdapter1 = new CSMS.CSMSDBDataSet3TableAdapters.SupplierTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-2, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(825, 40);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Supplier Details";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncancle);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.txtsgstno);
            this.panel1.Controls.Add(this.txtsifsccode);
            this.panel1.Controls.Add(this.txtsaccno);
            this.panel1.Controls.Add(this.txtsbankname);
            this.panel1.Controls.Add(this.txtsemail);
            this.panel1.Controls.Add(this.txtsmobno);
            this.panel1.Controls.Add(this.txtscity);
            this.panel1.Controls.Add(this.txtsaddress);
            this.panel1.Controls.Add(this.txtsname);
            this.panel1.Controls.Add(this.txtsid);
            this.panel1.Controls.Add(this.lblsgst);
            this.panel1.Controls.Add(this.lblsifsccode);
            this.panel1.Controls.Add(this.lblsaccno);
            this.panel1.Controls.Add(this.lblsbankname);
            this.panel1.Controls.Add(this.lblsemail);
            this.panel1.Controls.Add(this.lblsmobno);
            this.panel1.Controls.Add(this.lblscity);
            this.panel1.Controls.Add(this.lblsaddress);
            this.panel1.Controls.Add(this.lblsname);
            this.panel1.Controls.Add(this.lblsid);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 321);
            this.panel1.TabIndex = 1;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Teal;
            this.btncancle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(555, 280);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(100, 38);
            this.btncancle.TabIndex = 24;
            this.btncancle.Text = "Cancel";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Teal;
            this.btndelete.Enabled = false;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(434, 280);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 38);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(319, 280);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(101, 38);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(224, 280);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 38);
            this.btnsave.TabIndex = 21;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(116, 280);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(84, 38);
            this.btnnew.TabIndex = 20;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtsgstno
            // 
            this.txtsgstno.Location = new System.Drawing.Point(604, 221);
            this.txtsgstno.Name = "txtsgstno";
            this.txtsgstno.Size = new System.Drawing.Size(153, 22);
            this.txtsgstno.TabIndex = 19;
            // 
            // txtsifsccode
            // 
            this.txtsifsccode.Location = new System.Drawing.Point(604, 177);
            this.txtsifsccode.Name = "txtsifsccode";
            this.txtsifsccode.Size = new System.Drawing.Size(153, 22);
            this.txtsifsccode.TabIndex = 18;
            // 
            // txtsaccno
            // 
            this.txtsaccno.Location = new System.Drawing.Point(607, 132);
            this.txtsaccno.Name = "txtsaccno";
            this.txtsaccno.Size = new System.Drawing.Size(153, 22);
            this.txtsaccno.TabIndex = 17;
            this.txtsaccno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsaccno_KeyPress);
            // 
            // txtsbankname
            // 
            this.txtsbankname.Location = new System.Drawing.Point(604, 84);
            this.txtsbankname.Name = "txtsbankname";
            this.txtsbankname.Size = new System.Drawing.Size(153, 22);
            this.txtsbankname.TabIndex = 16;
            this.txtsbankname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsbankname_KeyPress);
            // 
            // txtsemail
            // 
            this.txtsemail.Location = new System.Drawing.Point(604, 32);
            this.txtsemail.Name = "txtsemail";
            this.txtsemail.Size = new System.Drawing.Size(153, 22);
            this.txtsemail.TabIndex = 15;
            // 
            // txtsmobno
            // 
            this.txtsmobno.Location = new System.Drawing.Point(206, 225);
            this.txtsmobno.Name = "txtsmobno";
            this.txtsmobno.Size = new System.Drawing.Size(186, 22);
            this.txtsmobno.TabIndex = 14;
            this.txtsmobno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsmobno_KeyPress);
            // 
            // txtscity
            // 
            this.txtscity.Location = new System.Drawing.Point(206, 177);
            this.txtscity.Name = "txtscity";
            this.txtscity.Size = new System.Drawing.Size(186, 22);
            this.txtscity.TabIndex = 13;
            // 
            // txtsaddress
            // 
            this.txtsaddress.Location = new System.Drawing.Point(206, 132);
            this.txtsaddress.Name = "txtsaddress";
            this.txtsaddress.Size = new System.Drawing.Size(186, 22);
            this.txtsaddress.TabIndex = 12;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(206, 86);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(186, 22);
            this.txtsname.TabIndex = 11;
            this.txtsname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsname_KeyPress);
            // 
            // txtsid
            // 
            this.txtsid.Enabled = false;
            this.txtsid.Location = new System.Drawing.Point(206, 37);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(186, 22);
            this.txtsid.TabIndex = 10;
            this.txtsid.TextChanged += new System.EventHandler(this.txtsid_TextChanged);
            // 
            // lblsgst
            // 
            this.lblsgst.AutoSize = true;
            this.lblsgst.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsgst.Location = new System.Drawing.Point(436, 224);
            this.lblsgst.Name = "lblsgst";
            this.lblsgst.Size = new System.Drawing.Size(88, 21);
            this.lblsgst.TabIndex = 9;
            this.lblsgst.Text = "GST No.";
            // 
            // lblsifsccode
            // 
            this.lblsifsccode.AutoSize = true;
            this.lblsifsccode.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifsccode.Location = new System.Drawing.Point(436, 180);
            this.lblsifsccode.Name = "lblsifsccode";
            this.lblsifsccode.Size = new System.Drawing.Size(108, 21);
            this.lblsifsccode.TabIndex = 8;
            this.lblsifsccode.Text = "IFSC Code";
            // 
            // lblsaccno
            // 
            this.lblsaccno.AutoSize = true;
            this.lblsaccno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaccno.Location = new System.Drawing.Point(436, 132);
            this.lblsaccno.Name = "lblsaccno";
            this.lblsaccno.Size = new System.Drawing.Size(163, 21);
            this.lblsaccno.TabIndex = 7;
            this.lblsaccno.Text = "Account Number";
            // 
            // lblsbankname
            // 
            this.lblsbankname.AutoSize = true;
            this.lblsbankname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsbankname.Location = new System.Drawing.Point(436, 89);
            this.lblsbankname.Name = "lblsbankname";
            this.lblsbankname.Size = new System.Drawing.Size(114, 21);
            this.lblsbankname.TabIndex = 6;
            this.lblsbankname.Text = "Bank Name";
            // 
            // lblsemail
            // 
            this.lblsemail.AutoSize = true;
            this.lblsemail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemail.Location = new System.Drawing.Point(436, 37);
            this.lblsemail.Name = "lblsemail";
            this.lblsemail.Size = new System.Drawing.Size(86, 21);
            this.lblsemail.TabIndex = 5;
            this.lblsemail.Text = "E - Mail";
            // 
            // lblsmobno
            // 
            this.lblsmobno.AutoSize = true;
            this.lblsmobno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmobno.Location = new System.Drawing.Point(47, 224);
            this.lblsmobno.Name = "lblsmobno";
            this.lblsmobno.Size = new System.Drawing.Size(153, 21);
            this.lblsmobno.TabIndex = 4;
            this.lblsmobno.Text = "Mobile Number";
            // 
            // lblscity
            // 
            this.lblscity.AutoSize = true;
            this.lblscity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscity.Location = new System.Drawing.Point(47, 180);
            this.lblscity.Name = "lblscity";
            this.lblscity.Size = new System.Drawing.Size(49, 21);
            this.lblscity.TabIndex = 3;
            this.lblscity.Text = "City";
            // 
            // lblsaddress
            // 
            this.lblsaddress.AutoSize = true;
            this.lblsaddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaddress.Location = new System.Drawing.Point(47, 132);
            this.lblsaddress.Name = "lblsaddress";
            this.lblsaddress.Size = new System.Drawing.Size(83, 21);
            this.lblsaddress.TabIndex = 2;
            this.lblsaddress.Text = "Address";
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.Location = new System.Drawing.Point(47, 89);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(62, 21);
            this.lblsname.TabIndex = 1;
            this.lblsname.Text = "Name";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.Location = new System.Drawing.Point(47, 37);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(116, 21);
            this.lblsid.TabIndex = 0;
            this.lblsid.Text = "Supplier ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 177);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.cSMSDBDataSet3;
            // 
            // cSMSDBDataSet3
            // 
            this.cSMSDBDataSet3.DataSetName = "CSMSDBDataSet3";
            this.cSMSDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.cSMSDBDataSet2;
            // 
            // cSMSDBDataSet2
            // 
            this.cSMSDBDataSet2.DataSetName = "CSMSDBDataSet2";
            this.cSMSDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter1
            // 
            this.supplierTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 82);
            this.groupBox1.TabIndex = 5;
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
            this.label3.Size = new System.Drawing.Size(200, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Supplier Name";
            // 
            // SupplierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Name = "SupplierDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierDetails";
            this.Load += new System.EventHandler(this.SupplierDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsgst;
        private System.Windows.Forms.Label lblsifsccode;
        private System.Windows.Forms.Label lblsaccno;
        private System.Windows.Forms.Label lblsbankname;
        private System.Windows.Forms.Label lblsemail;
        private System.Windows.Forms.Label lblsmobno;
        private System.Windows.Forms.Label lblscity;
        private System.Windows.Forms.Label lblsaddress;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.TextBox txtsgstno;
        private System.Windows.Forms.TextBox txtsifsccode;
        private System.Windows.Forms.TextBox txtsaccno;
        private System.Windows.Forms.TextBox txtsbankname;
        private System.Windows.Forms.TextBox txtsemail;
        private System.Windows.Forms.TextBox txtsmobno;
        private System.Windows.Forms.TextBox txtscity;
        private System.Windows.Forms.TextBox txtsaddress;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CSMSDBDataSet2 cSMSDBDataSet2;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private CSMSDBDataSet2TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private CSMSDBDataSet3 cSMSDBDataSet3;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private CSMSDBDataSet3TableAdapters.SupplierTableAdapter supplierTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}