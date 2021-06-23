using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace databaseconnectivitywithADO
{
    public partial class frm_update : Form
    {
        OleDbConnection c = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=A://dbase.mdb");
        OleDbCommand cmd;
        OleDbDataReader dr;

        public frm_update()
        {
            InitializeComponent();
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("select name,contact,address from student_info where id=" + textBox1.Text + "", c);
                c.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txt_name.Text = dr[0].ToString();
                        txt_contact.Text = dr[1].ToString();
                        txt_addr.Text = dr[2].ToString();
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("No Record Found!!!");
                    textBox1.ResetText();
                    textBox1.Focus();
                    txt_addr.ResetText();
                    txt_contact.ResetText();
                    txt_name.ResetText();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("update student_info set name='"+txt_name.Text+"',contact='"+txt_contact.Text+"',address='"+txt_addr.Text+"' where id=" + textBox1.Text + "", c);
                c.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!!!");
                textBox1.ResetText();
                textBox1.Focus();
                txt_addr.ResetText();
                txt_contact.ResetText();
                txt_name.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.Close();
            }
        }
    }
}
