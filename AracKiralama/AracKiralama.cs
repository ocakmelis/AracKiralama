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

namespace AracKiralama
{
    public partial class AracKiralama : Form
    {
        public AracKiralama()
        {
            InitializeComponent();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {

            KullaniciEklemeForm kullanici = new KullaniciEklemeForm();
            kullanici.ShowDialog();
        
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            

            MusteriTablosu musteriTablosu = new MusteriTablosu();
            musteriTablosu.ShowDialog();

        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            AracBilgiForm aracBilgisi = new AracBilgiForm();
            aracBilgisi.ShowDialog();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            SozlesmeForm sozlesme = new SozlesmeForm();
            sozlesme.ShowDialog();
        }
    }
}
