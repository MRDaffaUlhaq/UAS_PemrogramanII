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
    public partial class prodi : Form
    {
        Decimal rupiah;
        public prodi()
        {
            InitializeComponent();

            string getLastIdSql = "SELECT kode_prodi FROM ms_prodi ORDER BY kode_prodi DESC";

            string connection = "Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();

            string newKode = "";
            if (result.HasRows)
            {
                int newKodeProdi = 0;
                while (result.Read())
                {
                    newKode = result["kode_prodi"].ToString();
                    string angkaKode = Regex.Match(newKode, @"\d+").Value;
                    newKodeProdi = Int16.Parse(angkaKode) + 1;
                    if (newKodeProdi >= 10)
                    {
                        newKode = "PRD" + newKodeProdi;
                    }
                    else
                    {
                        newKode = "PRD0" + newKodeProdi;
                    }
                    break;
                }
            }
            else
            {
                newKode = "PRD01";
            }
            kode_prodi.Text = newKode;
        }

        private void SubmitProdi_Click(object sender, EventArgs e)
        {


            string myCmd = "INSERT INTO ms_prodi VALUES('"
            + kode_prodi.Text + "','"
            + namaprodi.Text + "','"
            + singkatan.Text + "','"
            + biayakuliah.Text + "')";

            UpdateDB(myCmd);
        }

        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True");
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Basisdata berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception z)
            {
                MessageBox.Show(z.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            namaprodi.Text = "";
            singkatan.Text = "";
            biayakuliah.Text = "";

        }

        private void biayakuliah_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void biayakuliah_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(biayakuliah.Text))
            {
                rupiah = 0;
            }
            else
            {
                rupiah = decimal.Parse(biayakuliah.Text);
            }
            biayakuliah1.Text = rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string myCmd = "INSERT INTO ms_prodi VALUES('"
           + kode_prodi.Text + "','"
           + namaprodi.Text + "','"
           + singkatan.Text + "','"
           + biayakuliah.Text + "')";

            UpdateDB(myCmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            namaprodi.Text = "";
            singkatan.Text = "";
            biayakuliah.Text = "";
        }
    }
}
