using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSMS.Master
{
    public partial class MaterialDetails : Form
    {
        connection conn = new connection();
        //SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\CSMS\\CSMS\\CSMS\\CSMSDB.mdf;Integrated Security=True;User Instance=True");
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        //DataTable dt = new DataTable();
        public MaterialDetails()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtmid.Text = "";
            txtmname.Text = "";
            txtmunit.Text = "";
            txtmprice.Text = "";
            txtmstock.Text = "";
            
           
        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Material";
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

        private void MaterialDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet37.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.cSMSDBDataSet37.Material);
            // TODO: This line of code loads data into the 'cSMSDBDataSet36.Material' table. You can move, or remove it, as needed.
            showgrid();
            txtmid.Enabled = false;
            btnnew.Enabled = true;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
             try
            {
                txtmid.Focus();
                int k;
                conn.cn.Close();
               conn.cn.Open();
                conn.cmd.CommandText = "Select max (mid) from Material";
                conn.cmd.Connection = conn.cn;
                conn.dr =conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                   String str = conn.dr[0].ToString();
                    if (str == "")
                        txtmid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtmid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                txtmname.Focus();
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
                if (txtmname.Text == "")
                    MessageBox.Show("Please Enter Material Name");
                else if (txtmunit.Text == "")
                    MessageBox.Show("Please Enter Unit");
                else if (txtmprice.Text == "")
                    MessageBox.Show("Please Enter Price");
                else if (txtmstock.Text == "")
                    MessageBox.Show("Please Enter Stock");
                
                else
                {

                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into Material values(" + txtmid.Text + ",'" + txtmname.Text + "','" + txtmunit.Text + "'," + txtmprice.Text + "," + txtmstock.Text + ")";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
               conn.cn.Open();
                conn.cmd.CommandText = "update Material set mid=" + txtmid.Text + ",mname='" + txtmname.Text + "',munit='" + txtmunit.Text + "',mprice=" + txtmprice.Text + ",mstock=" + txtmstock.Text + " where mid="+txtmid.Text+"";
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
                txtmid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtmname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtmunit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtmprice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtmstock.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
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
                conn.cmd.CommandText = "delete from Material Where mid =" + txtmid.Text + "";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!");
                showgrid();
                conn.cn.Close();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtmunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void txtmstock_KeyPress(object sender, KeyPressEventArgs e)
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
                conn.cmd.CommandText = "Select * from Material where mname='"+textBox1.Text +"'";
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

        private void txtmprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        

    }
}
