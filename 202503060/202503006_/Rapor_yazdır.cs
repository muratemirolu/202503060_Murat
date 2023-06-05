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
    public partial class Rapor_yazdır : Form
    {
        public Rapor_yazdır()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        public static string sqlcon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";

        // public static string sqlcon = @"Data Source=DESKTOP-AENF83D\SQLEXPRESS;Initial Catalog=TLF;Integrated Security=True";

        public void raporyaz(string sql)
        {
            con = new SqlConnection(sqlcon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            CrystalReport21.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = CrystalReport21;
            con.Close();
        }

        private void Rapor_yazdır_Load(object sender, EventArgs e)
        {
            raporyaz("select * from tbl_Satış");
        }
    }
}
