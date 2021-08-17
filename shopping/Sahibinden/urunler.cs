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
    public partial class urunler : Form
    {
        BindingSource bs = new BindingSource();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9EIMPI8\\SQLEXPRESS;Initial Catalog=Sahibinden;Integrated Security=True");
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        string kimden = giris.kimden;
        public urunler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbaciklama.Text = "";
            tbadres.Text = "";
            tbbaslik.Text = "";
            tbfiyat.Text = "";
            tbgorsel.Text = "";
            tbozellik.Text = "";
            tbtc.Text = "";
            tbadi.Text = "";
            tburun_id.Text = "";
            cbil.SelectedIndex = -1;
            cbkategori.SelectedIndex = -1;
            tbadi.Focus();
        }
        void VerileriCek()
        {
            baglanti.Open();
            string sorgu = "Select * from urun where durum='False' and kimden='"+kimden+"'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            ds.Clear();
            da.Fill(ds, "urun");
            bs.DataSource = ds.Tables["urun"];
            baglanti.Close();
        }

        private void urunler_Load(object sender, EventArgs e)
        {
            VerileriCek();
            dataGridView1.DataSource = bs;
            tburun_id.DataBindings.Add("Text", bs, "urun_id");
            tbadi.DataBindings.Add("Text", bs, "urun_adi");
            tbbaslik.DataBindings.Add("Text", bs, "urun_baslik");
            tbaciklama.DataBindings.Add("Text", bs, "urun_aciklama");
            tbozellik.DataBindings.Add("Text", bs, "urun_ozellik"); 
            tbfiyat.DataBindings.Add("Text", bs, "urun_fiyat");
            tbgorsel.DataBindings.Add("Text", bs, "urun_gorsel");
            dtilan.DataBindings.Add("Text", bs, "ilan_tarihi");
            tbtc.DataBindings.Add("Text", bs, "kimden");
            cbkategori.DataBindings.Add("Text", bs, "kategori_id");
            tbadres.DataBindings.Add("Text", bs, "nerden");
            cbil.DataBindings.Add("Text", bs, "il");

                string seckomutu2 = "select * from kategoriler";
                SqlDataAdapter da = new SqlDataAdapter(seckomutu2, baglanti);
                da.SelectCommand.CommandText = seckomutu2;
                if (ds2.Tables["kategoriler"] != null)
                    ds2.Tables["kategoriler"].Clear();
                da.Fill(ds2, "kategoriler");
                cbkategori.DataSource = ds2.Tables["kategoriler"];
                cbkategori.ValueMember = "kategori_id";
                cbkategori.DisplayMember = "kategori_adi";
            
                

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
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            int fiyat = int.Parse(tbfiyat.Text);
            string durum = "False";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "INSERT INTO urun (urun_adi,urun_baslik,urun_aciklama,urun_ozellik,urun_fiyat,urun_gorsel,ilan_tarihi,kimden,durum,kategori_id,nerden,il) VALUES (@urun_adi,@urun_baslik,@urun_aciklama,@urun_ozellik,@urun_fiyat,@urun_gorsel,@ilan_tarihi,@kimden,@durum,@kategori_id,@nerden,@il)";
            cmd.Parameters.AddWithValue("@urun_adi", tbadi.Text);
            cmd.Parameters.AddWithValue("@urun_baslik", tbbaslik.Text);
            cmd.Parameters.AddWithValue("@urun_aciklama", tbaciklama.Text);
            cmd.Parameters.AddWithValue("@urun_ozellik", tbozellik.Text);
            cmd.Parameters.AddWithValue("@urun_fiyat", fiyat);
            cmd.Parameters.AddWithValue("@urun_gorsel", tbgorsel.Text);
            cmd.Parameters.AddWithValue("@ilan_tarihi", dtilan.Value);
            cmd.Parameters.AddWithValue("@kimden", tbtc.Text);
            cmd.Parameters.AddWithValue("@durum", durum);
            cmd.Parameters.AddWithValue("@kategori_id", cbkategori.SelectedValue);
            cmd.Parameters.AddWithValue("@nerden", tbadres.Text);
            cmd.Parameters.AddWithValue("@il", cbil.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            VerileriCek();
            MessageBox.Show("Kayıt Oluşturuldu");
           
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ResimSec = new OpenFileDialog();
            ResimSec.Filter = "Resim Dosyaları |*.jpg;*.png;*.gif|Tüm Dosyalar|*.*";
            if (ResimSec.ShowDialog() == DialogResult.OK)
            {
                string Resim = ResimSec.FileName;
                tbgorsel.Text = Resim;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int fiyat = int.Parse(tbfiyat.Text);
            string durum = "False";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand( "Update urun Set urun_adi=@urun_adi,urun_baslik=@urun_baslik,urun_aciklama=@urun_aciklama,urun_ozellik=@urun_ozellik,urun_fiyat=@urun_fiyat,urun_gorsel=@urun_gorsel,ilan_tarihi=@ilan_tarihi,kimden=@kimden,durum=@durum,kategori_id=@kategori_id,nerden=@nerden,il=@il where urun_id=@urun_id ",baglanti);
            cmd.Connection = baglanti;  
            cmd.Parameters.AddWithValue("@urun_adi", tbadi.Text);
            cmd.Parameters.AddWithValue("@urun_baslik", tbbaslik.Text);
            cmd.Parameters.AddWithValue("@urun_aciklama", tbaciklama.Text);
            cmd.Parameters.AddWithValue("@urun_ozellik", tbozellik.Text);
            cmd.Parameters.AddWithValue("@urun_fiyat", fiyat);
            cmd.Parameters.AddWithValue("@urun_gorsel", tbgorsel.Text);
            cmd.Parameters.AddWithValue("@ilan_tarihi", dtilan.Value);
            cmd.Parameters.AddWithValue("@kimden", tbtc.Text);
            cmd.Parameters.AddWithValue("@durum", durum);
            cmd.Parameters.AddWithValue("@nerden", tbadres.Text);
            cmd.Parameters.AddWithValue("@il", cbil.Text);
            cmd.Parameters.AddWithValue("@urun_id", tburun_id.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            VerileriCek();
            MessageBox.Show("Kayıt Güncellendi....");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete from urun where urun_id=@urun_id", baglanti);
            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@urun_id", tburun_id.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            VerileriCek();
            MessageBox.Show("Kayıt Silindi....");
        }
    }
}
