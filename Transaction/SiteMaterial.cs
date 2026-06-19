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
    public partial class SiteMaterial : Form
    {
        connection conn=new connection();
        public SiteMaterial()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtsmid.Text = "";
           // cmbsiteid.Text = "";
           // cmbmname.Text = "";
           // txtmqty.Text = "";
        }
        //public void showgrid()
        //{
        //    try
        //    {
        //        conn.dt.Clear();
        //        conn.cn.Close();
        //        conn.cn.Open();
        //        conn.cmd.CommandText = "Select * from SiteMaterial";
        //        conn.cmd.Connection = conn.cn;
        //        conn.dt.Load(conn.cmd.ExecuteReader());
        //        dataGridView1.DataSource = conn.dt;
        //        conn.cn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());

        //    }
        //}

        private void SiteMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet43.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter1.Fill(this.cSMSDBDataSet43.Material);
            
            // TODO: This line of code loads data into the 'cSMSDBDataSet27.Site' table. You can move, or remove it, as needed.
            this.siteTableAdapter.Fill(this.cSMSDBDataSet27.Site);
            // TODO: This line of code loads data into the 'cSMSDBDataSet26.SiteMaterial' table. You can move, or remove it, as needed.
            this.siteMaterialTableAdapter.Fill(this.cSMSDBDataSet26.SiteMaterial);
            txtsmid.Enabled = false;
            btnnew.Enabled = true;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txtsmid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (sitematerialid) from SiteMaterial";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txtsmid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txtsmid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                cmbsiteid.Focus();
                btnadd.Enabled = true;
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
                if (cmbsiteid.Text == "")
                    MessageBox.Show("Please Enter Site ID");
                else if (cmbmname.Text == "")
                    MessageBox.Show("Please Enter Material ID");
                else if (txtmqty.Text == "")
                    MessageBox.Show("Please Enter Material Quantity");
               
                else
                {
                    conn.cn.Close();
                    conn.cn.Open();
                    conn.cmd.CommandText = "insert into SiteMaterial values(" + txtsmid.Text + "," + cmbsiteid.SelectedValue + "," + cmbmname.SelectedValue + "," + txtmqty.Text + ")";
                    conn.cmd.Connection = conn.cn;
                    conn.cmd.ExecuteNonQuery();
                    conn.cn.Close();
                    MessageBox.Show("Data Saved!!");
                   // showgrid();
                    clear();
                    dataGridView1.Rows.Clear();
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
                conn.cmd.CommandText = "delete from SiteMaterial Where sitematerialid =" + txtsmid.Text + "";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!");
                //showgrid();
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
                conn.cmd.CommandText = "update SiteMaterial set sitematerialid=" + txtsmid.Text + ",siteid=" + cmbsiteid.SelectedValue + ",materialid=" + cmbmname.SelectedValue + ",materialquantity=" + txtmqty.Text + "";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated!");
               // showgrid();
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
                txtsmid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbsiteid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbmname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtmqty.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                //btndelete.Enabled = true;
                //btnupdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtmqty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double a = Convert.ToDouble(txtmqty.Text);
                Double b = Convert.ToDouble(txtprice.Text);
                Double c = a * b;
                txttotal.Text = c.ToString();

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

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "insert into SiteMaterialDetails values(" + txtsmid.Text + "," + cmbsiteid.SelectedValue + ",'" + cmbmname.Text + "'," + txtmqty.Text + "," + txtprice.Text + "," + txttotal.Text + ")";
                conn.cmd.Connection = conn.cn;
                conn.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Succefully", "Alert");

                Boolean found = false;
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == cmbmname.Text && Convert.ToString(row.Cells[1].Value) == txtprice.Text)
                        {
                            row.Cells[2].Value = (Convert.ToInt32(txtmqty.Text) + Convert.ToInt16(row.Cells[2].Value));
                            found = true;
                            row.Cells[3].Value = Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value);
                            //  MessageBox.Show(found);
                        }
                    }
                    if (!found)
                        dataGridView1.Rows.Add(txtsmid.Text, cmbsiteid.Text, cmbmname.Text, txtmqty.Text,txtprice.Text,txttotal.Text);
                }
                else
                    dataGridView1.Rows.Add(txtsmid.Text, cmbsiteid.Text, cmbmname.Text, txtmqty.Text,txtprice.Text,txttotal.Text);


                dataGridView1.SelectAll();

                int tot = 0;
                int i;
                for (i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    tot = tot + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                }

                txtfinal.Text = tot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}
