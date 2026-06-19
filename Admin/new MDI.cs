using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSMS.Admin
{
    public partial class new_MDI : Form
    {
        public new_MDI()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void time()
        {
            lbldate.Text = System.DateTime.Now.ToShortDateString();
            lbltime.Text = System.DateTime.Now.ToShortTimeString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbldeveloper.Left = lbldeveloper.Left - 12;
            if (lbldeveloper.Left < 0 - lbldeveloper.Width)
                lbldeveloper.Left = Panel14.Width;

            time();
        }

        private void new_MDI_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            Timer1.Start();

        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            Admin.ManageAdmin ad = new ManageAdmin();
            ad.Show();
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            menureport.Show(PictureBox17,3,50);
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            menuutility.Show(PictureBox14, 3, 50);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.MasterReport ms = new Report.MasterReport();
            ms.Show();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "D:\\notepad.txt");
 
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.UserManual m = new UserManual();
            m.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Master.MaterialDetails mt = new Master.MaterialDetails();
            mt.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Master.SupplierDetails sd = new Master.SupplierDetails();
            sd.Show();
        
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Master.WorkerDetails wd = new Master.WorkerDetails();
            wd.Show();
       
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            Transaction.SupplierPayment sp = new Transaction.SupplierPayment();
            sp.Show();
      
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            Transaction.Purchase_Order_Details p = new Transaction.Purchase_Order_Details();
            p.Show();
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            Transaction.WorkerPayment wp = new Transaction.WorkerPayment();
            wp.Show();
 
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Transaction.CustomerPayment cp = new Transaction.CustomerPayment();
            cp.Show();

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Transaction.SiteMaterial st = new Transaction.SiteMaterial();
            st.Show();

                   }

        private void Label10_Click(object sender, EventArgs e)
        {
            Transaction.WorkerAllocation wk = new Transaction.WorkerAllocation();

            wk.Show();


        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Master.Site si = new Master.Site();
            si.Show();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Report.Payment_Report pr = new Report.Payment_Report();
            pr.Show();
        }

        private void CustomerBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseOrderIdBySearchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.Orderbysearching tr = new Report.Orderbysearching();
            tr.Show();
        }

        private void searchingPurchaseDatewiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.order_datewise_report dr = new Report.order_datewise_report();
            dr.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Master.Enquiry eq = new Master.Enquiry();
            eq.Show();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Transaction.CustomerPayment cp = new Transaction.CustomerPayment();
            cp.Show();
        }
    }
}
