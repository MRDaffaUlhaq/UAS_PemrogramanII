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

   
    public partial class mahasiswa : Form
    {
        string prodi;
        public mahasiswa()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(@"Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True");

            conn.Open();

            SqlCommand sc = new SqlCommand("SELECT * FROM ms_prodi", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("kode_prodi", typeof(string));
            dt.Columns.Add("singkatan", typeof(string));
            dt.Load(reader);

            prodicombobox.ValueMember = "kode_prodi";
            prodicombobox.DisplayMember = "singkatan";
            prodicombobox.DataSource = dt;

            conn.Close();
        }

        private void SubmitMhs_Click(object sender, EventArgs e)
        {
            
        }

        private void cbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ClearMhs_Click(object sender, EventArgs e)
        {
        
        }

        private void clear_Click(object sender, EventArgs e)
        {
            npmTB.Text = null;
            namamhs.Text = null;
            prodicombobox.SelectedIndex = 0;
        }

        private void prodicombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prodi = prodicombobox.SelectedValue.ToString();
        }

        private void submitmhs_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            //MessageBox.Show(int.TryParse(npmTB.Text.ToString(), out i).ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (npmTB.Text != "" && int.TryParse(npmTB.Text.ToString(), out i))
            {
                if (npmTB.Text != "" && npmTB.TextLength == 7)
                {
                    if (namamhs.Text != "")
                    {

                        if (prodicombobox.Text != "- Pilih Program Studi -")
                        {
                            string npm = npmTB.Text;
                            string nama = namamhs.Text;
                            string prodi = this.prodi;

                            SqlConnection conn = new SqlConnection(@"Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True");

                            string sql = "insert into ms_mhs ([npm], [nama_mhs], " +
                                " [kode_prodi]) values(@npm,@nama_mhs,@kode_prodi)";

                            using (SqlConnection cnn = new SqlConnection(@"Data Source=DAUL-DESK;Initial Catalog=UAS;Integrated Security=True"))
                            {
                                try
                                {
                                    cnn.Open();

                                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                                    {
                                        cmd.Parameters.Add("@npm", SqlDbType.NVarChar).Value = npm;
                                        cmd.Parameters.Add("@nama_mhs", SqlDbType.NVarChar).Value = nama;
                                        cmd.Parameters.Add("@kode_prodi", SqlDbType.NVarChar).Value = prodi;

                                        int rowsAdded = cmd.ExecuteNonQuery();
                                        if (rowsAdded > 0)
                                            MessageBox.Show("Data berhasil disimpan");
                                        else
                                            MessageBox.Show("Tidak ada data yang disimpan");

                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("ERROR:" + ex.Message);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show
                                        ("Prodi belum diisi!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show
                                    ("Nama belum diisi!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
                
                else
                {
                    MessageBox.Show
                                ("NPM belum diisi dan tidak boleh mengandung huruf!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }
    }
}
