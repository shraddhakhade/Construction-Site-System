namespace CSMS.Master
{
    partial class MaterialDetails
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
            this.txtmunit = new System.Windows.Forms.ComboBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtmstock = new System.Windows.Forms.TextBox();
            this.txtmprice = new System.Windows.Forms.TextBox();
            this.txtmid = new System.Windows.Forms.TextBox();
            this.lblmstock = new System.Windows.Forms.Label();
            this.lblmprice = new System.Windows.Forms.Label();
            this.lblmunit = new System.Windows.Forms.Label();
            this.lblmname = new System.Windows.Forms.Label();
            this.lblmid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet37 = new CSMS.CSMSDBDataSet37();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTableAdapter = new CSMS.CSMSDBDataSet37TableAdapters.MaterialTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet37)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(1, 34);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(827, 32);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Material Details";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtmunit);
            this.panel1.Controls.Add(this.txtmname);
            this.panel1.Controls.Add(this.btncancle);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.txtmstock);
            this.panel1.Controls.Add(this.txtmprice);
            this.panel1.Controls.Add(this.txtmid);
            this.panel1.Controls.Add(this.lblmstock);
            this.panel1.Controls.Add(this.lblmprice);
            this.panel1.Controls.Add(this.lblmunit);
            this.panel1.Controls.Add(this.lblmname);
            this.panel1.Controls.Add(this.lblmid);
            this.panel1.Location = new System.Drawing.Point(22, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 249);
            this.panel1.TabIndex = 1;
            // 
            // txtmunit
            // 
            this.txtmunit.FormattingEnabled = true;
            this.txtmunit.Items.AddRange(new object[] {
            "Kg",
            "Brass",
            "Pieces",
            "Ton"});
            this.txtmunit.Location = new System.Drawing.Point(190, 140);
            this.txtmunit.Name = "txtmunit";
            this.txtmunit.Size = new System.Drawing.Size(162, 24);
            this.txtmunit.TabIndex = 18;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(190, 85);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(162, 22);
            this.txtmname.TabIndex = 17;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Teal;
            this.btncancle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(571, 195);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(96, 36);
            this.btncancle.TabIndex = 16;
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
            this.btndelete.Location = new System.Drawing.Point(466, 195);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 36);
            this.btndelete.TabIndex = 15;
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
            this.btnupdate.Location = new System.Drawing.Point(349, 195);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(107, 36);
            this.btnupdate.TabIndex = 14;
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
            this.btnsave.Location = new System.Drawing.Point(230, 195);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(105, 36);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Enabled = false;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(109, 195);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(100, 36);
            this.btnnew.TabIndex = 12;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtmstock
            // 
            this.txtmstock.Location = new System.Drawing.Point(560, 84);
            this.txtmstock.Name = "txtmstock";
            this.txtmstock.Size = new System.Drawing.Size(162, 22);
            this.txtmstock.TabIndex = 10;
            this.txtmstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmstock_KeyPress);
            // 
            // txtmprice
            // 
            this.txtmprice.Location = new System.Drawing.Point(560, 27);
            this.txtmprice.Name = "txtmprice";
            this.txtmprice.Size = new System.Drawing.Size(162, 22);
            this.txtmprice.TabIndex = 9;
            this.txtmprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmprice_KeyPress);
            // 
            // txtmid
            // 
            this.txtmid.Enabled = false;
            this.txtmid.Location = new System.Drawing.Point(190, 28);
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(162, 22);
            this.txtmid.TabIndex = 6;
            // 
            // lblmstock
            // 
            this.lblmstock.AutoSize = true;
            this.lblmstock.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmstock.Location = new System.Drawing.Point(448, 84);
            this.lblmstock.Name = "lblmstock";
            this.lblmstock.Size = new System.Drawing.Size(61, 21);
            this.lblmstock.TabIndex = 4;
            this.lblmstock.Text = "Stock";
            // 
            // lblmprice
            // 
            this.lblmprice.AutoSize = true;
            this.lblmprice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmprice.Location = new System.Drawing.Point(448, 28);
            this.lblmprice.Name = "lblmprice";
            this.lblmprice.Size = new System.Drawing.Size(57, 21);
            this.lblmprice.TabIndex = 3;
            this.lblmprice.Text = "Price";
            // 
            // lblmunit
            // 
            this.lblmunit.AutoSize = true;
            this.lblmunit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmunit.Location = new System.Drawing.Point(69, 143);
            this.lblmunit.Name = "lblmunit";
            this.lblmunit.Size = new System.Drawing.Size(50, 21);
            this.lblmunit.TabIndex = 2;
            this.lblmunit.Text = "Unit";
            // 
            // lblmname
            // 
            this.lblmname.AutoSize = true;
            this.lblmname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmname.Location = new System.Drawing.Point(69, 84);
            this.lblmname.Name = "lblmname";
            this.lblmname.Size = new System.Drawing.Size(62, 21);
            this.lblmname.TabIndex = 1;
            this.lblmname.Text = "Name";
            // 
            // lblmid
            // 
            this.lblmid.AutoSize = true;
            this.lblmid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmid.Location = new System.Drawing.Point(69, 28);
            this.lblmid.Name = "lblmid";
            this.lblmid.Size = new System.Drawing.Size(117, 21);
            this.lblmid.TabIndex = 0;
            this.lblmid.Text = "Material ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.munitDataGridViewTextBoxColumn,
            this.mpriceDataGridViewTextBoxColumn,
            this.mstockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 196);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "mid";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "mname";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "mname";
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            // 
            // munitDataGridViewTextBoxColumn
            // 
            this.munitDataGridViewTextBoxColumn.DataPropertyName = "munit";
            this.munitDataGridViewTextBoxColumn.HeaderText = "munit";
            this.munitDataGridViewTextBoxColumn.Name = "munitDataGridViewTextBoxColumn";
            // 
            // mpriceDataGridViewTextBoxColumn
            // 
            this.mpriceDataGridViewTextBoxColumn.DataPropertyName = "mprice";
            this.mpriceDataGridViewTextBoxColumn.HeaderText = "mprice";
            this.mpriceDataGridViewTextBoxColumn.Name = "mpriceDataGridViewTextBoxColumn";
            // 
            // mstockDataGridViewTextBoxColumn
            // 
            this.mstockDataGridViewTextBoxColumn.DataPropertyName = "mstock";
            this.mstockDataGridViewTextBoxColumn.HeaderText = "mstock";
            this.mstockDataGridViewTextBoxColumn.Name = "mstockDataGridViewTextBoxColumn";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.cSMSDBDataSet37;
            // 
            // cSMSDBDataSet37
            // 
            this.cSMSDBDataSet37.DataSetName = "CSMSDBDataSet37";
            this.cSMSDBDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 82);
            this.groupBox1.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Material Name";
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // MaterialDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Name = "MaterialDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialDetails";
            this.Load += new System.EventHandler(this.MaterialDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet37)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmstock;
        private System.Windows.Forms.TextBox txtmprice;
        private System.Windows.Forms.TextBox txtmid;
        private System.Windows.Forms.Label lblmstock;
        private System.Windows.Forms.Label lblmprice;
        private System.Windows.Forms.Label lblmunit;
        private System.Windows.Forms.Label lblmname;
        private System.Windows.Forms.Label lblmid;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.ComboBox txtmunit;
        private CSMSDBDataSet37 cSMSDBDataSet37;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private CSMSDBDataSet37TableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mstockDataGridViewTextBoxColumn;
    }
}