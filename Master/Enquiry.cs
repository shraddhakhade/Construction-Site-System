using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CSMS.Master
{
    public partial class Enquiry : Form
    {
        connection conn = new connection();
        public Enquiry()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txteid.Text = "";
            txtename.Text = "";
            txtemobno.Text = "";
            txteemail.Text = "";
            txtesubject.Text = "";
            txtemessage.Text = "";
        }
        public void showgrid()
        {
            try
            {
                conn.dt.Clear();
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select * from Enquiry ";
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
        private void Enquiry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSMSDBDataSet29.Enquiry' table. You can move, or remove it, as needed.
            this.enquiryTableAdapter.Fill(this.cSMSDBDataSet29.Enquiry);
            
            btnnew.Enabled = true;
            showgrid();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string email = txteemail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {

                try
                {
                    if (txtename.Text == "")
                        MessageBox.Show("Please Enter Name");
                    else if (txtemobno.Text == "" || txtemobno.Text.Length < 10)
                        MessageBox.Show("Please Enter Valid Number");
                    else if (txteemail.Text == "")
                        MessageBox.Show("Please Enter E-mail");
                    else if (txtesubject.Text == "")
                        MessageBox.Show("Please Enter Subject ");
                    else if (txtemessage.Text == "")
                        MessageBox.Show("Please Enter Message");
                    else
                    {
                        conn.cn.Close();
                        conn.cn.Open();
                        conn.cmd.CommandText = "insert into Enquiry values(" + txteid.Text + ",'" + txtename.Text + "'," + txtemobno.Text + ",'" + txteemail.Text + "','" + txtesubject.Text + "','" + txtemessage.Text + "')";
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
            else
            {
                MessageBox.Show("Invalid Email");
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                txteid.Focus();
                int k;
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "Select max (enquiryid) from Enquiry";
                conn.cmd.Connection = conn.cn;
                conn.dr = conn.cmd.ExecuteReader();
                if (conn.dr.Read())
                {
                    String str = conn.dr[0].ToString();
                    if (str == "")
                        txteid.Text = "1";
                    else
                    {
                        k = Convert.ToInt32(conn.dr[0].ToString());
                        k++;
                        txteid.Text = k.ToString();
                    }
                }
                conn.cn.Close();
                btnsave.Enabled = true;
                txtename.Focus();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                conn.cn.Close();
                conn.cn.Open();
                conn.cmd.CommandText = "update Enquiry set enquiryid=" + txteid.Text + ",name='" + txtename.Text + "',mobileno=" + txtemobno.Text + ",email='"+txteemail.Text+"',subjects='" + txtesubject.Text + "',message='" + txtemessage.Text + "' where enquiryid="+txteid.Text+"";
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
                txteid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtename.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtemobno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                txteemail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtesubject.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtemessage.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

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
                conn.cmd.CommandText = "delete from Enquiry Where enquiryid =" + txteid.Text + "";
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

        private void txtename_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.char_only(e);
        }

        private void txtemobno_KeyPress(object sender, KeyPressEventArgs e)
        {
            conn.digit_only(e);
        }

        

       
    }
}
