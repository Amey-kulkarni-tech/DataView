using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace databaseconnectivitywithADO
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            frm_insert a = new frm_insert();
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            frm_update a = new frm_update();
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            frm_delete a = new frm_delete();
            a.ShowDialog();
            a.Dispose();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            frm_view a = new frm_view();
            a.ShowDialog();
            a.Dispose();
        }
    }
}
