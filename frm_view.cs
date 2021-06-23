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
    public partial class frm_view : Form
    {
        OleDbConnection c = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=A://dbase.mdb");
        OleDbDataAdapter da;
        DataTable dt=new DataTable();

        public frm_view()
        {
            InitializeComponent();
        }

        private void frm_view_Load(object sender, EventArgs e)
        {
            dt.Clear();
            da = new OleDbDataAdapter("select * from student_info", c);
            da.Fill(dt);
            dtgv.DataSource = dt;
        }
    }
}
