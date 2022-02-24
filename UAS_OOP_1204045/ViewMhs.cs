using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;

namespace UAS_OOP_1204045
{
    public partial class ViewMhs : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;

        public ViewMhs()
        {
            InitializeComponent();
        }

        private void ViewMhs_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from ms_mhs";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "ms_prodi");
            datamhs.DataSource = ds;
            datamhs.DataMember = "ms_prodi";
            datamhs.Refresh();
            conn.Close();
        }
    }
}
