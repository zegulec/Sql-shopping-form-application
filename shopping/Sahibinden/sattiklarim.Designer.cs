namespace Sahibinden
{
    partial class sattiklarim
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
            this.rbilaneskiyeni = new System.Windows.Forms.RadioButton();
            this.dtilan = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rborty = new System.Windows.Forms.RadioButton();
            this.rbazalan = new System.Windows.Forms.RadioButton();
            this.rbfiyatortalama = new System.Windows.Forms.RadioButton();
            this.rbartan = new System.Windows.Forms.RadioButton();
            this.rbyenieski = new System.Windows.Forms.RadioButton();
            this.rbsattigim = new System.Windows.Forms.RadioButton();
            this.rbilkbes = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tburun_id = new System.Windows.Forms.TextBox();
            this.tbgorsel = new System.Windows.Forms.TextBox();
            this.tbozellik = new System.Windows.Forms.TextBox();
            this.tbaciklama = new System.Windows.Forms.TextBox();
            this.tbfiyat = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbbaslik = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbilaneskiyeni
            // 
            this.rbilaneskiyeni.AutoSize = true;
            this.rbilaneskiyeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbilaneskiyeni.Location = new System.Drawing.Point(27, 61);
            this.rbilaneskiyeni.Name = "rbilaneskiyeni";
            this.rbilaneskiyeni.Size = new System.Drawing.Size(170, 22);
            this.rbilaneskiyeni.TabIndex = 0;
            this.rbilaneskiyeni.TabStop = true;
            this.rbilaneskiyeni.Text = "Eskiden Yeniye Sırala";
            this.rbilaneskiyeni.UseVisualStyleBackColor = true;
            // 
            // dtilan
            // 
            this.dtilan.Location = new System.Drawing.Point(120, 253);
            this.dtilan.Name = "dtilan";
            this.dtilan.Size = new System.Drawing.Size(101, 22);
            this.dtilan.TabIndex = 140;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rborty);
            this.groupBox2.Controls.Add(this.rbazalan);
            this.groupBox2.Controls.Add(this.rbfiyatortalama);
            this.groupBox2.Controls.Add(this.rbartan);
            this.groupBox2.Controls.Add(this.rbyenieski);
            this.groupBox2.Controls.Add(this.rbilaneskiyeni);
            this.groupBox2.Controls.Add(this.rbsattigim);
            this.groupBox2.Controls.Add(this.rbilkbes);
            this.groupBox2.Location = new System.Drawing.Point(478, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 313);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorgulama İşlemleri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(27, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rborty
            // 
            this.rborty.AutoSize = true;
            this.rborty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rborty.Location = new System.Drawing.Point(27, 224);
            this.rborty.Name = "rborty";
            this.rborty.Size = new System.Drawing.Size(253, 22);
            this.rborty.TabIndex = 0;
            this.rborty.TabStop = true;
            this.rborty.Text = "Ortalamadan Daha Yüksek Fiyata ";
            this.rborty.UseVisualStyleBackColor = true;
            // 
            // rbazalan
            // 
            this.rbazalan.AutoSize = true;
            this.rbazalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbazalan.Location = new System.Drawing.Point(27, 142);
            this.rbazalan.Name = "rbazalan";
            this.rbazalan.Size = new System.Drawing.Size(108, 22);
            this.rbazalan.TabIndex = 0;
            this.rbazalan.TabStop = true;
            this.rbazalan.Text = "Fiyat Azalan";
            this.rbazalan.UseVisualStyleBackColor = true;
            // 
            // rbfiyatortalama
            // 
            this.rbfiyatortalama.AutoSize = true;
            this.rbfiyatortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbfiyatortalama.Location = new System.Drawing.Point(27, 197);
            this.rbfiyatortalama.Name = "rbfiyatortalama";
            this.rbfiyatortalama.Size = new System.Drawing.Size(256, 22);
            this.rbfiyatortalama.TabIndex = 0;
            this.rbfiyatortalama.TabStop = true;
            this.rbfiyatortalama.Text = "Sattığım Ürünlerin Fiyat Ortalaması";
            this.rbfiyatortalama.UseVisualStyleBackColor = true;
            // 
            // rbartan
            // 
            this.rbartan.AutoSize = true;
            this.rbartan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbartan.Location = new System.Drawing.Point(27, 115);
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
            this.rbyenieski.Location = new System.Drawing.Point(27, 88);
            this.rbyenieski.Name = "rbyenieski";
            this.rbyenieski.Size = new System.Drawing.Size(170, 22);
            this.rbyenieski.TabIndex = 0;
            this.rbyenieski.TabStop = true;
            this.rbyenieski.Text = "Yeniden Eskiye Sırala";
            this.rbyenieski.UseVisualStyleBackColor = true;
            // 
            // rbsattigim
            // 
            this.rbsattigim.AutoSize = true;
            this.rbsattigim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbsattigim.Location = new System.Drawing.Point(27, 169);
            this.rbsattigim.Name = "rbsattigim";
            this.rbsattigim.Size = new System.Drawing.Size(181, 22);
            this.rbsattigim.TabIndex = 0;
            this.rbsattigim.TabStop = true;
            this.rbsattigim.Text = "Ürünleri Sattığım Kişiler";
            this.rbsattigim.UseVisualStyleBackColor = true;
            // 
            // rbilkbes
            // 
            this.rbilkbes.AutoSize = true;
            this.rbilkbes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbilkbes.Location = new System.Drawing.Point(27, 34);
            this.rbilkbes.Name = "rbilkbes";
            this.rbilkbes.Size = new System.Drawing.Size(91, 22);
            this.rbilkbes.TabIndex = 0;
            this.rbilkbes.TabStop = true;
            this.rbilkbes.Text = "İlk 5 Kayıt";
            this.rbilkbes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(774, 255);
            this.dataGridView1.TabIndex = 137;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tburun_id
            // 
            this.tburun_id.Enabled = false;
            this.tburun_id.Location = new System.Drawing.Point(350, 15);
            this.tburun_id.Margin = new System.Windows.Forms.Padding(4);
            this.tburun_id.Name = "tburun_id";
            this.tburun_id.ReadOnly = true;
            this.tburun_id.Size = new System.Drawing.Size(122, 22);
            this.tburun_id.TabIndex = 136;
            // 
            // tbgorsel
            // 
            this.tbgorsel.Location = new System.Drawing.Point(121, 176);
            this.tbgorsel.Margin = new System.Windows.Forms.Padding(4);
            this.tbgorsel.Name = "tbgorsel";
            this.tbgorsel.ReadOnly = true;
            this.tbgorsel.Size = new System.Drawing.Size(100, 22);
            this.tbgorsel.TabIndex = 135;
            // 
            // tbozellik
            // 
            this.tbozellik.Location = new System.Drawing.Point(349, 182);
            this.tbozellik.Margin = new System.Windows.Forms.Padding(4);
            this.tbozellik.Multiline = true;
            this.tbozellik.Name = "tbozellik";
            this.tbozellik.ReadOnly = true;
            this.tbozellik.Size = new System.Drawing.Size(122, 56);
            this.tbozellik.TabIndex = 134;
            // 
            // tbaciklama
            // 
            this.tbaciklama.Location = new System.Drawing.Point(349, 113);
            this.tbaciklama.Margin = new System.Windows.Forms.Padding(4);
            this.tbaciklama.Multiline = true;
            this.tbaciklama.Name = "tbaciklama";
            this.tbaciklama.ReadOnly = true;
            this.tbaciklama.Size = new System.Drawing.Size(122, 56);
            this.tbaciklama.TabIndex = 133;
            // 
            // tbfiyat
            // 
            this.tbfiyat.Location = new System.Drawing.Point(121, 212);
            this.tbfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.tbfiyat.Name = "tbfiyat";
            this.tbfiyat.ReadOnly = true;
            this.tbfiyat.Size = new System.Drawing.Size(100, 22);
            this.tbfiyat.TabIndex = 132;
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(349, 47);
            this.tbadi.Margin = new System.Windows.Forms.Padding(4);
            this.tbadi.Name = "tbadi";
            this.tbadi.ReadOnly = true;
            this.tbadi.Size = new System.Drawing.Size(122, 22);
            this.tbadi.TabIndex = 131;
            // 
            // tbbaslik
            // 
            this.tbbaslik.Location = new System.Drawing.Point(349, 81);
            this.tbbaslik.Margin = new System.Windows.Forms.Padding(4);
            this.tbbaslik.Name = "tbbaslik";
            this.tbbaslik.ReadOnly = true;
            this.tbbaslik.Size = new System.Drawing.Size(122, 22);
            this.tbbaslik.TabIndex = 130;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(13, 182);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 127;
            this.label14.Text = "Görsel :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(253, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 129;
            this.label7.Text = "Özellikler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 125;
            this.label4.Text = "İlan_Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 124;
            this.label3.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(253, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 128;
            this.label2.Text = "Açıklama :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(253, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 123;
            this.label8.Text = "Adı :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(253, 17);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 126;
            this.label18.Text = "Ürün Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(253, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 122;
            this.label1.Text = "Başlık :";
            // 
            // sattiklarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(794, 610);
            this.Controls.Add(this.dtilan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tburun_id);
            this.Controls.Add(this.tbgorsel);
            this.Controls.Add(this.tbozellik);
            this.Controls.Add(this.tbaciklama);
            this.Controls.Add(this.tbfiyat);
            this.Controls.Add(this.tbadi);
            this.Controls.Add(this.tbbaslik);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "sattiklarim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sattiklarim";
            this.Load += new System.EventHandler(this.sattiklarim_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbilaneskiyeni;
        private System.Windows.Forms.DateTimePicker dtilan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbazalan;
        private System.Windows.Forms.RadioButton rbartan;
        private System.Windows.Forms.RadioButton rbyenieski;
        private System.Windows.Forms.RadioButton rbilkbes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tburun_id;
        private System.Windows.Forms.TextBox tbgorsel;
        private System.Windows.Forms.TextBox tbozellik;
        private System.Windows.Forms.TextBox tbaciklama;
        private System.Windows.Forms.TextBox tbfiyat;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbbaslik;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rborty;
        private System.Windows.Forms.RadioButton rbfiyatortalama;
        private System.Windows.Forms.RadioButton rbsattigim;
    }
}