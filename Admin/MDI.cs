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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.SupplierDetails sd = new Master.SupplierDetails();
            sd.Show();
        }

        private void materialDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.MaterialDetails md = new Master.MaterialDetails();
            md.Show();
        }

        private void workerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.WorkerDetails wd = new Master.WorkerDetails();
            wd.Show();
        }

        
        private void supplierPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.SupplierPayment sp = new Transaction.SupplierPayment();
            sp.Show();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Calender1 cal = new Admin.Calender1();
            cal.Show();
        }

        private void workerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.WorkerPayment wp = new Transaction.WorkerPayment();
            wp.Show();
        }

        private void customerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.CustomerPayment cp = new Transaction.CustomerPayment();
            cp.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe","D:\\notepad.txt");
        }

       

       

      

        
        
    }
}
