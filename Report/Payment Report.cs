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
    public partial class Payment_Report : Form
    {
        public Payment_Report()
        {
            InitializeComponent();
        }
        connection conn = new connection();
        public ReportDocument crpt = new ReportDocument();
       
        private void btnmaterialreport_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from Supplier_Payment", conn.cn);
                conn.da.Fill(conn.ds, "Supplier_Payment");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\SupplierPayment.rpt");
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

        private void btnsupplierreport_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from WorkerPayment", conn.cn);
                conn.da.Fill(conn.ds, "WorkerPayment");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\WorkerPayment.rpt");
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

        private void btncustomerpayment_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from CustomerPayment", conn.cn);
                conn.da.Fill(conn.ds, "CustomerPayment");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\CustomerReport.rpt");
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
