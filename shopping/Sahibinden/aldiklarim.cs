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
    public partial class aldiklarim : Form
    {

        BindingSource bs = new BindingSource();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9EIMPI8\\SQLEXPRESS;Initial Catalog=Sahibinden;Integrated Security=True");
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        string kimden = giris.kimden;
        public aldiklarim()
        {
            InitializeComponent();
        }
        void VerileriCek()
        {
            baglanti.Open();
            string sorgu = "Select satislar.urun_id,urun.urun_fiyat,urun.urun_adi,urun.urun_baslik,urun.urun_aciklama,urun.urun_ozellik,urun.urun_gorsel,urun.ilan_tarihi from satislar inner join urun on satislar.urun_id=urun.urun_id where satislar.musteri='"+kimden+"'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            ds.Clear();
            da.Fill(ds, "satislar");
            bs.DataSource = ds.Tables["satislar"];
            dataGridView1.DataSource = bs;
            baglanti.Close();
        }
        private void aldiklarim_Load(object sender, EventArgs e)
        {
            VerileriCek();
            tburun_id.DataBindings.Add("Text", bs, "urun_id");
            tbadi.DataBindings.Add("Text", bs, "urun_adi");
            tbbaslik.DataBindings.Add("Text", bs, "urun_baslik");
            tbaciklama.DataBindings.Add("Text", bs, "urun_aciklama");
            tbozellik.DataBindings.Add("Text", bs, "urun_ozellik");
            tbfiyat.DataBindings.Add("Text", bs, "urun_fiyat");
            tbgorsel.DataBindings.Add("Text", bs, "urun_gorsel");
            dtilan.DataBindings.Add("Text", bs, "ilan_tarihi");

            string seckomutu2 = "select * from kategoriler";
            SqlDataAdapter da = new SqlDataAdapter(seckomutu2, baglanti);
            da.SelectCommand.CommandText = seckomutu2;
            if (ds2.Tables["kategoriler"] != null)
                ds2.Tables["kategoriler"].Clear();
            da.Fill(ds2, "kategoriler");
            cbkategori.DataSource = ds2.Tables["kategoriler"];
            cbkategori.ValueMember = "kategori_id";
            cbkategori.DisplayMember = "kategori_adi";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(tbgorsel.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbilkbes.Checked)
            {
                baglanti.Open();
                string sorgu = "Select TOP(5) satislar.urun_id,urun.urun_fiyat,urun.urun_adi,urun.urun_baslik,urun.urun_aciklama,urun.urun_ozellik,urun.urun_gorsel,urun.ilan_tarihi from satislar inner join urun on satislar.urun_id=urun.urun_id where satislar.musteri='" + kimden + "' ORDER BY satislar.satis_id"; 
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "satislar");
                bs.DataSource = ds.Tables["satislar"];
                baglanti.Close();
            }
            else if (rbilaneskiyeni.Checked)
            {
                baglanti.Open();
                string sorgu = "Select satislar.urun_id,urun.urun_fiyat,urun.urun_adi,urun.urun_baslik,urun.urun_aciklama,urun.urun_ozellik,urun.urun_gorsel,urun.ilan_tarihi from satislar inner join urun on satislar.urun_id=urun.urun_id where satislar.musteri='" + kimden + "'ORDER BY ilan_tarihi";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "satislar");
                bs.DataSource = ds.Tables["satislar"];
                baglanti.Close();
            }
            else if (rbyenieski.Checked)
            {
                baglanti.Open();
                string sorgu = "Select satislar.urun_id,urun.urun_fiyat,urun.urun_adi,urun.urun_baslik,urun.urun_aciklama,urun.urun_ozellik,urun.urun_gorsel,urun.ilan_tarihi from satislar inner join urun on satislar.urun_id=urun.urun_id where satislar.musteri='" + kimden + "'ORDER BY ilan_tarihi Desc";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "satislar");
                bs.DataSource = ds.Tables["satislar"];
                baglanti.Close();
            }
            else if (rbartan.Checked)
            {
                baglanti.Open();
                string sorgu = "Select satislar.urun_id,urun.urun_fiyat,urun.urun_adi,urun.urun_baslik,urun.urun_aciklama,urun.urun_ozellik,urun.urun_gorsel,urun.ilan_tarihi from satislar inner join urun on satislar.urun_id=urun.urun_id where satislar.musteri='" + kimden + "'ORDER BY urun.urun_fiyat ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "satislar");
                bs.DataSource = ds.Tables["satislar"];
                baglanti.Close();
            }
            else if (rbazalan.Checked)
            {
                baglanti.Open();
                string sorgu = "Select satislar.urun_id,urun.urun_fiyat,urun.urun_adi,urun.urun_baslik,urun.urun_aciklama,urun.urun_ozellik,urun.urun_gorsel,urun.ilan_tarihi from satislar inner join urun on satislar.urun_id=urun.urun_id where satislar.musteri='" + kimden + "'ORDER BY urun.urun_fiyat Desc ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "satislar");
                bs.DataSource = ds.Tables["satislar"];
                baglanti.Close();
            }
            else if (rbkategori.Checked)
            {
                baglanti.Open();
                string sorgu = "Select satislar.urun_id,urun.urun_fiyat,urun.urun_adi,urun.urun_baslik,urun.urun_aciklama,urun.urun_ozellik,urun.urun_gorsel,urun.ilan_tarihi from satislar inner join urun on satislar.urun_id=urun.urun_id where satislar.musteri='" + kimden + "' and urun.kategori_id="+cbkategori.SelectedValue;
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "satislar");
                bs.DataSource = ds.Tables["satislar"];
                baglanti.Close();
            }
        }
    }
}
