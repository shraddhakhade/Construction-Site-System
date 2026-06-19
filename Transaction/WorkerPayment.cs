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
    public partial class WorkerPayment : Form
    {
        connection conn = new connection();
        public WorkerPayment()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtwpid.Text = "";
            txtsalary.Text = "";
            dateTimePicker1.Text = "";
        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from WorkerPayment";
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


        private void WorkerPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet21.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.cSMSDBDataSet21.Worker);
            // TODO: This line of code loads data into the 'cSMSDBDataSet20.WorkerPayment' table. You can move, or remove it, as needed.
            this.workerPaymentTableAdapter.Fill(this.cSMSDBDataSet20.WorkerPayment);

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txtwpid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (wpid) from WorkerPayment";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtwpid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtwpid.Text = k.ToString();
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
                else if (txtsalary.Text == "")
                    MessageBox.Show("Please Enter Salary");
                else if (dateTimePicker1.Text == "")
                    MessageBox.Show("Please Enter Date");

                else
                {
                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into WorkerPayment values(" + txtwpid.Text + ",'" + txtwname.Text + "'," + txtsalary.Text + ",'" + dateTimePicker1.Text + "')";
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "update WorkerPayment set wpid=" + txtwpid.Text + ",wname='" + txtwname.Text + "',wpsalary=" + txtsalary.Text + ",wpdate='" + dateTimePicker1.Text + "' where wpid="+txtwpid.Text+"";
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
                conn.cmd.CommandText = "delete from WorkerPayment Where wpid =" + txtwpid.Text + "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtwpid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtwname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsalary.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                
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

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }
        

    }
}
