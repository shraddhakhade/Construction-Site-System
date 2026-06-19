using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CSMS.Transaction
{
    public partial class Purchase_Order_Details : Form
    {
        connection con = new connection();
        String str;
        

        public void SupplierCombo()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt2.Clear();
                con.cmd.CommandText = "select * from Supplier";
                con.cmd.Connection = con.cn;
                con.dt2.Load(con.cmd.ExecuteReader());
                cmbsname.DataSource = con.dt2;
                cmbsname.DisplayMember = "sname";
                cmbsname.ValueMember = "sid";
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
        }
        public void productCombo()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt4.Clear();
                con.cmd.CommandText = "select * from Material where name='" + cmbmname.Text + "'";
                con.cmd.Connection = con.cn;
                con.dt4.Load(con.cmd.ExecuteReader());
                cmbmname.DataSource = con.dt4;
                cmbmname.DisplayMember = "mname";
                cmbmname.ValueMember = "mid";
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
        }
        public void clear()
        {
            txtpoid.Text = "";

        }

        public Purchase_Order_Details()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int k;
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "select max (podetailid) from Purchase_Order_Details ";
                con.cmd.Connection = con.cn;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == "")
                        txtpodid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(con.dr[0].ToString());
                        k++;
                        txtpodid.Text = k.ToString();

                    }
                }
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "insert into Purchase_Order_Details values(" + txtpodid.Text + "," + txtpoid.Text + "," + cmbmname.SelectedValue + "," + txtqty.Text + "," + txtprice.Text + "," + txttotal.Text + ")";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Succefully", "Alert");

                Boolean found = false;
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == cmbmname.Text && Convert.ToString(row.Cells[1].Value) == txtprice.Text)
                        {
                            row.Cells[2].Value = (Convert.ToInt32(txtqty.Text) + Convert.ToInt16(row.Cells[2].Value));
                            found = true;
                            row.Cells[3].Value = Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value);
                            //  MessageBox.Show(found);
                        }
                    }
                    if (!found)
                        dataGridView1.Rows.Add(cmbmname.Text, txtqty.Text, txtprice.Text, txttotal.Text);
                }
                else
                    dataGridView1.Rows.Add(cmbmname.Text, txtqty.Text, txtprice.Text, txttotal.Text);


                dataGridView1.SelectAll();

                int tot = 0;
                int i;
                for (i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    tot = tot + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }

                txtfinal.Text = tot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                double a, b, c;
                a = Convert.ToDouble(txtqty.Text);
                b = Convert.ToDouble(txtst1.Text);
                c = a + b;
                txtst2.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //stock quantity update
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "update Material set mstock=" + txtst2.Text + " where mname='" + cmbmname.Text + "'";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                //MessageBox.Show("Record Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.cn.Close();
            }
            //rate update
            try
            {
                con.cn.Close();
                con.cn.Open();
               con. cmd.CommandText = "update Material set mprice=" + txtprice.Text + " where mname='" + cmbmname.Text + "'";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
               con.cn.Close();
            }
            txtpodid.Text = "";
              btnsave.Enabled = true;
              txtpodid.Text = "";
              txtst1.Text = "";
              txtst2.Text = "";
              txtprice.Text = "";
              txttotal.Text = "";
     
        }

        private void Purches_Order_Load(object sender, EventArgs e)
        {
            SupplierCombo();
            productCombo();
        }
        
      
        private void btnnew_Click(object sender, EventArgs e)
        {
             try
            {
                int k;
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "select max (poid) from Purchase_Order ";
                con.cmd.Connection = con.cn;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == "")
                        txtpoid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(con.dr[0].ToString());
                        k++;
                        txtpoid.Text = k.ToString();
                         }
                }
                con.cn.Close();
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
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "insert into Purchase_Order values(" + txtpoid.Text + "," + cmbsname.SelectedValue + ",'" + dateTimePicker1.Text + "'," + txtfinal.Text + "," + txtdiscount.Text + "," + txtgrand.Text + ")";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved");
                txtpoid.Text = "";
                //txtfinal.Text = "";
                //txtdiscount.Text = "";
                //txtgrand.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
               con.cn.Close();
            }
            dataGridView1.Rows.Clear();
        }
       
       

        private void txtpodid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Order_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet42.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter1.Fill(this.cSMSDBDataSet42.Material);
           
            // TODO: This line of code loads data into the 'cSMSDBDataSet32.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.cSMSDBDataSet32.Supplier);
            
        }

       

       
       
        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double a = Convert.ToDouble(txtqty.Text);
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
                con.cn.Close();
            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double p = Convert.ToDouble(txtfinal.Text);
                Double s = Convert.ToDouble(txtgst.Text);
                Double z = p + (p * (s / 100));
                Double q = Convert.ToDouble(txtdiscount.Text);
                Double r = z - q;
                txtgrand.Text = r.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.cn.Close();
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "insert into Purchase_Order values(" + txtpoid.Text + "," + cmbsname.SelectedValue + ",'" + dateTimePicker1.Text + "'," + txtfinal.Text + "," + txtdiscount.Text + "," + txtgrand.Text + ")";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved");
                txtpoid.Text = "";
                //txtfinal.Text = "";
                //txtdiscount.Text = "";
                //txtgrand.Text = "";
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            txtpoid.Text = "";
            txtprice.Text = "";
            txttotal.Text = "";
            txtpodid.Text = "";
            txtst1.Text = "";
            txtst2.Text = "";
            txtfinal.Text = "";
            txtgst.Text = "";
            txtgrand.Text = "";

        }

        private void cmbmname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                string s1;
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "select mstock from Material where mid=" + cmbmname.SelectedValue + "";
                con.cmd.Connection = con.cn;
                con.dr1 = con.cmd.ExecuteReader();
                while (con.dr1.Read())
                {
                    s1 = con.dr1[0].ToString();
                    txtst1.Text = s1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
        }    
    }
}
