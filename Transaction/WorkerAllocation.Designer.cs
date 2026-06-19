namespace CSMS.Transaction
{
    partial class WorkerAllocation
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
            this.walloid = new System.Windows.Forms.Label();
            this.lblwid = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.txtwalloid = new System.Windows.Forms.TextBox();
            this.combowid = new System.Windows.Forms.ComboBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet10 = new CSMS.CSMSDBDataSet10();
            this.combosid = new System.Windows.Forms.ComboBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet11 = new CSMS.CSMSDBDataSet11();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wallocationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerAllocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSMSDBDataSet8 = new CSMS.CSMSDBDataSet8();
            this.workerAllocationTableAdapter = new CSMS.CSMSDBDataSet8TableAdapters.WorkerAllocationTableAdapter();
            this.cSMSDBDataSet9 = new CSMS.CSMSDBDataSet9();
            this.workerAllocationTableAdapter1 = new CSMS.CSMSDBDataSet9TableAdapters.WorkerAllocationTableAdapter();
            this.workerTableAdapter = new CSMS.CSMSDBDataSet10TableAdapters.WorkerTableAdapter();
            this.siteTableAdapter = new CSMS.CSMSDBDataSet11TableAdapters.SiteTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerAllocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet9)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-1, 23);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(859, 46);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Worker Allocation";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // walloid
            // 
            this.walloid.AutoSize = true;
            this.walloid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walloid.Location = new System.Drawing.Point(170, 26);
            this.walloid.Name = "walloid";
            this.walloid.Size = new System.Drawing.Size(209, 21);
            this.walloid.TabIndex = 1;
            this.walloid.Text = "Worker Allocation ID";
            // 
            // lblwid
            // 
            this.lblwid.AutoSize = true;
            this.lblwid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwid.Location = new System.Drawing.Point(170, 84);
            this.lblwid.Name = "lblwid";
            this.lblwid.Size = new System.Drawing.Size(107, 21);
            this.lblwid.TabIndex = 2;
            this.lblwid.Text = "Worker ID";
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.Location = new System.Drawing.Point(170, 143);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(75, 21);
            this.lblsid.TabIndex = 3;
            this.lblsid.Text = "Site ID";
            // 
            // txtwalloid
            // 
            this.txtwalloid.Location = new System.Drawing.Point(391, 27);
            this.txtwalloid.Name = "txtwalloid";
            this.txtwalloid.Size = new System.Drawing.Size(187, 22);
            this.txtwalloid.TabIndex = 4;
            // 
            // combowid
            // 
            this.combowid.DataSource = this.workerBindingSource;
            this.combowid.DisplayMember = "workername";
            this.combowid.FormattingEnabled = true;
            this.combowid.Location = new System.Drawing.Point(391, 81);
            this.combowid.Name = "combowid";
            this.combowid.Size = new System.Drawing.Size(187, 24);
            this.combowid.TabIndex = 5;
            this.combowid.ValueMember = "workerid";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.cSMSDBDataSet10;
            // 
            // cSMSDBDataSet10
            // 
            this.cSMSDBDataSet10.DataSetName = "CSMSDBDataSet10";
            this.cSMSDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combosid
            // 
            this.combosid.DataSource = this.siteBindingSource;
            this.combosid.DisplayMember = "sitename";
            this.combosid.FormattingEnabled = true;
            this.combosid.Location = new System.Drawing.Point(391, 140);
            this.combosid.Name = "combosid";
            this.combosid.Size = new System.Drawing.Size(187, 24);
            this.combosid.TabIndex = 6;
            this.combosid.ValueMember = "siteid";
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.cSMSDBDataSet11;
            // 
            // cSMSDBDataSet11
            // 
            this.cSMSDBDataSet11.DataSetName = "CSMSDBDataSet11";
            this.cSMSDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Teal;
            this.btnnew.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(42, 215);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(94, 40);
            this.btnnew.TabIndex = 7;
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
            this.btnsave.Location = new System.Drawing.Point(195, 215);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 40);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Teal;
            this.btnclear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(609, 215);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 40);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Cancel";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wallocationidDataGridViewTextBoxColumn,
            this.workeridDataGridViewTextBoxColumn,
            this.siteidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerAllocationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 179);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wallocationidDataGridViewTextBoxColumn
            // 
            this.wallocationidDataGridViewTextBoxColumn.DataPropertyName = "wallocationid";
            this.wallocationidDataGridViewTextBoxColumn.HeaderText = "wallocationid";
            this.wallocationidDataGridViewTextBoxColumn.Name = "wallocationidDataGridViewTextBoxColumn";
            // 
            // workeridDataGridViewTextBoxColumn
            // 
            this.workeridDataGridViewTextBoxColumn.DataPropertyName = "workerid";
            this.workeridDataGridViewTextBoxColumn.HeaderText = "workerid";
            this.workeridDataGridViewTextBoxColumn.Name = "workeridDataGridViewTextBoxColumn";
            // 
            // siteidDataGridViewTextBoxColumn
            // 
            this.siteidDataGridViewTextBoxColumn.DataPropertyName = "siteid";
            this.siteidDataGridViewTextBoxColumn.HeaderText = "siteid";
            this.siteidDataGridViewTextBoxColumn.Name = "siteidDataGridViewTextBoxColumn";
            // 
            // workerAllocationBindingSource
            // 
            this.workerAllocationBindingSource.DataMember = "WorkerAllocation";
            this.workerAllocationBindingSource.DataSource = this.cSMSDBDataSet8;
            // 
            // cSMSDBDataSet8
            // 
            this.cSMSDBDataSet8.DataSetName = "CSMSDBDataSet8";
            this.cSMSDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerAllocationTableAdapter
            // 
            this.workerAllocationTableAdapter.ClearBeforeFill = true;
            // 
            // cSMSDBDataSet9
            // 
            this.cSMSDBDataSet9.DataSetName = "CSMSDBDataSet9";
            this.cSMSDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerAllocationTableAdapter1
            // 
            this.workerAllocationTableAdapter1.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(331, 215);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 40);
            this.btnupdate.TabIndex = 12;
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
            this.btndelete.Location = new System.Drawing.Point(472, 215);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 40);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.combosid);
            this.panel1.Controls.Add(this.combowid);
            this.panel1.Controls.Add(this.txtwalloid);
            this.panel1.Controls.Add(this.lblsid);
            this.panel1.Controls.Add(this.lblwid);
            this.panel1.Controls.Add(this.walloid);
            this.panel1.Location = new System.Drawing.Point(47, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 271);
            this.panel1.TabIndex = 14;
            // 
            // WorkerAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltitle);
            this.Name = "WorkerAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerAllocation";
            this.Load += new System.EventHandler(this.WorkerAllocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerAllocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSMSDBDataSet9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label walloid;
        private System.Windows.Forms.Label lblwid;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.TextBox txtwalloid;
        private System.Windows.Forms.ComboBox combowid;
        private System.Windows.Forms.ComboBox combosid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CSMSDBDataSet8 cSMSDBDataSet8;
        private System.Windows.Forms.BindingSource workerAllocationBindingSource;
        private CSMSDBDataSet8TableAdapters.WorkerAllocationTableAdapter workerAllocationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wallocationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteidDataGridViewTextBoxColumn;
        private CSMSDBDataSet9 cSMSDBDataSet9;
        private CSMSDBDataSet9TableAdapters.WorkerAllocationTableAdapter workerAllocationTableAdapter1;
        private CSMSDBDataSet10 cSMSDBDataSet10;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private CSMSDBDataSet10TableAdapters.WorkerTableAdapter workerTableAdapter;
        private CSMSDBDataSet11 cSMSDBDataSet11;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private CSMSDBDataSet11TableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel1;
    }
}