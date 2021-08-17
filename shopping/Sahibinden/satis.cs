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
using System.Drawing.Imaging;
using System.IO;
namespace Sahibinden
{
    public partial class satis : Form
    {
        BindingSource bs = new BindingSource();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9EIMPI8\\SQLEXPRESS;Initial Catalog=Sahibinden;Integrated Security=True");
        DataSet ds = new DataSet();
        string kimden = giris.kimden;
        public satis()
        {
            InitializeComponent();
        }
        void VerileriCek()
        {
            baglanti.Open();
            string sorgu = "Select * from urun where durum='False'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            ds.Clear();
            da.Fill(ds, "urun");
            bs.DataSource = ds.Tables["urun"];
            baglanti.Close();
        }
        private void satis_Load(object sender, EventArgs e)
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
            cbkategori.DataBindings.Add("Text", bs, "kategori_id");
            tbadres.DataBindings.Add("Text", bs, "nerden");
            cbil.DataBindings.Add("Text", bs, "il");
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(tbgorsel.Text);
        }
        
        private void btnyeni_Click(object sender, EventArgs e)
        {

            string durum = "True";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = ("UPDATE urun SET durum=@durum where urun_id=@urun_id");
            cmd.Parameters.AddWithValue("@durum", durum);
            cmd.Parameters.AddWithValue("@urun_id", tburun_id.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
         
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = baglanti;
            cmd1.CommandText = "INSERT INTO satislar (urun_id,musteri) Values (@urun_id,@musteri)";
            cmd1.Parameters.AddWithValue("@urun_id", tburun_id.Text);
            cmd1.Parameters.AddWithValue("@musteri", kimden);
            cmd1.ExecuteNonQuery();
            baglanti.Close();
            VerileriCek();
            MessageBox.Show("Ürün Satıldı");
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(rbilkbes.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT TOP(5) * FROM urun where durum='False' ORDER BY urun_id ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if(rbilaneskiyeni.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' ORDER BY ilan_tarihi  ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if(rbyenieski.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' ORDER BY ilan_tarihi Desc  ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if (rbartan.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' ORDER BY urun_fiyat   ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if (rbazalan.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' ORDER BY urun_fiyat Desc  ";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if (rbadres.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' and nerden Like '%"+tbaranan.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if (rbil.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' and il Like '%" + tbaranan.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }

            else if (rbkategori.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' and kategori_id=(select kategori_id from kategoriler where kategori_adi Like '%"+tbaranan.Text+"%' )";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if (rbtur.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' and urun_adi Like '%" + tbaranan.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }
            else if (rbaciklama.Checked)
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM urun where durum='False' and urun_aciklama Like '%" + tbaranan.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                ds.Clear();
                da.Fill(ds, "urun");
                bs.DataSource = ds.Tables["urun"];
                baglanti.Close();
            }

        }
    }
}
