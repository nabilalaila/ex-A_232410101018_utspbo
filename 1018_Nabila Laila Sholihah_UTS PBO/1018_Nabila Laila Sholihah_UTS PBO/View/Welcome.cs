using _1018_Nabila_Laila_Sholihah_UTS_PBO.View;

namespace _1018_Nabila_Laila_Sholihah_UTS_PBO
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hal_Tugas halamanTugas = new Hal_Tugas();
            halamanTugas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DaftarPengguna daftarPengguna = new DaftarPengguna();
            daftarPengguna.Show();
        }
    }
}
