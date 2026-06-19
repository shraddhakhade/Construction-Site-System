using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSMS.Master
{
    public partial class WorkerDetails : Form
    {
        connection conn = new connection();
        //SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\CSMS\\CSMS\\CSMS\\CSMSDB.mdf;Integrated Security=True;User Instance=True");
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        //DataTable dt = new DataTable();
        public WorkerDetails()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtwid.Text = "";
            txtwname.Text = "";
            txtwaddress.Text = "";
            txtwmobno.Text = "";
            txtwdesignation.Text = "";
            

        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Worker";
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

        private void WorkerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet4.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.cSMSDBDataSet4.Worker);
            txtwid.Enabled = false;
            btnnew.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                txtwid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (workerid) from Worker";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtwid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtwid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                txtwname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtwname.Text == "")
                    MessageBox.Show("Please Enter Name");
                else if (txtwaddress.Text == "")
                    MessageBox.Show("Please Enter Address");
                else if (txtwmobno.Text == "" || txtwmobno.Text.Length < 10)
                    MessageBox.Show("Please Enter Valid Mobile Number");
                else if (txtwdesignation.Text == "")
                    MessageBox.Show("Please Enter Designation ");
                else
                {
                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into Worker values(" + txtwid.Text + ",'" + txtwname.Text + "','" + txtwaddress.Text + "'," + txtwmobno.Text + ",'" + txtwdesignation.Text + "')";
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

        private void btncancle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "delete from Worker Where workerid =" + txtwid.Text + "";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "update Worker set workerid=" + txtwid.Text + ",workername='" + txtwname.Text + "',workeraddress='" + txtwaddress.Text + "',workermobno=" + txtwmobno.Text + ",workerdesignation='" + txtwdesignation.Text + "' where workerid="+txtwid.Text+"";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtwid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtwname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtwaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                txtwmobno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtwdesignation.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtwname_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.char_only(e);
        }

        private void txtwmobno_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Worker where workername='"+textBox1.Text +"'";
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
