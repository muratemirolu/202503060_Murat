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
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TELEFON_EKLE_CIKART tel = new TELEFON_EKLE_CIKART();
            this.Hide();
            tel.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Toplam_Satış ş = new Toplam_Satış();
            this.Hide();
            ş.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Yönetici_Load(object sender, EventArgs e)
        {

        }
    }
}
