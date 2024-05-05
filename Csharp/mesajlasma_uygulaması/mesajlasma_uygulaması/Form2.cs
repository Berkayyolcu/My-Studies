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

namespace mesajlasma_uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3F7I55\SQLEXPRESS;Initial Catalog=message;Integrated Security=True");

        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select MESAJID, (AD+ ' ' +SOYAD) AS GONDEREN,BASLIK,ICERIK From TBLMESAJLAR inner join TBLKISILER on TBLMESAJLAR.GONDEREN = TBLKISILER.NUMARA Where ALICI = " + numara, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select MESAJID, (AD+ ' ' +SOYAD) AS ALICI,BASLIK,ICERIK From TBLMESAJLAR inner join TBLKISILER on TBLMESAJLAR.ALICI = TBLKISILER.NUMARA Where GONDEREN = " + numara, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;

            gelenkutusu();
            gidenkutusu();

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select AD, SOYAD From TBLKISILER where numara="+numara,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values(@p1,@p2,@p3,@p4)", conn);
            komut.Parameters.AddWithValue("@p1",numara);
            komut.Parameters.AddWithValue("@p2",mskalıcı.Text);
            komut.Parameters.AddWithValue("@p3",txtbaşlık.Text);
            komut.Parameters.AddWithValue("@p4",rchmesaj.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Mesajınız İletilmiştir.");
            gidenkutusu();

        }
    }
}
