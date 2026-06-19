using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSMS.Transaction
{
    public partial class SupplierPayment : Form
    {
        connection conn = new connection();

        public SupplierPayment()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtspid.Text = "";
            //txtsid.Text = "";
            //txtsptotal.Text = "";
            //txtspaidamount.Text = "";
            txtspdue.Text = "";
            //dateTimePicker1.Text = "";
            txtOrderStatus.Text = "";
            txtspdescription.Text = "";
            txtsbankname.Text = "";

        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "select * from Supplier_Payment";
                conn.cmd.Connection = conn.cn;
                conn.dt.Load(conn.cmd.ExecuteReader());
                dataGridView1.DataSource = conn.dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SupplierPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet35.Purchase_Order' table. You can move, or remove it, as needed.
            //this.purchase_OrderTableAdapter.Fill(this.cSMSDBDataSet35.Purchase_Order);
            // TODO: This line of code loads data into the 'cSMSDBDataSet23.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.cSMSDBDataSet23.Supplier);
            // TODO: This line of code loads data into the 'cSMSDBDataSet22.Supplier_Payment' table. You can move, or remove it, as needed.
            this.supplier_PaymentTableAdapter.Fill(this.cSMSDBDataSet22.Supplier_Payment);
           
           
            txtspid.Enabled = false;
            btnnew.Enabled = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txtspid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "select max (spid) from Supplier_Payment";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtspid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtspid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                txtsid.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsid.Text == "")
                    MessageBox.Show("Please Enter Site ID");
                else if (txtsptotal.Text == "")
                    MessageBox.Show("Please Enter Total Amount");
                else if (txtspaidamount.Text == "")
                    MessageBox.Show("Please Enter paid Amount");
                else if (txtspdue.Text == "")
                    MessageBox.Show("Please Enter Payment Due");
                else if (dateTimePicker1.Text == "")
                    MessageBox.Show("Please Enter Date");
                else if (txtOrderStatus.Text == "")
                    MessageBox.Show("Please Enter Status");
                else if (txtspdescription.Text == "")
                    MessageBox.Show("Please Enter Description ");
                else if (txtsbankname.Text == "")
                    MessageBox.Show("Please Enter Bank Name");
                else
                {
                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into Supplier_Payment values (" + txtspid.Text + ",'" + txtsid.Text + "'," + txtsptotal.Text + "," + txtspaidamount.Text + "," + txtspdue.Text + ",'" + txtOrderStatus.Text + "','" + txtspdescription.Text + "','" + txtsbankname.Text + "','" + dateTimePicker1.Text + "')";
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

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtspid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtsid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsptotal.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtspaidamount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtspdue.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtOrderStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtspdescription.Text=dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtsbankname.Text=dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                      
        }

        //private void btnupdate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        conn.cn.Close();
        //        conn.cn.Open();
        //        conn.cmd.CommandText = "update Supplier_Payment set spid=" + txtspid.Text + ",sname='" + txtsid.Text + "',sptotal=" + txtsptotal.Text + ",sppaidamount=" + txtspaidamount.Text + ",spdue=" + txtspdue.Text + ",spstatus='"+ combospstatus.Text + "',spdescription='" + txtspdescription.Text + "',spbankname='" + txtsbankname.Text + "',spdate='"+dateTimePicker1.Text+"'";
        //        conn.cmd.ExecuteNonQuery();
        //        MessageBox.Show("Record Updated!!");
        //        showgrid();
        //        clear();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        //private void btndelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        conn.cn.Close();
        //        conn.cn.Open();
        //        conn.cmd.CommandText = "delete from Supplier_Payment Where spid= "+txtspid.Text+"";
        //        conn.cmd.Connection = conn.cn;
        //        conn.cmd.ExecuteNonQuery();
        //        MessageBox.Show("Record Deleted!");
        //        showgrid();
        //        conn.cn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void txtsptotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void txtspaidamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void txtspdue_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        private void txtsbankname_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.char_only(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtspaidamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = Convert.ToDouble(txtsptotal.Text);
                b = Convert.ToDouble(txtspaidamount.Text);
                c = a - b;
                txtspdue.Text  = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtspdue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s1 = "Compelete";
                string s2 = "Incomplete";
                if (txtspdue.Text  == "0")
                {
                    txtOrderStatus.Text = s1.ToString();
                }
                else
                {
                    txtOrderStatus.Text = s2.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmborderid_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtsid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.dt2.Clear();
                conn.cmd.CommandText = "select * from Purchase_Order where sid="+txtsid.SelectedValue+"";
                conn.cmd.Connection = conn.cn;
                conn.dt2.Load(conn.cmd.ExecuteReader());
                cmborderid.DataSource = conn.dt2;
                cmborderid.DisplayMember = "poid";
                cmborderid.ValueMember = "poid";
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

        private void cmborderid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr1;
                string s1;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select pototal from Purchase_order where poid = " + cmborderid.SelectedValue + "";
                conn.cmd.Connection = conn.cn;
                dr1 = conn.cmd.ExecuteReader();
                while (dr1.Read())
                {
                    s1 = dr1[0].ToString();
                    txtsptotal.Text = s1;
                }
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
    }
}
