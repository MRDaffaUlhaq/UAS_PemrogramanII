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
    public partial class UDmhs : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;

        public UDmhs()
        {
            InitializeComponent();
        }

        private void UDmhs_Load(object sender, EventArgs e)
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
            da.Fill(ds, "ms_mhs");
            DGkelolamhs.DataSource = ds;
            DGkelolamhs.DataMember = "ms_mhs";
            DGkelolamhs.Refresh();
            conn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
           
            SqlConnection myConnection = new SqlConnection(@"Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from ms_mhs", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;

            myTransaction = myConnection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(ds, "ms_mhs");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " berhasil ubah data", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }
            //MessageBox.Show(myAdapter.InsertCommand.CommandText);
            //MessageBox.Show(myAdapter.UpdateCommand.CommandText);
            //MessageBox.Show(myAdapter.DeleteCommand.CommandText);
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            
            SqlConnection myConnection = new SqlConnection(@"Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from ms_mhs", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;

            myTransaction = myConnection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(ds, "ms_mhs");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " berhasil ubah data", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }
            //MessageBox.Show(myAdapter.InsertCommand.CommandText);
            //MessageBox.Show(myAdapter.UpdateCommand.CommandText);
            //MessageBox.Show(myAdapter.DeleteCommand.CommandText);
        }
    }
}
