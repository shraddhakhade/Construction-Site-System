namespace CSMS.Report
{
    partial class Payment_Report
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
            this.btnsupplierreport = new System.Windows.Forms.Button();
            this.btnmaterialreport = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btncustomerpayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsupplierreport
            // 
            this.btnsupplierreport.BackColor = System.Drawing.Color.Teal;
            this.btnsupplierreport.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplierreport.ForeColor = System.Drawing.Color.White;
            this.btnsupplierreport.Location = new System.Drawing.Point(43, 268);
            this.btnsupplierreport.Name = "btnsupplierreport";
            this.btnsupplierreport.Size = new System.Drawing.Size(121, 85);
            this.btnsupplierreport.TabIndex = 6;
            this.btnsupplierreport.Text = "Worker Payment Report";
            this.btnsupplierreport.UseVisualStyleBackColor = false;
            this.btnsupplierreport.Click += new System.EventHandler(this.btnsupplierreport_Click);
            // 
            // btnmaterialreport
            // 
            this.btnmaterialreport.BackColor = System.Drawing.Color.Teal;
            this.btnmaterialreport.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaterialreport.ForeColor = System.Drawing.Color.White;
            this.btnmaterialreport.Location = new System.Drawing.Point(43, 98);
            this.btnmaterialreport.Name = "btnmaterialreport";
            this.btnmaterialreport.Size = new System.Drawing.Size(121, 81);
            this.btnmaterialreport.TabIndex = 5;
            this.btnmaterialreport.Text = "Supplier Payment Report";
            this.btnmaterialreport.UseVisualStyleBackColor = false;
            this.btnmaterialreport.Click += new System.EventHandler(this.btnmaterialreport_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1235, 729);
            this.crystalReportViewer1.TabIndex = 4;
            // 
            // btncustomerpayment
            // 
            this.btncustomerpayment.BackColor = System.Drawing.Color.Teal;
            this.btncustomerpayment.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomerpayment.ForeColor = System.Drawing.Color.White;
            this.btncustomerpayment.Location = new System.Drawing.Point(43, 418);
            this.btncustomerpayment.Name = "btncustomerpayment";
            this.btncustomerpayment.Size = new System.Drawing.Size(121, 101);
            this.btncustomerpayment.TabIndex = 7;
            this.btncustomerpayment.Text = "Customer \r\nPayment\r\n Report";
            this.btncustomerpayment.UseVisualStyleBackColor = false;
            this.btncustomerpayment.Click += new System.EventHandler(this.btncustomerpayment_Click);
            // 
            // Payment_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 729);
            this.Controls.Add(this.btncustomerpayment);
            this.Controls.Add(this.btnsupplierreport);
            this.Controls.Add(this.btnmaterialreport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Payment_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsupplierreport;
        private System.Windows.Forms.Button btnmaterialreport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btncustomerpayment;
    }
}