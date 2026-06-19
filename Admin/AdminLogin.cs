using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSMS.Admin
{
    public partial class AdminLogin : Form
    {

        SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\CSMS\\CSMS\\CSMS\\CSMSDB.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        String strname, strpassword;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Close();
                cn.Open();
                cmd.CommandText = "select * from Admin where adminname='" + txtname.Text + "'";
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        strname = dr.GetString(0);
                        strpassword = dr.GetString(1);
                    }
                }
                cn.Close();
                if (strname == txtname.Text && strpassword == txtpass.Text)
                {
                  //  MessageBox.Show("Login Sucessfully!!");
                  //  this.Hide();
                    Admin.new_MDI md = new new_MDI();
                    md.Show();

                }
                else
                {
                    MessageBox.Show("Confirm User Name or Password", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void charonly(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Only char are Allowed", "Alert");
                e.Handled = true;
            }
        }
        public void digitonly(KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    MessageBox.Show("Enter only Digit", "Alert");
                }

            }

            catch
            {

            }
        }
    }
}

