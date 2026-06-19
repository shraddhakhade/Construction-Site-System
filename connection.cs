using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace CSMS
{
    public class connection
    {
       public SqlConnection cn=new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\CSMS\\CSMS\\CSMS\\CSMSDB.mdf;Integrated Security=True;User Instance=True");
       public SqlCommand cmd = new SqlCommand();
       public SqlDataReader dr;
       public SqlDataReader dr1;
       public SqlDataAdapter da = new SqlDataAdapter();
       public DataTable dt = new DataTable();
       public DataSet ds = new DataSet();
       public DataTable dt2 = new DataTable();
       public DataTable dt3 = new DataTable();
       public DataTable dt4 = new DataTable();
       public ReportDocument crpt = new ReportDocument();
       

       public void digit_only(KeyPressEventArgs e)
       {
           try
           {
               if (!(char.IsDigit(e.KeyChar)|| char.IsControl(e.KeyChar)))
               {
                   e.Handled = true;
                   MessageBox.Show("Enter Digit Only", "Alert");
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
           }
       }

       public void char_only(KeyPressEventArgs e)
       {
           try
           {
               if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
               {
                   MessageBox.Show("Enter only Character", "Alert");
               }
        
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
           }

       }

    }
}
