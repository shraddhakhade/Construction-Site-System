using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSMS.Transaction
{
    public partial class WorkerAllocation : Form
    {
        connection conn = new connection();
        public WorkerAllocation()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtwalloid.Text = "";
            
        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from WorkerAllocation";
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

        private void WorkerAllocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet11.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.cSMSDBDataSet11.Site);
            // TODO: This line of code loads data into the 'cSMSDBDataSet10.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.cSMSDBDataSet10.Worker);
            // TODO: This line of code loads data into the 'cSMSDBDataSet9.WorkerAllocation' table. You can move, or remove it, as needed.
            this.workerAllocationTableAdapter1.Fill(this.cSMSDBDataSet9.WorkerAllocation);
            // TODO: This line of code loads data into the 'cSMSDBDataSet8.WorkerAllocation' table. You can move, or remove it, as needed.
            this.workerAllocationTableAdapter.Fill(this.cSMSDBDataSet8.WorkerAllocation);
            txtwalloid.Enabled = false;
            btnnew.Enabled = true;
        
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txtwalloid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (wallocationid) from WorkerAllocation";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtwalloid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtwalloid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                combowid.Focus();
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
                if (combowid.Text == "")
                    MessageBox.Show("Please Enter Worker ID");
                else if (combosid.Text == "")
                    MessageBox.Show("Please Enter Site ID");
                else
                {
                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into WorkerAllocation values(" + txtwalloid.Text + "," + combowid.SelectedValue + ",'" + combosid.SelectedValue + "')";
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "delete from WorkerAllocation Where wallocationid =" + txtwalloid.Text + "";
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
                conn.cmd.CommandText = "update WorkerAllocation set wallocationid=" + txtwalloid.Text + ",workerid=" + combowid.SelectedValue + ",siteid=" + combosid.SelectedValue + " where wallocationid="+txtwalloid.Text+"";
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
                txtwalloid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                combowid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                combosid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                btndelete.Enabled = true;
                btnupdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
