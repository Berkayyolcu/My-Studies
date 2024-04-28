using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Arsivim
{
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3F7I55\SQLEXPRESS;Initial Catalog=FilmArsiv;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLFILMLER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Film_Ekleme_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFILMLER (AD,KATEGORI,LINK) values (@p1,@p2,@p3)", conn);
            komut.Parameters.AddWithValue("@p1", txtfilmad.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.Parameters.AddWithValue("@p3", txtlink.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film Listenize Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();

            txtfilmad.Clear();
            txtlink.Clear();
            txtkategori.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtfilmad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtlink.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Delete From TBLFILMLER where AD=@p1", conn);
            komut.Parameters.AddWithValue("@p1", txtfilmad.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film Listenizden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();

            txtfilmad.Clear();
            txtlink.Clear();
            txtkategori.Clear();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Update TBLFILMLER set AD=@p1, KATEGORI=@p2, LINK=@p3  where ID=@p4", conn);
            komut.Parameters.AddWithValue("@p1", txtfilmad.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.Parameters.AddWithValue("@p3", txtlink.Text);
            komut.Parameters.AddWithValue("@p4", txtid.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film Listenizden Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();

            txtfilmad.Clear();
            txtlink.Clear();
            txtkategori.Clear();
        }
    }
}

