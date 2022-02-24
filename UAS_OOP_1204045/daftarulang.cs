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
    public partial class daftarulang : Form
    {
        public daftarulang()
        {
            InitializeComponent();
            rbA.Checked = false;
        }

        private void rbA_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(biayaTB.Text.ToString()) * 50) / 100;
            potonganTB.Text = diskon.ToString();
            int total = Int32.Parse(biayaTB.Text.ToString()) - diskon;
            totalTB.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            npmTB.Text = "";
            namamhsTB.Text = "";
            prodiTB.Text = "";
            biayaTB.Text = "";
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            potonganTB.Text = "";
            totalTB.Text = "";
        }

        private void rbB_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(biayaTB.Text.ToString()) * 25) / 100;
            potonganTB.Text = diskon.ToString();
            int total = Int32.Parse(biayaTB.Text.ToString()) - diskon;
            totalTB.Text = total.ToString();
        }

        private void rbC_MouseClick(object sender, MouseEventArgs e)
        {
            int diskon = (Int32.Parse(biayaTB.Text.ToString()) * 10) / 100;
            potonganTB.Text = diskon.ToString();
            int total = Int32.Parse(biayaTB.Text.ToString()) - diskon;
            totalTB.Text = total.ToString();
        }
        private void updateDatabase(string sql)
        {
            try
            {
                string connection = "integrated security=true; data source=.; initial catalog=UAS";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Database berhasil di-update!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (npmTB.Text != "" && int.TryParse(npmTB.Text.ToString(), out i))
            {
                if (rbA.Checked != false || rbB.Checked != false || rbC.Checked != false)
                {
                    string grade = "";
                    if (rbA.Checked)
                    {
                        grade = "A";
                    }
                    if (rbB.Checked)
                    {
                        grade = "B";
                    }
                    if (rbC.Checked)
                    {
                        grade = "C";
                    }
                    string sql = "INSERT INTO tr_daftar_ulang VALUES('"
                        + npmTB.Text + "','"
                        + grade + "','"
                        + totalTB.Text + "')";

                    updateDatabase(sql);

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Grade Selesai Mahasiswa belum dipilih!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("NPM Mahasiswa belum diisi dan tidak boleh mengandung huruf!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string getLastIdSql = "SELECT nama_mhs,nama_prodi,biaya_kuliah FROM ms_mhs " +
                "JOIN ms_prodi ON ms_mhs.kode_prodi=ms_prodi.kode_prodi WHERE npm='" + npmTB.Text + "'";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    namamhsTB.Text = result["nama_mhs"].ToString();
                    prodiTB.Text = result["nama_prodi"].ToString();
                    biayaTB.Text = result["biaya_kuliah"].ToString();
                }
            }
        }
    }
}
