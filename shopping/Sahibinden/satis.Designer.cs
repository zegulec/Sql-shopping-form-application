namespace Sahibinden
{
    partial class satis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnyeni = new System.Windows.Forms.Button();
            this.cbil = new System.Windows.Forms.ComboBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.dtilan = new System.Windows.Forms.DateTimePicker();
            this.tburun_id = new System.Windows.Forms.TextBox();
            this.tbfiyat = new System.Windows.Forms.TextBox();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tbozellik = new System.Windows.Forms.TextBox();
            this.tbaciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbbaslik = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbaranan = new System.Windows.Forms.TextBox();
            this.rbaciklama = new System.Windows.Forms.RadioButton();
            this.rbtur = new System.Windows.Forms.RadioButton();
            this.rbkategori = new System.Windows.Forms.RadioButton();
            this.rbil = new System.Windows.Forms.RadioButton();
            this.rbadres = new System.Windows.Forms.RadioButton();
            this.rbazalan = new System.Windows.Forms.RadioButton();
            this.rbartan = new System.Windows.Forms.RadioButton();
            this.rbyenieski = new System.Windows.Forms.RadioButton();
            this.rbilaneskiyeni = new System.Windows.Forms.RadioButton();
            this.rbilkbes = new System.Windows.Forms.RadioButton();
            this.tbgorsel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 243);
            this.dataGridView1.TabIndex = 117;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnyeni
            // 
            this.btnyeni.BackColor = System.Drawing.Color.RosyBrown;
            this.btnyeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyeni.Location = new System.Drawing.Point(360, 323);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(109, 50);
            this.btnyeni.TabIndex = 113;
            this.btnyeni.Text = "Satın Al";
            this.btnyeni.UseVisualStyleBackColor = false;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // cbil
            // 
            this.cbil.Enabled = false;
            this.cbil.FormattingEnabled = true;
            this.cbil.Location = new System.Drawing.Point(371, 176);
            this.cbil.Name = "cbil";
            this.cbil.Size = new System.Drawing.Size(100, 24);
            this.cbil.TabIndex = 110;
            this.cbil.Text = "Seçiniz";
            // 
            // cbkategori
            // 
            this.cbkategori.Enabled = false;
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(372, 138);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(100, 24);
            this.cbkategori.TabIndex = 111;
            this.cbkategori.Text = "Seçiniz";
            // 
            // dtilan
            // 
            this.dtilan.Enabled = false;
            this.dtilan.Location = new System.Drawing.Point(369, 214);
            this.dtilan.Name = "dtilan";
            this.dtilan.Size = new System.Drawing.Size(100, 22);
            this.dtilan.TabIndex = 108;
            // 
            // tburun_id
            // 
            this.tburun_id.Enabled = false;
            this.tburun_id.Location = new System.Drawing.Point(375, 30);
            this.tburun_id.Margin = new System.Windows.Forms.Padding(4);
            this.tburun_id.Name = "tburun_id";
            this.tburun_id.ReadOnly = true;
            this.tburun_id.Size = new System.Drawing.Size(100, 22);
            this.tburun_id.TabIndex = 106;
            // 
            // tbfiyat
            // 
            this.tbfiyat.Location = new System.Drawing.Point(369, 250);
            this.tbfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.tbfiyat.Name = "tbfiyat";
            this.tbfiyat.ReadOnly = true;
            this.tbfiyat.Size = new System.Drawing.Size(100, 22);
            this.tbfiyat.TabIndex = 107;
            // 
            // tbadres
            // 
            this.tbadres.Location = new System.Drawing.Point(145, 327);
            this.tbadres.Margin = new System.Windows.Forms.Padding(4);
            this.tbadres.Multiline = true;
            this.tbadres.Name = "tbadres";
            this.tbadres.ReadOnly = true;
            this.tbadres.Size = new System.Drawing.Size(100, 56);
            this.tbadres.TabIndex = 103;
            // 
            // tbozellik
            // 
            this.tbozellik.Location = new System.Drawing.Point(145, 258);
            this.tbozellik.Margin = new System.Windows.Forms.Padding(4);
            this.tbozellik.Multiline = true;
            this.tbozellik.Name = "tbozellik";
            this.tbozellik.ReadOnly = true;
            this.tbozellik.Size = new System.Drawing.Size(100, 56);
            this.tbozellik.TabIndex = 102;
            // 
            // tbaciklama
            // 
            this.tbaciklama.Location = new System.Drawing.Point(145, 189);
            this.tbaciklama.Margin = new System.Windows.Forms.Padding(4);
            this.tbaciklama.Multiline = true;
            this.tbaciklama.Name = "tbaciklama";
            this.tbaciklama.ReadOnly = true;
            this.tbaciklama.Size = new System.Drawing.Size(100, 56);
            this.tbaciklama.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(254, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "İl:";
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(374, 66);
            this.tbadi.Margin = new System.Windows.Forms.Padding(4);
            this.tbadi.Name = "tbadi";
            this.tbadi.ReadOnly = true;
            this.tbadi.Size = new System.Drawing.Size(100, 22);
            this.tbadi.TabIndex = 100;
            // 
            // tbbaslik
            // 
            this.tbbaslik.Location = new System.Drawing.Point(374, 102);
            this.tbbaslik.Margin = new System.Windows.Forms.Padding(4);
            this.tbbaslik.Name = "tbbaslik";
            this.tbbaslik.ReadOnly = true;
            this.tbbaslik.Size = new System.Drawing.Size(100, 22);
            this.tbbaslik.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(254, 143);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 94;
            this.label15.Text = "Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(252, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Fiyat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(23, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Özellikler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(252, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "İlan Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Açıklama :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(252, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Adı :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(254, 32);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 88;
            this.label18.Text = "Ürün Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Başlık :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbaranan);
            this.groupBox1.Controls.Add(this.rbaciklama);
            this.groupBox1.Controls.Add(this.rbtur);
            this.groupBox1.Controls.Add(this.rbkategori);
            this.groupBox1.Controls.Add(this.rbil);
            this.groupBox1.Controls.Add(this.rbadres);
            this.groupBox1.Controls.Add(this.rbazalan);
            this.groupBox1.Controls.Add(this.rbartan);
            this.groupBox1.Controls.Add(this.rbyenieski);
            this.groupBox1.Controls.Add(this.rbilaneskiyeni);
            this.groupBox1.Controls.Add(this.rbilkbes);
            this.groupBox1.Location = new System.Drawing.Point(544, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 332);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorgulama İşlemleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(240, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbaranan
            // 
            this.tbaranan.Location = new System.Drawing.Point(210, 21);
            this.tbaranan.Multiline = true;
            this.tbaranan.Name = "tbaranan";
            this.tbaranan.Size = new System.Drawing.Size(160, 59);
            this.tbaranan.TabIndex = 10;
            // 
            // rbaciklama
            // 
            this.rbaciklama.AutoSize = true;
            this.rbaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbaciklama.Location = new System.Drawing.Point(210, 198);
            this.rbaciklama.Name = "rbaciklama";
            this.rbaciklama.Size = new System.Drawing.Size(142, 22);
            this.rbaciklama.TabIndex = 3;
            this.rbaciklama.TabStop = true;
            this.rbaciklama.Text = "Açıklamaya Göre";
            this.rbaciklama.UseVisualStyleBackColor = true;
            // 
            // rbtur
            // 
            this.rbtur.AutoSize = true;
            this.rbtur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtur.Location = new System.Drawing.Point(210, 170);
            this.rbtur.Name = "rbtur";
            this.rbtur.Size = new System.Drawing.Size(97, 22);
            this.rbtur.TabIndex = 5;
            this.rbtur.TabStop = true;
            this.rbtur.Text = "Türe Göre";
            this.rbtur.UseVisualStyleBackColor = true;
            // 
            // rbkategori
            // 
            this.rbkategori.AutoSize = true;
            this.rbkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbkategori.Location = new System.Drawing.Point(210, 142);
            this.rbkategori.Name = "rbkategori";
            this.rbkategori.Size = new System.Drawing.Size(137, 22);
            this.rbkategori.TabIndex = 7;
            this.rbkategori.TabStop = true;
            this.rbkategori.Text = "Kategoriye Göre";
            this.rbkategori.UseVisualStyleBackColor = true;
            // 
            // rbil
            // 
            this.rbil.AutoSize = true;
            this.rbil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbil.Location = new System.Drawing.Point(210, 114);
            this.rbil.Name = "rbil";
            this.rbil.Size = new System.Drawing.Size(81, 22);
            this.rbil.TabIndex = 8;
            this.rbil.TabStop = true;
            this.rbil.Text = "İle Göre";
            this.rbil.UseVisualStyleBackColor = true;
            // 
            // rbadres
            // 
            this.rbadres.AutoSize = true;
            this.rbadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbadres.Location = new System.Drawing.Point(210, 86);
            this.rbadres.Name = "rbadres";
            this.rbadres.Size = new System.Drawing.Size(113, 22);
            this.rbadres.TabIndex = 9;
            this.rbadres.TabStop = true;
            this.rbadres.Text = "Adrese Göre";
            this.rbadres.UseVisualStyleBackColor = true;
            // 
            // rbazalan
            // 
            this.rbazalan.AutoSize = true;
            this.rbazalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbazalan.Location = new System.Drawing.Point(6, 140);
            this.rbazalan.Name = "rbazalan";
            this.rbazalan.Size = new System.Drawing.Size(108, 22);
            this.rbazalan.TabIndex = 0;
            this.rbazalan.TabStop = true;
            this.rbazalan.Text = "Fiyat Azalan";
            this.rbazalan.UseVisualStyleBackColor = true;
            // 
            // rbartan
            // 
            this.rbartan.AutoSize = true;
            this.rbartan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbartan.Location = new System.Drawing.Point(6, 113);
            this.rbartan.Name = "rbartan";
            this.rbartan.Size = new System.Drawing.Size(98, 22);
            this.rbartan.TabIndex = 0;
            this.rbartan.TabStop = true;
            this.rbartan.Text = "Fiyat Artan";
            this.rbartan.UseVisualStyleBackColor = true;
            // 
            // rbyenieski
            // 
            this.rbyenieski.AutoSize = true;
            this.rbyenieski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbyenieski.Location = new System.Drawing.Point(6, 86);
            this.rbyenieski.Name = "rbyenieski";
            this.rbyenieski.Size = new System.Drawing.Size(170, 22);
            this.rbyenieski.TabIndex = 0;
            this.rbyenieski.TabStop = true;
            this.rbyenieski.Text = "Yeniden Eskiye Sırala";
            this.rbyenieski.UseVisualStyleBackColor = true;
            // 
            // rbilaneskiyeni
            // 
            this.rbilaneskiyeni.AutoSize = true;
            this.rbilaneskiyeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbilaneskiyeni.Location = new System.Drawing.Point(6, 59);
            this.rbilaneskiyeni.Name = "rbilaneskiyeni";
            this.rbilaneskiyeni.Size = new System.Drawing.Size(170, 22);
            this.rbilaneskiyeni.TabIndex = 0;
            this.rbilaneskiyeni.TabStop = true;
            this.rbilaneskiyeni.Text = "Eskiden Yeniye Sırala";
            this.rbilaneskiyeni.UseVisualStyleBackColor = true;
            // 
            // rbilkbes
            // 
            this.rbilkbes.AutoSize = true;
            this.rbilkbes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbilkbes.Location = new System.Drawing.Point(6, 32);
            this.rbilkbes.Name = "rbilkbes";
            this.rbilkbes.Size = new System.Drawing.Size(91, 22);
            this.rbilkbes.TabIndex = 0;
            this.rbilkbes.TabStop = true;
            this.rbilkbes.Text = "İlk 5 Kayıt";
            this.rbilkbes.UseVisualStyleBackColor = true;
            // 
            // tbgorsel
            // 
            this.tbgorsel.Location = new System.Drawing.Point(369, 286);
            this.tbgorsel.Margin = new System.Windows.Forms.Padding(4);
            this.tbgorsel.Name = "tbgorsel";
            this.tbgorsel.ReadOnly = true;
            this.tbgorsel.Size = new System.Drawing.Size(100, 22);
            this.tbgorsel.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(252, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 93;
            this.label9.Text = "Gorsel :";
            // 
            // satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1050, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.cbil);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.dtilan);
            this.Controls.Add(this.tburun_id);
            this.Controls.Add(this.tbfiyat);
            this.Controls.Add(this.tbadres);
            this.Controls.Add(this.tbozellik);
            this.Controls.Add(this.tbaciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbadi);
            this.Controls.Add(this.tbgorsel);
            this.Controls.Add(this.tbbaslik);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Name = "satis";
            this.Text = "satis";
            this.Load += new System.EventHandler(this.satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.ComboBox cbil;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.DateTimePicker dtilan;
        private System.Windows.Forms.TextBox tburun_id;
        private System.Windows.Forms.TextBox tbfiyat;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbozellik;
        private System.Windows.Forms.TextBox tbaciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbbaslik;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbaranan;
        private System.Windows.Forms.RadioButton rbaciklama;
        private System.Windows.Forms.RadioButton rbtur;
        private System.Windows.Forms.RadioButton rbkategori;
        private System.Windows.Forms.RadioButton rbil;
        private System.Windows.Forms.RadioButton rbadres;
        private System.Windows.Forms.RadioButton rbazalan;
        private System.Windows.Forms.RadioButton rbartan;
        private System.Windows.Forms.RadioButton rbyenieski;
        private System.Windows.Forms.RadioButton rbilaneskiyeni;
        private System.Windows.Forms.RadioButton rbilkbes;
        private System.Windows.Forms.TextBox tbgorsel;
        private System.Windows.Forms.Label label9;
    }
}