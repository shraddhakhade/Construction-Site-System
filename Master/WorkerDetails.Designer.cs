namespace CSMS.Master
{
    partial class WorkerDetails
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
            this.lblwid = new System.Windows.Forms.Label();
            this.lblwname = new System.Windows.Forms.Label();
            this.lblwaddress = new System.Windows.Forms.Label();
            this.lblwmobno = new System.Windows.Forms.Label();
            this.lbldesignation = new System.Windows.Forms.Label();
            this.txtwid = new System.Windows.Forms.TextBox();
            this.txtwname = new System.Windows.Forms.TextBox();
            this.txtwaddress = new System.Windows.Forms.TextBox();
            this.txtwmobno = new System.Windows.Forms.TextBox();
            this.txtwdesignation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancle = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workermobnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerdesignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet4 = new CSMS.CSMSDBDataSet4();
            this.workerTableAdapter = new CSMS.CSMSDBDataSet4TableAdapters.WorkerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-2, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(829, 40);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Worker Details";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwid
            // 
            this.lblwid.AutoSize = true;
            this.lblwid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwid.Location = new System.Drawing.Point(27, 32);
            this.lblwid.Name = "lblwid";
            this.lblwid.Size = new System.Drawing.Size(107, 21);
            this.lblwid.TabIndex = 1;
            this.lblwid.Text = "Worker ID";
            // 
            // lblwname
            // 
            this.lblwname.AutoSize = true;
            this.lblwname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwname.Location = new System.Drawing.Point(27, 92);
            this.lblwname.Name = "lblwname";
            this.lblwname.Size = new System.Drawing.Size(62, 21);
            this.lblwname.TabIndex = 2;
            this.lblwname.Text = "Name";
            // 
            // lblwaddress
            // 
            this.lblwaddress.AutoSize = true;
            this.lblwaddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaddress.Location = new System.Drawing.Point(27, 163);
            this.lblwaddress.Name = "lblwaddress";
            this.lblwaddress.Size = new System.Drawing.Size(83, 21);
            this.lblwaddress.TabIndex = 3;
            this.lblwaddress.Text = "Address";
            // 
            // lblwmobno
            // 
            this.lblwmobno.AutoSize = true;
            this.lblwmobno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwmobno.Location = new System.Drawing.Point(369, 36);
            this.lblwmobno.Name = "lblwmobno";
            this.lblwmobno.Size = new System.Drawing.Size(153, 21);
            this.lblwmobno.TabIndex = 4;
            this.lblwmobno.Text = "Mobile Number";
            // 
            // lbldesignation
            // 
            this.lbldesignation.AutoSize = true;
            this.lbldesignation.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesignation.Location = new System.Drawing.Point(369, 107);
            this.lbldesignation.Name = "lbldesignation";
            this.lbldesignation.Size = new System.Drawing.Size(119, 21);
            this.lbldesignation.TabIndex = 5;
            this.lbldesignation.Text = "Designation";
            // 
            // txtwid
            // 
            this.txtwid.Location = new System.Drawing.Point(140, 31);
            this.txtwid.Name = "txtwid";
            this.txtwid.Size = new System.Drawing.Size(164, 22);
            this.txtwid.TabIndex = 6;
            // 
            // txtwname
            // 
            this.txtwname.Location = new System.Drawing.Point(140, 91);
            this.txtwname.Name = "txtwname";
            this.txtwname.Size = new System.Drawing.Size(164, 22);
            this.txtwname.TabIndex = 7;
            this.txtwname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtwname_KeyPress);
            // 
            // txtwaddress
            // 
            this.txtwaddress.Location = new System.Drawing.Point(140, 162);
            this.txtwaddress.Name = "txtwaddress";
            this.txtwaddress.Size = new System.Drawing.Size(164, 22);
            this.txtwaddress.TabIndex = 8;
            // 
            // txtwmobno
            // 
            this.txtwmobno.Location = new System.Drawing.Point(538, 37);
            this.txtwmobno.Name = "txtwmobno";
            this.txtwmobno.Size = new System.Drawing.Size(167, 22);
            this.txtwmobno.TabIndex = 9;
            this.txtwmobno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtwmobno_KeyPress);
            // 
            // txtwdesignation
            // 
            this.txtwdesignation.Location = new System.Drawing.Point(538, 106);
            this.txtwdesignation.Name = "txtwdesignation";
            this.txtwdesignation.Size = new System.Drawing.Size(167, 22);
            this.txtwdesignation.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncancle);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.lblwid);
            this.panel1.Controls.Add(this.txtwdesignation);
            this.panel1.Controls.Add(this.txtwid);
            this.panel1.Controls.Add(this.txtwmobno);
            this.panel1.Controls.Add(this.lblwname);
            this.panel1.Controls.Add(this.lbldesignation);
            this.panel1.Controls.Add(this.txtwaddress);
            this.panel1.Controls.Add(this.lblwmobno);
            this.panel1.Controls.Add(this.txtwname);
            this.panel1.Controls.Add(this.lblwaddress);
            this.panel1.Location = new System.Drawing.Point(44, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 280);
            this.panel1.TabIndex = 11;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Teal;
            this.btncancle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(538, 221);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(92, 37);
            this.btncancle.TabIndex = 12;
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
            this.btndelete.Location = new System.Drawing.Point(414, 221);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 37);
            this.btndelete.TabIndex = 14;
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
            this.btnupdate.Location = new System.Drawing.Point(296, 221);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 37);
            this.btnupdate.TabIndex = 13;
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
            this.btnsave.Location = new System.Drawing.Point(184, 221);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 37);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(59, 221);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 37);
            this.btnnew.TabIndex = 11;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workeridDataGridViewTextBoxColumn,
            this.workernameDataGridViewTextBoxColumn,
            this.workeraddressDataGridViewTextBoxColumn,
            this.workermobnoDataGridViewTextBoxColumn,
            this.workerdesignationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 198);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // workeridDataGridViewTextBoxColumn
            // 
            this.workeridDataGridViewTextBoxColumn.DataPropertyName = "workerid";
            this.workeridDataGridViewTextBoxColumn.HeaderText = "workerid";
            this.workeridDataGridViewTextBoxColumn.Name = "workeridDataGridViewTextBoxColumn";
            // 
            // workernameDataGridViewTextBoxColumn
            // 
            this.workernameDataGridViewTextBoxColumn.DataPropertyName = "workername";
            this.workernameDataGridViewTextBoxColumn.HeaderText = "workername";
            this.workernameDataGridViewTextBoxColumn.Name = "workernameDataGridViewTextBoxColumn";
            // 
            // workeraddressDataGridViewTextBoxColumn
            // 
            this.workeraddressDataGridViewTextBoxColumn.DataPropertyName = "workeraddress";
            this.workeraddressDataGridViewTextBoxColumn.HeaderText = "workeraddress";
            this.workeraddressDataGridViewTextBoxColumn.Name = "workeraddressDataGridViewTextBoxColumn";
            // 
            // workermobnoDataGridViewTextBoxColumn
            // 
            this.workermobnoDataGridViewTextBoxColumn.DataPropertyName = "workermobno";
            this.workermobnoDataGridViewTextBoxColumn.HeaderText = "workermobno";
            this.workermobnoDataGridViewTextBoxColumn.Name = "workermobnoDataGridViewTextBoxColumn";
            // 
            // workerdesignationDataGridViewTextBoxColumn
            // 
            this.workerdesignationDataGridViewTextBoxColumn.DataPropertyName = "workerdesignation";
            this.workerdesignationDataGridViewTextBoxColumn.HeaderText = "workerdesignation";
            this.workerdesignationDataGridViewTextBoxColumn.Name = "workerdesignationDataGridViewTextBoxColumn";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.cSMSDBDataSet4;
            // 
            // cSMSDBDataSet4
            // 
            this.cSMSDBDataSet4.DataSetName = "CSMSDBDataSet4";
            this.cSMSDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 82);
            this.groupBox1.TabIndex = 13;
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
            this.label3.Size = new System.Drawing.Size(191, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Worker Name";
            // 
            // WorkerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Name = "WorkerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerDetails";
            this.Load += new System.EventHandler(this.WorkerDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblwid;
        private System.Windows.Forms.Label lblwname;
        private System.Windows.Forms.Label lblwaddress;
        private System.Windows.Forms.Label lblwmobno;
        private System.Windows.Forms.Label lbldesignation;
        private System.Windows.Forms.TextBox txtwid;
        private System.Windows.Forms.TextBox txtwname;
        private System.Windows.Forms.TextBox txtwaddress;
        private System.Windows.Forms.TextBox txtwmobno;
        private System.Windows.Forms.TextBox txtwdesignation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CSMSDBDataSet4 cSMSDBDataSet4;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private CSMSDBDataSet4TableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workermobnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerdesignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}