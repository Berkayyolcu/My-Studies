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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O3F7I55\SQLEXPRESS;Initial Catalog=Rehber;Integrated Security=True");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From KISILER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            msktelefon.Text = "";
            txtmail.Text = "";
            txtmail.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele ();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KISILER (AD,SOYAD,TELEFON,MAIL) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehberden Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From KISILER where ID="+txtıd.Text, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehberden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update KISILER set AD=@p1, SOYAD=@p2, TELEFON=@p3, MAIL=@p4  where ID=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtmail.Text);
            komut.Parameters.AddWithValue("@p5", txtıd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Rehberden Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
