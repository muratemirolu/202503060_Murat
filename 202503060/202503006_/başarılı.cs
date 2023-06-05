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
    public partial class başarılı : Form
    {
        public başarılı()
        {
            InitializeComponent();
        }

        private void başarılı_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 2000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval==2000)
            {
                timer1.Stop();
                Form2  kul = new Form2();
                this.Hide();
                kul.Show();

            }
        }
    }
}
