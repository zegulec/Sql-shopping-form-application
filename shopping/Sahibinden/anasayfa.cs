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
    public partial class anasayfa : Form
    {

        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();
        BindingSource bs1 = new BindingSource();

        BindingSource bs3 = new BindingSource();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9EIMPI8\\SQLEXPRESS;Initial Catalog=Sahibinden;Integrated Security=True");
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        string kimden = giris.kimden;
        public anasayfa()
        {
            InitializeComponent();
        }
        void VerileriCek()
        {
            baglanti.Open();
            string sorgu = "Select * from urun ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            ds.Clear();
            da.Fill(ds, "urun");
            bs.DataSource = ds.Tables["urun"];
            baglanti.Close();
        }
        void VerileriCek2()
        {
            baglanti.Open();
            string sorgu1 = "Select * from musteriler";
            SqlDataAdapter da1 = new SqlDataAdapter(sorgu1, baglanti);
            ds1.Clear();
            da1.Fill(ds1, "musteriler");
            bs1.DataSource = ds1.Tables["musteriler"];
            baglanti.Close();
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
            VerileriCek();
            dataGridView1.DataSource = bs;
            lburun_id.DataBindings.Add("Text", bs, "urun_id");
            lburun_adi.DataBindings.Add("Text", bs, "urun_adi");
            lburun_baslik.DataBindings.Add("Text", bs, "urun_baslik");
            lburun_aciklama.DataBindings.Add("Text", bs, "urun_aciklama");
            lburun_ozellik.DataBindings.Add("Text", bs, "urun_ozellik");
            lburun_fiyat.DataBindings.Add("Text", bs, "urun_fiyat");
            lburun_gorsel.DataBindings.Add("Text", bs, "urun_gorsel");
            lbilan_tarihi.DataBindings.Add("Text", bs, "ilan_tarihi");
            lbkimden.DataBindings.Add("Text", bs, "kimden");
            lbdurum.DataBindings.Add("Text", bs, "durum");
            tbkategori.DataBindings.Add("Text", bs, "kategori_id");
            lbnerden.DataBindings.Add("Text", bs, "nerden");
            lbil.DataBindings.Add("Text", bs, "il");
            VerileriCek2();
            dataGridView2.DataSource = bs1;
            lbtc_kimlik.DataBindings.Add("Text", bs1, "tc_kimlik");
            lbadi.DataBindings.Add("Text", bs1, "adi");
            lbsoyadi.DataBindings.Add("Text", bs1, "soyadi");
            ldogum_yeri.DataBindings.Add("Text", bs1, "dogum_yeri");
            lbdogum_tarihi.DataBindings.Add("Text", bs1, "dogum_tarihi");
            lbmail.DataBindings.Add("Text", bs1, "mail");
            lbtelefon.DataBindings.Add("Text", bs1, "telefon");
            lbmusteri_il.DataBindings.Add("Text", bs1, "il");
            lbmusteriadres.DataBindings.Add("Text", bs1, "ev_adresi");

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(lburun_gorsel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbyuksekfiyatasatilan.Checked)
            {
                baglanti.Open();
                string sorgu = "select*from urun inner join satislar on urun.urun_id=satislar.urun_id where urun.urun_fiyat>=ANY(Select Max(urun_fiyat) from urun where durum='True')and durum='True'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                dataGridView1.DataSource = bs;
                baglanti.Close();
            }
            if (rbendusuk.Checked)
            {
                baglanti.Open();
                string sorgu = "select*from urun inner join satislar on urun.urun_id=satislar.urun_id where urun.urun_fiyat<=ANY(Select Min(urun_fiyat) from urun where durum='True') and durum='True'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                dataGridView1.DataSource = bs;
                baglanti.Close();
            }
            if (rbhicurunsatmayan.Checked)
            {
                baglanti.Open();
                string sorgu = "select * from musteriler where tc_kimlik not in(select kimden from urun where urun_id not in(select urun.urun_id from urun inner join satislar on urun.urun_id=satislar.urun_id))";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds1.Clear();
                da.Fill(ds1, "musteriler");
                bs1.DataSource = ds1.Tables["musteriler"];
                dataGridView2.DataSource = bs1;
                baglanti.Close();
            }
            if (rbhicurunsatilmayanil.Checked)
            {
                baglanti.Open();
                string sorgu = "select * from iller where il not in(select il from musteriler where il not in(select il from urun where urun_id not in(select urun.urun_id from urun inner join satislar on urun.urun_id=satislar.urun_id)))";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds2.Clear();
                da.Fill(ds2, "musteriler");
                bs2.DataSource = ds2.Tables["musteriler"];
                dataGridView2.DataSource = bs2;
                baglanti.Close();
            }
            if (rbencokurunsatan.Checked)
            {
                baglanti.Open();
                string sorgu = "select * from musteriler where tc_kimlik=(select kimden from urun inner join satislar on urun.urun_id=satislar.urun_id Group by kimden having Count(kimden)>=(select Count(kimden) from urun inner join satislar on urun.urun_id=satislar.urun_id ))  ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds1.Clear();
                da.Fill(ds1, "musteriler");
                bs1.DataSource = ds1.Tables["musteriler"];
                dataGridView2.DataSource = bs1;
                baglanti.Close();
            }
            if (rbilleregoreortsatıs.Checked)
            {
                baglanti.Open();
                string sorgu = "Select urun.il,Avg(urun_fiyat) from urun inner join satislar on urun.urun_id=satislar.urun_id group by urun.il";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds3.Clear();
                da.Fill(ds3, "musteriler");
                bs3.DataSource = ds3.Tables["musteriler"];
                dataGridView2.DataSource = bs3;
                baglanti.Close();
            }
            if (rbkategoriadet.Checked)
            {
                baglanti.Open();
                string sorgu = "select kategoriler.kategori_adi,Count(urun.kategori_id) from urun inner join kategoriler on urun.kategori_id=kategoriler.kategori_id inner join satislar on  urun.urun_id=satislar.urun_id group by kategoriler.kategori_adi";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds2.Clear();
                da.Fill(ds2, "musteriler");
                bs2.DataSource = ds2.Tables["musteriler"];
                dataGridView2.DataSource = bs2;
                baglanti.Close();
            }
            if (rbhicalmayan.Checked)
            {
                baglanti.Open();
                string sorgu = "select * from musteriler Where tc_kimlik not in(select musteri from satislar ) ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds1.Clear();
                da.Fill(ds1, "musteriler");
                bs1.DataSource = ds1.Tables["musteriler"];
                dataGridView2.DataSource = bs1;
                baglanti.Close();
            }
        }
    }
}
