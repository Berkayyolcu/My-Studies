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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O3F7I55\SQLEXPRESS;Initial Catalog=message;Integrated Security=True");
        private void btngiriş_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBLKISILER where NUMARA=@p1 AND SIFRE=@p2", conn);
            cmd.Parameters.AddWithValue("@p1",msknumara.Text);
            cmd.Parameters.AddWithValue("@p2",txtşifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.numara = msknumara.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            conn.Close();
        }
    }
}
