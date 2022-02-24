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

namespace UAS_OOP_1204045
{
    public partial class daftarulangView : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataSet dsTransaksi;

        public daftarulangView()
        {
            InitializeComponent();
            refreshDs();
        }

        private void daftarulangView_Load(object sender, EventArgs e)
        {
            /*string constr = "Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from tr_daftar_ulang";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "tr_daftar_ulang");
            DGdaftarulang.DataSource = ds;
            DGdaftarulang.DataMember = "tr_daftar_ulang";
            DGdaftarulang.Refresh();
            conn.Close();*/
        }

        public DataSet prodiDataSet()
        {
            DataSet ds = new DataSet();

            try
            {
                string conn = "Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True";

                SqlConnection connection = new SqlConnection(conn);

                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandText = "SELECT * FROM tr_daftar_ulang";
                command.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.TableMappings.Add("Table", "DaftarUlang");

                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ds;
        }
        private void refreshDs()
        {
            dsTransaksi = prodiDataSet();
            DGdaftarulang.DataSource = dsTransaksi.Tables["DaftarUlang"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM tr_daftar_ulang", connection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;

            myTransaction = connection.BeginTransaction();
            myAdapter.DeleteCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.InsertCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(dsTransaksi, "DaftarUlang");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshDs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
                myTransaction.Rollback();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlConnection myConnection = new SqlConnection(@"Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("select * from tr_daftar_ulang", myConnection);
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
                int rowsUpdated = myAdapter.Update(ds, "tr_daftar_ulang");

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
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            refreshDs();
        }
    }
}
