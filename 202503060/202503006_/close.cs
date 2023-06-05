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
    public partial class close : Form
    {
        public close()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval==2000)
            {
                timer1.Stop();
                close cos = new close();
                this.Hide();
                cos.Close();
            }
        }

        private void close_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 2000;

        }
    }
}
