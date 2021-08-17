using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sahibinden
{
    public partial class giris : Form
    {
        static public string kimden;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9EIMPI8\\SQLEXPRESS;Initial Catalog=Sahibinden;Integrated Security=True");
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbtc.Text == "" && tbsifre.Text == "")
            {
                MessageBox.Show("Lütfen Giriş Bilgilerini Yazın!");
            }
            else if (tbtc.Text == "")
            {
                MessageBox.Show("Kullanıcı Adını Giriniz.");
            }
            else if (tbsifre.Text == "")
            {
                MessageBox.Show("Şifrenizi Giriniz.");
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from musteriler where tc_kimlik='" + tbtc.Text.ToString() + "'", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    if (tbtc.Text.ToString() == dr["tc_kimlik"].ToString() && tbsifre.Text.ToString() == dr["sifre"].ToString())
                    {
                        kimden = tbtc.Text;
                        secim sat = new secim();
                        sat.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tc kimlik No veya şifre yanlıştır.");
                        tbtc.Clear(); tbsifre.Clear();
                    }
                }

                else
                {
                    MessageBox.Show("Tc Kimlik No  veya şifre yanlıştır.");
                    tbtc.Clear(); tbsifre.Clear();
                }
                baglanti.Close();
            }
        }
    }
}
