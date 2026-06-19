namespace CSMS.Admin
{
    partial class MDI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymenttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stocktoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMannualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Location = new System.Drawing.Point(-56, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1908, 113);
            this.panel1.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Teal;
            this.lbltitle.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-22, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(1937, 112);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Construction Site Management System";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(2, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1782, 62);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.PaymenttoolStripMenuItem1,
            this.stocktoolStripMenuItem1,
            this.utilityToolStripMenuItem,
            this.userMannualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1782, 62);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialDetailsToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem,
            this.workerDetailsToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(97, 58);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // materialDetailsToolStripMenuItem
            // 
            this.materialDetailsToolStripMenuItem.Name = "materialDetailsToolStripMenuItem";
            this.materialDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.materialDetailsToolStripMenuItem.Text = "MaterialDetails";
            this.materialDetailsToolStripMenuItem.Click += new System.EventHandler(this.materialDetailsToolStripMenuItem_Click);
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.supplierDetailsToolStripMenuItem.Text = "SupplierDetails";
            this.supplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierDetailsToolStripMenuItem_Click);
            // 
            // workerDetailsToolStripMenuItem
            // 
            this.workerDetailsToolStripMenuItem.Name = "workerDetailsToolStripMenuItem";
            this.workerDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.workerDetailsToolStripMenuItem.Text = "WorkerDetails";
            this.workerDetailsToolStripMenuItem.Click += new System.EventHandler(this.workerDetailsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierPaymentToolStripMenuItem,
            this.workerPaymentToolStripMenuItem,
            this.customerPaymentToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(149, 58);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // supplierPaymentToolStripMenuItem
            // 
            this.supplierPaymentToolStripMenuItem.Name = "supplierPaymentToolStripMenuItem";
            this.supplierPaymentToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.supplierPaymentToolStripMenuItem.Text = "Supplier Payment";
            this.supplierPaymentToolStripMenuItem.Click += new System.EventHandler(this.supplierPaymentToolStripMenuItem_Click);
            // 
            // workerPaymentToolStripMenuItem
            // 
            this.workerPaymentToolStripMenuItem.Name = "workerPaymentToolStripMenuItem";
            this.workerPaymentToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.workerPaymentToolStripMenuItem.Text = "Worker Payment";
            this.workerPaymentToolStripMenuItem.Click += new System.EventHandler(this.workerPaymentToolStripMenuItem_Click);
            // 
            // customerPaymentToolStripMenuItem
            // 
            this.customerPaymentToolStripMenuItem.Name = "customerPaymentToolStripMenuItem";
            this.customerPaymentToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
            this.customerPaymentToolStripMenuItem.Text = "Customer Payment";
            this.customerPaymentToolStripMenuItem.Click += new System.EventHandler(this.customerPaymentToolStripMenuItem_Click);
            // 
            // PaymenttoolStripMenuItem1
            // 
            this.PaymenttoolStripMenuItem1.Name = "PaymenttoolStripMenuItem1";
            this.PaymenttoolStripMenuItem1.Size = new System.Drawing.Size(115, 58);
            this.PaymenttoolStripMenuItem1.Text = "Payment";
            // 
            // stocktoolStripMenuItem1
            // 
            this.stocktoolStripMenuItem1.Name = "stocktoolStripMenuItem1";
            this.stocktoolStripMenuItem1.Size = new System.Drawing.Size(84, 58);
            this.stocktoolStripMenuItem1.Text = "Stock";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.calenderToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(92, 58);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calenderToolStripMenuItem
            // 
            this.calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            this.calenderToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.calenderToolStripMenuItem.Text = "Calender";
            this.calenderToolStripMenuItem.Click += new System.EventHandler(this.calenderToolStripMenuItem_Click);
            // 
            // userMannualToolStripMenuItem
            // 
            this.userMannualToolStripMenuItem.Name = "userMannualToolStripMenuItem";
            this.userMannualToolStripMenuItem.Size = new System.Drawing.Size(172, 58);
            this.userMannualToolStripMenuItem.Text = "User Mannual";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1841, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymenttoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stocktoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMannualToolStripMenuItem;
    }
}