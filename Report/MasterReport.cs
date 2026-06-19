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
    public partial class MasterReport : Form
    {
        public MasterReport()
        {
            InitializeComponent();
        }

        private void MasterReport_Load(object sender, EventArgs e)
        {

            this.crystalReportViewer1.RefreshReport();
        }
        connection conn = new connection();
        public ReportDocument crpt = new ReportDocument();
        private void btnsupplierreport_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from Supplier", conn.cn);
                conn.da.Fill(conn.ds, "Supplier");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\SupplierReport.rpt");
                conn.crpt.SetDataSource(conn.ds);
                crystalReportViewer1.ReportSource=conn.crpt;
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

        private void btnmaterialreport_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from Material", conn.cn);
                conn.da.Fill(conn.ds, "Material");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\MaterialReport.rpt");
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

        private void btnworkerreport_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from Worker", conn.cn);
                conn.da.Fill(conn.ds, "Worker");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\WorkerReport.rpt");
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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from sitematerial1", conn.cn);
                conn.da.Fill(conn.ds, "sitematerial1");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\SiteMaterial.rpt");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.da = new SqlDataAdapter("Select * from siteallocation", conn.cn);
                conn.da.Fill(conn.ds, "siteallocation");
                conn.crpt.Load("D:\\CSMS\\CSMS\\CSMS\\Report\\WorkerAllocation.rpt");
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
