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
    public partial class kayıt : Form
    {


        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        //public static string sqlcon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";

         public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";
        public kayıt()
        {
            InitializeComponent();
        }
        int sonuç = 0;
        void abc()
        {
            Random rd = new Random();
            int say1 = rd.Next(0, 50);
            int say2 = rd.Next(0, 50);
            sonuç = say1 + say2;
            label5.Text = say1 + "+" + say2;
        }
        void doldur()
        {
            con = new SqlConnection(sqlcon);
            da = new SqlDataAdapter("select*from tbl_Kayıt111", sqlcon);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_Kayıt111");
            // dataGridView1.DataSource = ds.Tables["tlf_login"];
            con.Close();
        }
        private void kayıt_Load(object sender, EventArgs e)
        {
            abc();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(sqlcon);
            string ekle = "insert into tbl_Kayıt111 (Kulanıcı , Şifre,TC) values (@user ,@pass,@TC)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", Veritabanı.mdı5_şifreleme(textBox2.Text));
            cmd.Parameters.AddWithValue("@TC", maskedTextBox1.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = ekle;
            cmd.ExecuteNonQuery();
            con.Close();

            if (textBox3.Text == textBox2.Text)
            {
                if (sonuç.ToString() == textBox4.Text)
                {
                    doldur();
                    Form1 frm1 = new Form1();
                    this.Hide();
                    frm1.Show();
                }
                else
                {

                    MessageBox.Show("Sayıları Doğru Toplayınız!");
                }
            }
            else
            {
                MessageBox.Show("Şifre ile şifre tekrarı birbirine uymuyor!!");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    }

