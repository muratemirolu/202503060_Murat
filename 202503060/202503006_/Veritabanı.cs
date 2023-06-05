using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503006_
{
    class Veritabanı
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;

        public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";


        public static string güncelle(string x)
        {
            SqlConnection con = new SqlConnection(sqlcon);
           
            SqlCommand cmd = new SqlCommand();
          
           // cmd.Parameters.AddWithValue("@pass", );
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = x;
            cmd.ExecuteNonQuery();
            con.Close();
            return " ";
           
        }
        public static string doldur()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_Kayıt111", sqlcon);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_Kayıt111");
            //dataGridView1.DataSource = ds.Tables["tlf_login"];
            con.Close();
            return " ";
        }

        public static string mdı5_şifreleme(string x)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(x);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();


        }
      
      

        public static string sil(string sorgu,string a)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            string sil = "delete from "+sorgu+" where Model=@model ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@model", a);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sil;
            cmd.ExecuteNonQuery();
            con.Close();

            return " ";
        }
        public static string kişisil(string sorgu,string a)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            string sili = "delete from " + sorgu + " where TC=@tc ";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@tc", a);
           // cmd.Parameters.AddWithValue("@kul", b);
           // cmd.Parameters.AddWithValue("@şif", c);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sili;
            cmd.ExecuteNonQuery();
            con.Close();


            return " ";
        }

        public static  DataGridView datGRİDDOLDUR(DataGridView gridim,string sorgu)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter da = new SqlDataAdapter("select  * from "+ sorgu ,sqlcon);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, sorgu);
            gridim.DataSource = ds.Tables[sorgu];
            con.Close();

            return gridim;
        }
        int x = 0;
        public static string Satiş(string ekle, string a, string b, string c, string d,string e,string n)
        {
           
            SqlConnection con = new SqlConnection(sqlcon);
             string eklee = "insert into "+ ekle +" (Kullanıcı,Marka,Model,Fiyatı,Özellikleri,Resmi) values (@user,@marka,@model,@fiyat,@öz,@resim)";
            SqlCommand cmd = new SqlCommand();
        
            cmd.Parameters.AddWithValue("@user", a);
            cmd.Parameters.AddWithValue("@marka", b);
            cmd.Parameters.AddWithValue("@model", c);
            cmd.Parameters.AddWithValue("@fiyat", d);
            cmd.Parameters.AddWithValue("@öz", e);
            cmd.Parameters.AddWithValue("@resim", n);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = eklee;
            cmd.ExecuteNonQuery();
            con.Close();



            return " ";

        }
    }
}
