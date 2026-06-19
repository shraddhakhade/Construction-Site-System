using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace CSMS.Report
{
    public partial class order_datewise_report : Form
    {
        public order_datewise_report()
        {
            InitializeComponent();
        }
        connection conn = new connection();
        public ReportDocument crpt = new ReportDocument();
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select distinct * from purchaseview where podate between '"+dateTimePicker1.Text +"'and '"+dateTimePicker2.Text +"'", conn.cn);
                conn.da.Fill(conn.ds, "purchaseview");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\purchaseviewreport.rpt");
                conn.crpt.SetDataSource(conn.ds);
                crystalReportViewer1.ReportSource = conn.crpt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.cn.Close();
            }

        }
    }
}
