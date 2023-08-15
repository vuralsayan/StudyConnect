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


        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
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
    }
}
