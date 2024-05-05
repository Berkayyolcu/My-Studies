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

namespace şifreli_veriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsifrele_Click(object sender, EventArgs e)
        {
            string metin = txtşifre.Text;
            byte[] metinizi = ASCIIEncoding.ASCII.GetBytes(metin);
            string metinsifre = Convert.ToBase64String(metinizi);
            txt.Text = metinsifre;
            txtşifre.Text = "";
        }
        private void btnsifrecöz_Click(object sender, EventArgs e)
        {
            string metin = txt.Text;
            byte[] metinizi = Convert.FromBase64String(metin);
            string metinsifre = ASCIIEncoding.ASCII.GetString(metinizi);
            txtşifre.Text = metinsifre;
            txt.Text = "";
        }
    }
}
