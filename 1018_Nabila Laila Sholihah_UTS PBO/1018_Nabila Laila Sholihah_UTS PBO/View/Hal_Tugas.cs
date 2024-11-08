using _1018_Nabila_Laila_Sholihah_UTS_PBO.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1018_Nabila_Laila_Sholihah_UTS_PBO.View
{
    public partial class Hal_Tugas : Form
    {
        public Hal_Tugas()
        {
            InitializeComponent();
            //this.Load += Hal_Tugas_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahTugas haltambah = new TambahTugas();
            haltambah.Show();
        }

        private void Hal_Tugas_Load(object sender, EventArgs e)
        {
            LoadDataTugas();
        }

        private void LoadDataTugas()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable Tugasdata = TugasContext.All();
                if (Tugasdata == null)
                {
                    MessageBox.Show("Data tugas tidak ada");
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = Tugasdata;

                if (dataGridView1.Columns["id"] != null)
                    dataGridView1.Columns["id"].Visible = false;
                if (dataGridView1.Columns["judul_tugas"] != null)
                    dataGridView1.Columns["judul_tugas"].HeaderText = "Judul Tugas";
                if (dataGridView1.Columns["deskripsi_tugas"] != null)
                    dataGridView1.Columns["deskripsi_tugas"].HeaderText = "Deskripsi Tugas";
                if (dataGridView1.Columns["deadline_tugas"] != null)
                    dataGridView1.Columns["deadline_tugas"].HeaderText = "Deadline Tugas";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }
            }
            catch (Exception ex) {             
                MessageBox.Show($"Error dalam LoadData:{ ex.Message}\n{ ex.StackTrace}");
            }
        }
    }
}
