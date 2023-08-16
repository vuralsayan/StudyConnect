namespace StudyConnect
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEtutOlustur = new System.Windows.Forms.Button();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.CmbOgretmen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEtutID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOgrencıID = new System.Windows.Forms.TextBox();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnDersEkle = new System.Windows.Forms.Button();
            this.TxtDers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnFotograf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnOgretmenEkle = new System.Windows.Forms.Button();
            this.CmbDersAdı = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtOgretmenSoyAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEtutOlustur);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.CmbOgretmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.CmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEtutOlustur
            // 
            this.BtnEtutOlustur.Location = new System.Drawing.Point(115, 224);
            this.BtnEtutOlustur.Name = "BtnEtutOlustur";
            this.BtnEtutOlustur.Size = new System.Drawing.Size(231, 44);
            this.BtnEtutOlustur.TabIndex = 8;
            this.BtnEtutOlustur.Text = "Etüt Oluştur";
            this.BtnEtutOlustur.UseVisualStyleBackColor = true;
            this.BtnEtutOlustur.Click += new System.EventHandler(this.BtnEtutOlustur_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(115, 188);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(231, 30);
            this.MskSaat.TabIndex = 7;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // CmbOgretmen
            // 
            this.CmbOgretmen.FormattingEnabled = true;
            this.CmbOgretmen.Location = new System.Drawing.Point(115, 80);
            this.CmbOgretmen.Name = "CmbOgretmen";
            this.CmbOgretmen.Size = new System.Drawing.Size(231, 32);
            this.CmbOgretmen.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(115, 135);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(231, 30);
            this.MskTarih.TabIndex = 2;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(115, 25);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(231, 32);
            this.CmbDers.TabIndex = 1;
            this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEtutID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtOgrencıID);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(442, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TxtEtutID
            // 
            this.TxtEtutID.Location = new System.Drawing.Point(101, 19);
            this.TxtEtutID.Name = "TxtEtutID";
            this.TxtEtutID.Size = new System.Drawing.Size(178, 30);
            this.TxtEtutID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Etüt ID:";
            // 
            // TxtOgrencıID
            // 
            this.TxtOgrencıID.Location = new System.Drawing.Point(101, 67);
            this.TxtOgrencıID.Name = "TxtOgrencıID";
            this.TxtOgrencıID.Size = new System.Drawing.Size(178, 30);
            this.TxtOgrencıID.TabIndex = 12;
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.Location = new System.Drawing.Point(101, 115);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(178, 44);
            this.BtnEtutVer.TabIndex = 9;
            this.BtnEtutVer.Text = "Etüt Ver";
            this.BtnEtutVer.UseVisualStyleBackColor = true;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1096, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDersEkle);
            this.groupBox4.Controls.Add(this.TxtDers);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(442, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 149);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // BtnDersEkle
            // 
            this.BtnDersEkle.Location = new System.Drawing.Point(101, 73);
            this.BtnDersEkle.Name = "BtnDersEkle";
            this.BtnDersEkle.Size = new System.Drawing.Size(178, 44);
            this.BtnDersEkle.TabIndex = 26;
            this.BtnDersEkle.Text = "Ders Ekle";
            this.BtnDersEkle.UseVisualStyleBackColor = true;
            this.BtnDersEkle.Click += new System.EventHandler(this.BtnDersEkle_Click);
            // 
            // TxtDers
            // 
            this.TxtDers.Location = new System.Drawing.Point(101, 29);
            this.TxtDers.Name = "TxtDers";
            this.TxtDers.Size = new System.Drawing.Size(178, 30);
            this.TxtDers.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ders Adı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MskTelefon);
            this.groupBox5.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox5.Controls.Add(this.TxtMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TxtSinif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TxtSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(769, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 329);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(120, 160);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(178, 30);
            this.MskTelefon.TabIndex = 25;
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(120, 253);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(178, 44);
            this.BtnOgrenciEkle.TabIndex = 24;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = true;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(120, 206);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(178, 30);
            this.TxtMail.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Telefon:";
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(120, 114);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(178, 30);
            this.TxtSinif.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sınıf:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(120, 68);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(178, 30);
            this.TxtSoyad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(120, 22);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(178, 30);
            this.TxtAd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnFotograf);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1114, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(294, 329);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // BtnFotograf
            // 
            this.BtnFotograf.Location = new System.Drawing.Point(55, 253);
            this.BtnFotograf.Name = "BtnFotograf";
            this.BtnFotograf.Size = new System.Drawing.Size(178, 44);
            this.BtnFotograf.TabIndex = 26;
            this.BtnFotograf.Text = "Fotoğraf Yükle";
            this.BtnFotograf.UseVisualStyleBackColor = true;
            this.BtnFotograf.Click += new System.EventHandler(this.BtnFotograf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BtnOgretmenEkle);
            this.groupBox7.Controls.Add(this.CmbDersAdı);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.TxtOgretmenSoyAd);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.TxtOgretmenAd);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(1114, 335);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(294, 283);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // BtnOgretmenEkle
            // 
            this.BtnOgretmenEkle.Location = new System.Drawing.Point(79, 170);
            this.BtnOgretmenEkle.Name = "BtnOgretmenEkle";
            this.BtnOgretmenEkle.Size = new System.Drawing.Size(197, 44);
            this.BtnOgretmenEkle.TabIndex = 27;
            this.BtnOgretmenEkle.Text = "Öğretmen Ekle";
            this.BtnOgretmenEkle.UseVisualStyleBackColor = true;
            this.BtnOgretmenEkle.Click += new System.EventHandler(this.BtnOgretmenEkle_Click);
            // 
            // CmbDersAdı
            // 
            this.CmbDersAdı.FormattingEnabled = true;
            this.CmbDersAdı.Location = new System.Drawing.Point(79, 122);
            this.CmbDersAdı.Name = "CmbDersAdı";
            this.CmbDersAdı.Size = new System.Drawing.Size(197, 32);
            this.CmbDersAdı.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Ders:";
            // 
            // TxtOgretmenSoyAd
            // 
            this.TxtOgretmenSoyAd.Location = new System.Drawing.Point(79, 74);
            this.TxtOgretmenSoyAd.Name = "TxtOgretmenSoyAd";
            this.TxtOgretmenSoyAd.Size = new System.Drawing.Size(197, 30);
            this.TxtOgretmenSoyAd.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "Soyad:";
            // 
            // TxtOgretmenAd
            // 
            this.TxtOgretmenAd.Location = new System.Drawing.Point(79, 26);
            this.TxtOgretmenAd.Name = "TxtOgretmenAd";
            this.TxtOgretmenAd.Size = new System.Drawing.Size(197, 30);
            this.TxtOgretmenAd.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Ad:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(182)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1461, 630);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.Button BtnEtutOlustur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtOgrencıID;
        private System.Windows.Forms.TextBox TxtEtutID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.TextBox TxtDers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbDersAdı;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtOgretmenSoyAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOgretmenAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnOgretmenEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

