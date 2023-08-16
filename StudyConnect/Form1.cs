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
using System.IO;

namespace StudyConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Vural\SQLEXPRESS;Initial Catalog=DbEtut;Integrated Security=True");

        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DERSID";
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.DataSource = dt;
        }

        void dersListesi2()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDersAdı.ValueMember = "DERSID";
            CmbDersAdı.DisplayMember = "DERSAD";
            CmbDersAdı.DataSource = dt;
        }


        void etutListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("execute Etut", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        bool IsDersUsed(string dersAd, SqlConnection baglanti)
        {
            using (SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBLDERSLER WHERE DERSAD=@P1", baglanti))
            {
                baglanti.Open();
                komut.Parameters.AddWithValue("@P1", dersAd);
                int count = (int)komut.ExecuteScalar();
                baglanti.Close();
                return count > 0;      //Eğer dersAd varsa true döndürür
            }
        }

        void InsertDers(string dersAd, SqlConnection baglanti)
        {
            using (SqlCommand komut = new SqlCommand("INSERT INTO TBLDERSLER (DERSAD) VALUES(@P1)", baglanti))
            {
                baglanti.Open();
                komut.Parameters.AddWithValue("@P1", dersAd);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            dersListesi2();
            etutListesi();
            CmbDers.Text = "Ders Seçiniz";
            CmbDersAdı.Text = "Ders Seçiniz";
        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT OGRTID, CONCAT(AD, ' ', SOYAD) as AdSoyad FROM TBLOGRETMEN WHERE BRANSID =" + CmbDers.SelectedValue, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "AdSoyad"; //AdSoyad kolonunu gösterir
            CmbOgretmen.DataSource = dt;
        }

        private void BtnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) VALUES(@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@P2", CmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@P3", MskTarih.Text);
            komut.Parameters.AddWithValue("@P4", MskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            etutListesi();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtEtutID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLETUT SET OGRENCIID=@P1,DURUM=@P2 WHERE ID=@P3", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtOgrencıID.Text);
            komut.Parameters.AddWithValue("@P2", "True");
            komut.Parameters.AddWithValue("@P3", TxtEtutID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            etutListesi();
        }

        private void BtnFotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();                           //Dosya seçme işlemi
            pictureBox1.ImageLocation = openFileDialog1.FileName;   //Seçilen dosyanın resmini gösterme
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSinif.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDersEkle_Click(object sender, EventArgs e)
        {
            string dersAd;
            do
            {
                dersAd = TxtDers.Text;
                if (IsDersUsed(dersAd, baglanti))
                {
                    MessageBox.Show("Bu Ders Adı Sistemde Zaten Mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InsertDers(dersAd, baglanti);
                    MessageBox.Show("Ders Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;  //Ders eklendikten sonra döngüden çık
                }
            } while (false);

            dersListesi(); //Dersler listesini güncelle
        }

        private void BtnOgretmenEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLOGRETMEN (AD,SOYAD,BRANSID) VALUES(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtOgretmenAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgretmenSoyAd.Text);
            komut.Parameters.AddWithValue("@p3", CmbDersAdı.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğretmen eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

