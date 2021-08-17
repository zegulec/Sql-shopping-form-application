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
    public partial class baslangic : Form
    {
        public baslangic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admingiris ag = new admingiris();
            ag.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanicisecim g = new kullanicisecim();
            g.Show();
            this.Hide();
        }
    }
}
