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
    public partial class CustomerPayment : Form
    {
        connection conn = new connection();
        public CustomerPayment()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtcid.Text = "";
            txtoamount.Text = "";
        }

        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from CustomerPayment";
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


        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet46.CustomerPayment' table. You can move, or remove it, as needed.
            this.customerPaymentTableAdapter.Fill(this.cSMSDBDataSet46.CustomerPayment);
            // TODO: This line of code loads data into the 'cSMSDBDataSet45.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.cSMSDBDataSet45.Site);
            // TODO: This line of code loads data into the 'cSMSDBDataSet44.Enquiry' table. You can move, or remove it, as needed.
            this.enquiryTableAdapter.Fill(this.cSMSDBDataSet44.Enquiry);
            
            txtcid.Enabled = false;
            btnnew.Enabled = true;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txtcid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (cpid) from CustomerPayment";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtcid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtcid.Text = k.ToString();
                    }

                }
                conn.cn.Close();
                btnsave.Enabled = true;
                cmbcname.Focus();

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
                if (cmbcname.Text == "")
                    MessageBox.Show("Please Enter Customer Name");
                else if (cmbsname.Text == "")
                    MessageBox.Show("Please Enter Sale Order");
                else if (txtoamount.Text == "")
                    MessageBox.Show("Please Enter Order Amount");
                else if (dateTimePicker1.Text == "")
                    MessageBox.Show("Please Enter Date");
                else
                {
                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into CustomerPayment values (" + txtcid.Text + ",'" + cmbcname.Text + "','" + cmbsname.Text + "'," + txtoamount.Text + ",'" + dateTimePicker1.Text + "')";
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
                conn.cmd.CommandText = "update CustomerPayment set cpid="+txtcid.Text+",customername='"+cmbcname.Text+"',cpsitename='"+cmbsname.Text+"',cporderamount="+txtoamount.Text+",cpdate='"+dateTimePicker1.Text+"' where cpid="+txtcid.Text+"";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbcname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbsname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtoamount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                
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
                conn.cmd.CommandText = "delete from CustomerPayment Where cpid =" + txtcid.Text + "";
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtoamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void txtsorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void cmbcname_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.dt2.Clear();
                conn.cmd.CommandText = "select * from Site where cname='" + cmbcname.SelectedValue + "'";
                conn.cmd.Connection = conn.cn;
                conn.dt2.Load(conn.cmd.ExecuteReader());
                cmbsname.DataSource = conn.dt2;
                cmbsname.DisplayMember = "sitename";
                cmbsname.ValueMember = "siteid";
                conn.cn.Close();

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

        private void cmbsname_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                string s1;
                //conn.cn.Close();
                //conn.cn.Open();
                //conn.cmd.CommandText = "select sitebudget from Site where siteid=" + cmbsname.SelectedValue + " ";
                //conn.cmd.Connection = conn.cn;
                //conn.dr1 = conn.cmd.ExecuteReader();
                //while (conn.dr1.Read())
                //{
                //    s1 = conn.dr[0].ToString();
                //    txtoamount.Text = s1;
                //}

                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "select sitebudget from Site where siteid=" + cmbsname.SelectedValue + " ";
                conn.cmd.Connection = conn.cn;
                txtoamount.Text = Convert.ToString(conn.cmd.ExecuteScalar());
                

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

        private void cmbsname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
