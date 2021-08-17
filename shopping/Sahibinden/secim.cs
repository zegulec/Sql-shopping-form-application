using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahibinden
{
    public partial class secim : Form
    {
        public secim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satis st = new satis();
            st.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunler ur = new urunler();
            ur.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aldiklarim a = new aldiklarim();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sattiklarim s = new sattiklarim();
            s.ShowDialog();
        }
    }
}
