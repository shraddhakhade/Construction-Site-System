namespace CSMS.Master
{
    partial class Enquiry
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
            this.txteid = new System.Windows.Forms.TextBox();
            this.lbleid = new System.Windows.Forms.Label();
            this.lblesubject = new System.Windows.Forms.Label();
            this.txtemessage = new System.Windows.Forms.TextBox();
            this.txtesubject = new System.Windows.Forms.TextBox();
            this.txteemail = new System.Windows.Forms.TextBox();
            this.txtemobno = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.lblemessage = new System.Windows.Forms.Label();
            this.lbleemail = new System.Windows.Forms.Label();
            this.lblemobno = new System.Windows.Forms.Label();
            this.lblename = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enquiryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enquiryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet29 = new CSMS.CSMSDBDataSet29();
            this.enquiryTableAdapter = new CSMS.CSMSDBDataSet29TableAdapters.EnquiryTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet29)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-3, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(908, 46);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Enquiry Details";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txteid);
            this.panel1.Controls.Add(this.lbleid);
            this.panel1.Controls.Add(this.lblesubject);
            this.panel1.Controls.Add(this.txtemessage);
            this.panel1.Controls.Add(this.txtesubject);
            this.panel1.Controls.Add(this.txteemail);
            this.panel1.Controls.Add(this.txtemobno);
            this.panel1.Controls.Add(this.txtename);
            this.panel1.Controls.Add(this.lblemessage);
            this.panel1.Controls.Add(this.lbleemail);
            this.panel1.Controls.Add(this.lblemobno);
            this.panel1.Controls.Add(this.lblename);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Location = new System.Drawing.Point(40, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 268);
            this.panel1.TabIndex = 1;
            // 
            // txteid
            // 
            this.txteid.Enabled = false;
            this.txteid.Location = new System.Drawing.Point(203, 36);
            this.txteid.Name = "txteid";
            this.txteid.Size = new System.Drawing.Size(148, 22);
            this.txteid.TabIndex = 17;
            // 
            // lbleid
            // 
            this.lbleid.AutoSize = true;
            this.lbleid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleid.Location = new System.Drawing.Point(73, 40);
            this.lbleid.Name = "lbleid";
            this.lbleid.Size = new System.Drawing.Size(111, 21);
            this.lbleid.TabIndex = 16;
            this.lbleid.Text = "Enquiry ID";
            // 
            // lblesubject
            // 
            this.lblesubject.AutoSize = true;
            this.lblesubject.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblesubject.Location = new System.Drawing.Point(437, 87);
            this.lblesubject.Name = "lblesubject";
            this.lblesubject.Size = new System.Drawing.Size(78, 21);
            this.lblesubject.TabIndex = 15;
            this.lblesubject.Text = "Subject";
            // 
            // txtemessage
            // 
            this.txtemessage.Location = new System.Drawing.Point(560, 136);
            this.txtemessage.Multiline = true;
            this.txtemessage.Name = "txtemessage";
            this.txtemessage.Size = new System.Drawing.Size(148, 22);
            this.txtemessage.TabIndex = 14;
            // 
            // txtesubject
            // 
            this.txtesubject.Location = new System.Drawing.Point(560, 86);
            this.txtesubject.Name = "txtesubject";
            this.txtesubject.Size = new System.Drawing.Size(148, 22);
            this.txtesubject.TabIndex = 13;
            // 
            // txteemail
            // 
            this.txteemail.Location = new System.Drawing.Point(561, 32);
            this.txteemail.Name = "txteemail";
            this.txteemail.Size = new System.Drawing.Size(148, 22);
            this.txteemail.TabIndex = 12;
            // 
            // txtemobno
            // 
            this.txtemobno.Location = new System.Drawing.Point(203, 137);
            this.txtemobno.Name = "txtemobno";
            this.txtemobno.Size = new System.Drawing.Size(148, 22);
            this.txtemobno.TabIndex = 11;
            this.txtemobno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemobno_KeyPress);
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(203, 88);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(148, 22);
            this.txtename.TabIndex = 10;
            this.txtename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtename_KeyPress);
            // 
            // lblemessage
            // 
            this.lblemessage.AutoSize = true;
            this.lblemessage.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemessage.Location = new System.Drawing.Point(436, 137);
            this.lblemessage.Name = "lblemessage";
            this.lblemessage.Size = new System.Drawing.Size(88, 21);
            this.lblemessage.TabIndex = 9;
            this.lblemessage.Text = "Message";
            // 
            // lbleemail
            // 
            this.lbleemail.AutoSize = true;
            this.lbleemail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleemail.Location = new System.Drawing.Point(440, 37);
            this.lbleemail.Name = "lbleemail";
            this.lbleemail.Size = new System.Drawing.Size(86, 21);
            this.lbleemail.TabIndex = 7;
            this.lbleemail.Text = "E - Mail";
            // 
            // lblemobno
            // 
            this.lblemobno.AutoSize = true;
            this.lblemobno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemobno.Location = new System.Drawing.Point(69, 142);
            this.lblemobno.Name = "lblemobno";
            this.lblemobno.Size = new System.Drawing.Size(113, 21);
            this.lblemobno.TabIndex = 6;
            this.lblemobno.Text = "Mobile No.";
            // 
            // lblename
            // 
            this.lblename.AutoSize = true;
            this.lblename.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblename.Location = new System.Drawing.Point(69, 91);
            this.lblename.Name = "lblename";
            this.lblename.Size = new System.Drawing.Size(62, 21);
            this.lblename.TabIndex = 5;
            this.lblename.Text = "Name";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Teal;
            this.btnclear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(646, 217);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(108, 38);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Teal;
            this.btndelete.Enabled = false;
            this.btndelete.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(491, 217);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(108, 38);
            this.btndelete.TabIndex = 3;
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
            this.btnupdate.Location = new System.Drawing.Point(346, 217);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(108, 38);
            this.btnupdate.TabIndex = 2;
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
            this.btnsave.Location = new System.Drawing.Point(212, 217);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(108, 38);
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
            this.btnnew.Location = new System.Drawing.Point(72, 217);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(108, 38);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enquiryidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobilenoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.subjectsDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enquiryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(818, 211);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enquiryidDataGridViewTextBoxColumn
            // 
            this.enquiryidDataGridViewTextBoxColumn.DataPropertyName = "enquiryid";
            this.enquiryidDataGridViewTextBoxColumn.HeaderText = "enquiryid";
            this.enquiryidDataGridViewTextBoxColumn.Name = "enquiryidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            this.mobilenoDataGridViewTextBoxColumn.DataPropertyName = "mobileno";
            this.mobilenoDataGridViewTextBoxColumn.HeaderText = "mobileno";
            this.mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // subjectsDataGridViewTextBoxColumn
            // 
            this.subjectsDataGridViewTextBoxColumn.DataPropertyName = "subjects";
            this.subjectsDataGridViewTextBoxColumn.HeaderText = "subjects";
            this.subjectsDataGridViewTextBoxColumn.Name = "subjectsDataGridViewTextBoxColumn";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // enquiryBindingSource
            // 
            this.enquiryBindingSource.DataMember = "Enquiry";
            this.enquiryBindingSource.DataSource = this.cSMSDBDataSet29;
            // 
            // cSMSDBDataSet29
            // 
            this.cSMSDBDataSet29.DataSetName = "CSMSDBDataSet29";
            this.cSMSDBDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enquiryTableAdapter
            // 
            this.enquiryTableAdapter.ClearBeforeFill = true;
            // 
            // Enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Name = "Enquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enquiry";
            this.Load += new System.EventHandler(this.Enquiry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet29)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtemessage;
        private System.Windows.Forms.TextBox txtesubject;
        private System.Windows.Forms.TextBox txteemail;
        private System.Windows.Forms.TextBox txtemobno;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.Label lblemessage;
        private System.Windows.Forms.Label lbleemail;
        private System.Windows.Forms.Label lblemobno;
        private System.Windows.Forms.Label lblename;
        private System.Windows.Forms.Label lblesubject;
        private CSMSDBDataSet29 cSMSDBDataSet29;
        private System.Windows.Forms.BindingSource enquiryBindingSource;
        private CSMSDBDataSet29TableAdapters.EnquiryTableAdapter enquiryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enquiryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.Label lbleid;
    }
}