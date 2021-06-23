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
    public partial class frm_insert : Form
    {
        OleDbConnection c = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=A://dbase.mdb");
        OleDbCommand cmd;
        
        public frm_insert()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand("insert into student_info (name,contact,address) values ('"+txt_name.Text+"','"+txt_contact.Text+"','"+txt_addr.Text+"')", c);
                c.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully!!!");
                txt_name.ResetText();
                txt_contact.ResetText();
                txt_addr.ResetText();
                txt_name.Focus();
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

        private void frm_insert_Load(object sender, EventArgs e)
        {

        }
    }
}
