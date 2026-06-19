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
    public partial class Site : Form
    {
        connection conn = new connection();
        public Site()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtsiteid.Text = "";
            txtsitename.Text = "";
            cmbcname.Text = "";
            txtsiteaddress.Text = "";
            txtstartdate.Text = "";
           // txtsitemanager.Text = "";
            txtenddate.Text = "";
            txtsquarefeet.Text = "";
            txttotalbudget.Text = "";
        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Site";
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

        private void Site_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet48.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.cSMSDBDataSet48.Site);
            // TODO: This line of code loads data into the 'cSMSDBDataSet47.Enquiry' table. You can move, or remove it, as needed.
            this.enquiryTableAdapter.Fill(this.cSMSDBDataSet47.Enquiry);
            // TODO: This line of code loads data into the 'cSMSDBDataSet34.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.cSMSDBDataSet34.Worker);
            
            txtsiteid.Enabled = false;
            btnnew.Enabled = true;
            showgrid();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txtsiteid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (siteid) from Site";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtsiteid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtsiteid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                txtsitename.Focus();
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
                if (txtsitename.Text == "")
                    MessageBox.Show("Please Enter Site Name","Alert");
                else if (txtsiteaddress.Text == "")
                    MessageBox.Show("Please Enter Address","Alert");
                else if (txtstartdate.Text == "")
                    MessageBox.Show("Please Enter Site Start Date","Alert");
                else if (txtenddate.Text == "")
                    MessageBox.Show("Please Enter Site End Date ","Alert");
                else
                {
                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into Site values(" + txtsiteid.Text + ",'" + txtsitename.Text + "','"+cmbcname.Text+"','" + txtsiteaddress.Text + "','" + txtstartdate.Text + "','"+txtsitemanager.Text+"','" + txtenddate.Text + "',"+txtsquarefeet.Text +","+txttotalbudget.Text +")";
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
                conn.cmd.CommandText = "update site set siteid=" + txtsiteid.Text + ",sitename='" + txtsitename.Text + "',cname='"+cmbcname.Text+"',siteaddress='" + txtsiteaddress.Text + "',sitestartdate='" + txtstartdate.Text + "',sitemanagername='" + txtsitemanager.Text + "',siteexceptedenddate='"+txtenddate.Text+"',sitearea="+txtsquarefeet.Text +",sitebudget="+txttotalbudget.Text +"where siteid="+txtsiteid.Text +"";
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
                txtsiteid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtsitename.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbcname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsiteaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtstartdate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtsitemanager.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtenddate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtsquarefeet.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txttotalbudget.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
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
                conn.cmd.CommandText = "delete from Site Where siteid =" + txtsiteid.Text + "";
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

        private void txtsitemanager_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.char_only(e);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.workerTableAdapter.FillBy(this.cSMSDBDataSet34.Worker);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Site where sitename='"+textBox1.Text +"'";
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
