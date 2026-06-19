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
    public partial class ManageAdmin : Form
    {
        connection conn = new connection();
        
        public ManageAdmin()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtname.Text = "";
            txtpass.Text = "";
            txtcpass.Text = "";
        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Admin";
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "")
                    MessageBox.Show("Please Enter Admin Name");
                else if (txtpass.Text == "")
                    MessageBox.Show("Please Enter Password");
                else if (txtcpass.Text == "")
                    MessageBox.Show("Please Enter Confirm Password");
                
                else
                {
                    if (txtpass.Text== txtcpass.Text)
                    {
                        conn.cn.Close();
                        conn.cn.Open();
                        conn.cmd.CommandText = "insert into Admin values('" + txtname.Text + "','" + txtpass.Text + "')";
                        conn.cmd.Connection = conn.cn;
                        conn.cmd.ExecuteNonQuery();
                        conn.cn.Close();
                        MessageBox.Show("Data Saved!!");
                        showgrid();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Password or Confirm Password Must be Same");
                    }

                }
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
                conn.cmd.CommandText = "update Admin set adminname='" + txtname.Text + "',password='" + txtpass.Text + "' where adminname='"+txtname.Text+"'";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated!!");
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
                conn.cmd.CommandText = "delete from Admin where adminname='" + txtname.Text + "'";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!!");
                showgrid();
                clear();
                conn.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet5.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.cSMSDBDataSet5.Admin);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtpass.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            clear();
        }
        
    }
}
