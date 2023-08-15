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

        void etutListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("execute Etut", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
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
    }
}
