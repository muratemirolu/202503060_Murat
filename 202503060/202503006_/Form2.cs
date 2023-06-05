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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_apple");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_oppo");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_xioamii");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_samsung");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_huawai");
            }
            if (comboBox1.SelectedIndex == 5)
            {

                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_nokia");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
             textBox1.Text = Form1.lazım;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veritabanı.Satiş("tbl_Satış", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, richTextBox1.Text, pictureBox1.ImageLocation);
            MessageBox.Show("Satın Alma Başarılı");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            pictureBox1.ImageLocation = " ";
        }
    }
}
