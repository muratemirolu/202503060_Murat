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
    public partial class Şifremi_Unuttum : Form
    {
        public Şifremi_Unuttum()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
       // public static string sqlcon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";

        public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";
        int sonuç = 0;
        void abc()
        {
            Random rd = new Random();
            int say1 = rd.Next(0, 50);
            int say2 = rd.Next(0, 50);
            sonuç = say1 + say2;
            label5.Text = say1 + "+" + say2;
        }

        private void Şifremi_Unuttum_Load(object sender, EventArgs e)
        {
            abc();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlcon);
            string güncelle = "update  tbl_Kayıt111 set Şifre=@pass where TC=@TC";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@TC", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", Veritabanı.mdı5_şifreleme(textBox2.Text));
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = güncelle;
            cmd.ExecuteNonQuery();
            con.Close();
           
                    Veritabanı.doldur();
                    Form1 form = new Form1();
                    this.Hide();
                    form.Show();
                
        }
    }
    }

