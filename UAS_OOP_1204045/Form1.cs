namespace UAS_OOP_1204045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mahasiswa inputMahasiswa = new mahasiswa();
            inputMahasiswa.MdiParent = this;
            inputMahasiswa.Show();
        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodi inputProdi = new prodi();
            inputProdi.MdiParent = this;
            inputProdi.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            daftarulang inputDaftarUlang = new daftarulang();
            inputDaftarUlang.MdiParent = this;
            inputDaftarUlang.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProdi dataprodi = new ViewProdi();
            dataprodi.MdiParent = this;
            dataprodi.Show();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMhs datamhs = new ViewMhs();
            datamhs.MdiParent = this;
            datamhs.Show();
        }
    }
}