using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CSMS.Master
{
    public partial class SupplierDetails : Form
    {
        connection conn = new connection();
        //SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\CSMS\\CSMS\\CSMS\\CSMSDB.mdf;Integrated Security=True;User Instance=True");
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        //DataTable dt = new DataTable();
        public SupplierDetails()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtsid.Text = "";
            txtsname.Text = "";
            txtsaddress.Text = "";
            txtscity.Text = "";
            txtsmobno.Text = "";
            txtsemail.Text = "";
            txtsbankname.Text = "";
            txtsaccno.Text = "";
            txtsifsccode.Text = "";
            txtsgstno.Text = "";

        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Supplier";
                conn.cmd.Connection = conn.cn;
                conn.dt.Load(conn.cmd.ExecuteReader());
                dataGridView1.DataSource = conn.dt;
                conn.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }





        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet3.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter1.Fill(this.cSMSDBDataSet3.Supplier);
            showgrid();
            txtsid.Enabled = false;
            btnnew.Enabled = true;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txtsid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (sid) from Supplier";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtsid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtsid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                txtsname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string email = txtsemail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                try
                {
                    if (txtsname.Text == "")
                        MessageBox.Show("Please Enter Name");
                    else if (txtsaddress.Text == "")
                        MessageBox.Show("Please Enter Address");
                    else if (txtscity.Text == "")
                        MessageBox.Show("Please Enter City");
                    else if (txtsmobno.Text == "" || txtsmobno.Text.Length < 10)
                        MessageBox.Show("Please Enter Valid Mobile Number");
                    else if (txtsbankname.Text == "")
                        MessageBox.Show("Please Enter Bank Name");
                    else if (txtsaccno.Text == "")
                        MessageBox.Show("Please Enter Account Number");
                    else if (txtsifsccode.Text == "")
                        MessageBox.Show("Please Enter IFSC Code");
                    else if (txtsgstno.Text == "")
                        MessageBox.Show("Please Enter GST No.");
                    else
                    {
                        conn.cn.Close();
                        conn.cn.Open();
                        conn.cmd.CommandText = "insert into Supplier values(" + txtsid.Text + ",'" + txtsname.Text + "','" + txtsaddress.Text + "','" + txtsemail.Text + "'," + txtsmobno.Text + ",'" + txtsbankname.Text + "'," + txtsaccno.Text + ",'" + txtsifsccode.Text + "','" + txtsgstno.Text + "','" + txtscity.Text + "')";
                        conn.cmd.Connection = conn.cn;
                        conn.cmd.ExecuteNonQuery();
                        conn.cn.Close();
                        MessageBox.Show("Data Saved!!");
                        showgrid();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Invalid Email");
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "update Supplier set sid=" + txtsid.Text + ",sname='" + txtsname.Text + "',saddress='" + txtsaddress.Text + "',semail='" + txtsemail.Text + "',smobno=" + txtsmobno.Text + ",sbankname='" + txtsbankname.Text + "',saccno=" + txtsaccno.Text + ",sifsccode='" + txtsifsccode.Text + "',sgstno=" + txtsgstno.Text + ",scity='" + txtscity.Text + "' where sid="+txtsid.Text+"";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated!");
                showgrid();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "delete from Supplier Where sid =" + txtsid.Text + "";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!");
                showgrid();
                conn.cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtsid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtsname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsemail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsmobno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtsbankname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtsaccno.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtsifsccode.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtsgstno.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtscity.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.char_only(e);
        }

        private void txtsmobno_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void txtsaccno_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void txtsbankname_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.char_only(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Supplier where sname='"+textBox1.Text +"'";
                conn.cmd.Connection = conn.cn;
                conn.dt.Load(conn.cmd.ExecuteReader());
                dataGridView1.DataSource = conn.dt;
                conn.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        
    }
}


