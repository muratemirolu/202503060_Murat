using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503006_
{
    public partial class Toplam_Satış : Form
    {
        public Toplam_Satış()
        {
            InitializeComponent();
        }

        private void Toplam_Satış_Load(object sender, EventArgs e)
        {
            Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_Satış");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yönetici yön = new Yönetici();
            this.Hide();
            yön.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox2.ImageLocation= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapor_yazdır rap = new Rapor_yazdır();
            rap.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Genel_arama gel = new Genel_arama();
            this.Hide();
            gel.Show();

        }
    }
}
