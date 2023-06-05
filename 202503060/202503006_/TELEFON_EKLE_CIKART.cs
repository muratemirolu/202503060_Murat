using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503006_
{
    public partial class TELEFON_EKLE_CIKART : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        //public static string sqlcon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";

        public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";

        public TELEFON_EKLE_CIKART()
        {
            InitializeComponent();
        
        
        }




        public void kayıt(string ekle, string a, string b, string c, string d,string e)
        {
            con = new SqlConnection(sqlcon);
            // string ekle = "insert into tbl_Kayıt111 (Kulanıcı , Şifre,TC) values (@user ,@pass,@TC)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@marka", a);
            cmd.Parameters.AddWithValue("@model", b);
            cmd.Parameters.AddWithValue("@fiyat", c);
            cmd.Parameters.AddWithValue("@foto", d);
            cmd.Parameters.AddWithValue("@özel", e);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = ekle;
            cmd.ExecuteNonQuery();
            con.Close();
            return;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "APPLE")
            {
                string ekle = "insert into tbl_apple (Marka,Model,Fiyatı,Özellikler,Resmi) values (@marka,@model,@fiyat,@özel,@foto)";
                kayıt(ekle, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            }
            if (comboBox1.Text == "NOKİA")
            {
                string ekle = "insert into tbl_nokia (Marka,Model,Fiyatı,Özellikler,Resmi) values (@marka,@model,@fiyat,@özel,@foto)";
                kayıt(ekle, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            }
            if (comboBox1.Text == "SAMSUNG")
            {
                string ekle = "insert into tbl_samsung (Marka,Model,Fiyatı,Özellikler,Resmi) values (@marka,@model,@fiyat,@özel,@foto)";
                kayıt(ekle, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            }
            if (comboBox1.Text == "OPPO")
            {
                string ekle = "insert into tbl_oppo (Marka,Model,Fiyatı,Özellikler,Resmi) values (@marka,@model,@fiyat,@özel,@foto)";
                kayıt(ekle, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            }
            if (comboBox1.Text == "HUAWAİ")
            {
                string ekle = "insert into tbl_huawai (Marka,Model,Fiyatı,Özellikler,Resmi) values (@marka,@model,@fiyat,@özel,@foto)";
                kayıt(ekle, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            }
            if (comboBox1.Text == "XİOAMİ")
            {
                string ekle = "insert into tbl_xioamii (Marka,Model,Fiyatı,Özellikler,Resmi) values (@marka,@model,@fiyat,@özel,@foto)";
                kayıt(ekle, comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox3.Text = openFileDialog1.FileName;
           

        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_apple");
            }
            if (comboBox2.SelectedIndex == 1)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_nokia");
            }
            if (comboBox2.SelectedIndex == 2)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_xioamii");
            }
            if (comboBox2.SelectedIndex == 3)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_samsung");
            }
            if (comboBox2.SelectedIndex == 4)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_huawai");
            }
            if (comboBox2.SelectedIndex == 5)
            {
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_oppo");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Veritabanı.sil("tbl_apple", textBox4.Text);
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_apple");
                
            }
            if (comboBox2.SelectedIndex == 1)
            {
                Veritabanı.sil("tbl_nokia", textBox4.Text);
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_nokia");
            }
            if (comboBox2.SelectedIndex == 2)
            {
                Veritabanı.sil("tbl_xioami", textBox4.Text);
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_xioami");
            }
            if (comboBox2.SelectedIndex == 3)
            {
                Veritabanı.sil("tbl_samsung", textBox4.Text);
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_samsung");
            }
            if (comboBox2.SelectedIndex == 4)
            {
                Veritabanı.sil("tbl_huawai", textBox4.Text);
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_huawaii");
            }
            if (comboBox2.SelectedIndex == 5)
            {
                Veritabanı.sil("tbl_oppo", textBox4.Text);
                Veritabanı.datGRİDDOLDUR(dataGridView1, "tbl_oppo");

            }
               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TELEFON_EKLE_CIKART_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yönetici yön = new Yönetici();
            this.Hide();
            yön.Show();
        }
    }
}
