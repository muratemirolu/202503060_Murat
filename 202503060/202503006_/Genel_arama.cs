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
    public partial class Genel_arama : Form
    {
        public Genel_arama()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        //public static string sqlcon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";

        public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";
        public string sorgu;
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {

                if(radioButton4.Checked)
                {
                   if(radioButton5.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Kullanıcı like '%" + textBox1.Text + "%' order by Kullanıcı ASC ";
                       Veritabanı.datGRİDDOLDUR(dataGridView1,sorgu);
                    }
                   else if(radioButton6.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Kullanıcı like '%" + textBox1.Text + "%' order by Kullanıcı DESC ";
                        Veritabanı.datGRİDDOLDUR(dataGridView1, sorgu);
                    }
                }
                else if(radioButton1.Checked)
                {
                    if (radioButton5.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Marka like '%" + textBox1.Text + "%' order by Kullanıcı ASC ";
                        Veritabanı.datGRİDDOLDUR(dataGridView1, sorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Marka like '%" + textBox1.Text + "%' order by Kullanıcı DESC ";
                        Veritabanı.datGRİDDOLDUR(dataGridView1, sorgu);
                    }

                }
                else if(radioButton2.Checked)
                {
                    if (radioButton5.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Model like '%" + textBox1.Text + "%' order by Kullanıcı ASC ";
                        Veritabanı.datGRİDDOLDUR(dataGridView1, sorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Model like '%" + textBox1.Text + "%' order by Kullanıcı DESC ";
                        Veritabanı.datGRİDDOLDUR(dataGridView1, sorgu);
                    }
                }
                else if(radioButton3.Checked)
                {
                    if (radioButton5.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Fiyatı between " + textBox1.Text + "*0.9 AND "+ textBox1.Text+"*1.1 ORDER BY Fiyatı ASC " ;
                        Veritabanı.datGRİDDOLDUR(dataGridView1, sorgu);
                    }
                    else if (radioButton6.Checked)
                    {
                        sorgu = "select * from tbl_Satış where Fiyatı between " + textBox1.Text + "*0.9 AND " + textBox1.Text + "*1.1 ORDER BY Fiyatı DESC ";
                        Veritabanı.datGRİDDOLDUR(dataGridView1, sorgu);
                    }
                }
                

            }
        }

        private void Genel_arama_Load(object sender, EventArgs e)
        {

        }
    }
}
