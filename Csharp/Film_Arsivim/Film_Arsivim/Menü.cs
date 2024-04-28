using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Arsivim
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }
        private void btnfilmler_Click(object sender, EventArgs e)
        {
            Filmler film = new Filmler();
            film.Show();
            this.Hide();
        }
        private void btnfilmizle_Click(object sender, EventArgs e)
        {
            Film_İzleme film = new Film_İzleme();
            film.Show();
            this.Hide();
        }

        private void btnhakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Berkay YOLCU tarafından 26.04.2024 'de kodlanmıstır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

