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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;

        
        public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";
        ///public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";public static string sqlcon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";
        public static string lazım = " ";
        public static string lazım1 = " ";
        int sonuç = 0;
        void abc()
        {
            Random rd = new Random();
            int say1 = rd.Next(0, 50);
            int say2 = rd.Next(0, 50);
            sonuç = say1 + say2;
            label1.Text = say1 + "+" + say2;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            abc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                string sorgu = "select*from tbl_Kayıt111 where kulanıcı=@user and şifre=@pass";
                con = new SqlConnection(sqlcon);
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass",Veritabanı.mdı5_şifreleme(textBox2.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    if (textBox3.Text == sonuç.ToString())
                    {

                        başarılı bş = new başarılı();
                        lazım = textBox1.Text;
                        lazım1 = textBox2.Text;
                        bş.Show();
                        this.Hide();
                    }
                    else
                    {
                        close cs = new close();
                        cs.Show();
                        abc();
                    }
                    
                }
                else
                {
                    close cs = new close();
                    cs.Show();
                    
                }
                con.Close();
            }if (radioButton2.Checked)
            {
                string sorg = "select*from tbl_Admin where kulanıcı=@user and Şifre=@pass";
                con = new SqlConnection(sqlcon);
                cmd = new SqlCommand(sorg, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", Veritabanı.mdı5_şifreleme(textBox2.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (textBox3.Text == sonuç.ToString())
                    {



                        MessageBox.Show("giriş başarılı!");

                    }
                    else
                    {
                        close cs = new close();
                        cs.Show();
                    }
                    
                }
                else
                {
                    close cs = new close();
                    cs.Show();
                }
                con.Close();
            }
            if(radioButton1.Checked==false && radioButton2.Checked==false)
            {
                MessageBox.Show("Lütfen Kullanıcı ya da Admin Basınız!");
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {

            Şifremi_Unuttum frm1 = new Şifremi_Unuttum();
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıt kay = new kayıt();
            this.Hide();
            kay.Show();


        }
    }
}
