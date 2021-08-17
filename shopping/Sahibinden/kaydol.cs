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
    public partial class kaydol : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9EIMPI8\\SQLEXPRESS;Initial Catalog=Sahibinden;Integrated Security=True");
       
        public kaydol()
        {
            InitializeComponent();
        }

        private void kaydol_Load(object sender, EventArgs e)
        {
            cbil.Items.Clear();
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "Select * from iller";
            komut2.Connection = baglanti;
            komut2.CommandType = CommandType.Text;
            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cbil.Items.Add(dr2["il"]);
            }
            baglanti.Close();
            tbtc.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandText = "Insert Into musteriler (tc_kimlik,adi,soyadi,dogum_yeri,dogum_tarihi,mail,telefon,il,ev_adresi,sifre) Values(@tc_kimlik,@adi,@soyadi,@dogum_yeri,@dogum_tarihi,@mail,@telefon,@il,@ev_adresi,@sifre)";
            ekle.Parameters.AddWithValue("@tc_kimlik", tbtc.Text);
            ekle.Parameters.AddWithValue("@adi", tbad.Text);
            ekle.Parameters.AddWithValue("@soyadi", tbsoyad.Text);
            ekle.Parameters.AddWithValue("@dogum_yeri", tbdogum_yeri.Text);
            ekle.Parameters.AddWithValue("@dogum_tarihi", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@mail", tbmail.Text);
            ekle.Parameters.AddWithValue("@telefon", tbtelefon.Text);
            ekle.Parameters.AddWithValue("@il", cbil.Text);
            ekle.Parameters.AddWithValue("@ev_adresi", tbadres.Text);
            ekle.Parameters.AddWithValue("@sifre", tbsifre.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarılı Bir Şekilde Kayıt Oluşturuldu...");
            giris g = new giris();
            g.Show();
            this.Hide();

        }
    }
}
