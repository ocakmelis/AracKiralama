using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{ //stackoverflow
    public partial class KullaniciEklemeForm : Form
    {
        public KullaniciEklemeForm()
        {
            InitializeComponent();
        }
        Kullanici m = new Kullanici();
        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            // string Adi, string Soyadi, string Sifre

            // Musteri Musteri = new Musteri();

            Kullanici kullanici = new Kullanici();

            var deneme = ";";

            if (T_Adi != null && T_Soyadi.Text != "" && T_Sifre.Text != "")
            {
                if (kullanici.KullaniciEkle(T_Adi.Text, T_Soyadi.Text, T_Sifre.Text))
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                    dataGridView1.DataSource = m.KullaniciListele();
                }
                else
                {
                    MessageBox.Show("HATALI GİRİŞ");
                }
            }
            else
            {
                MessageBox.Show("BOŞ BIRAKTIĞINIZ YERLERİ DOLDURUNUZ!");
            }
        }

        private void Btn_Sİl_Click(object sender, EventArgs e)
        {
            int KullaniciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            m.KullaniciSil(KullaniciID);
            MessageBox.Show("Silindi!");
            dataGridView1.DataSource = m.KullaniciListele();

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int KullaniciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Kullanici kullanici = new Kullanici();
            
            if (kullanici.KullaniciGuncelle(KullaniciID, T_Adi.Text, T_Soyadi.Text, T_Sifre.Text));
            {
                MessageBox.Show(" Güncellendi!");
                dataGridView1.DataSource = m.KullaniciListele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
       /*
        * KullaniciID =0    Adi =1     Soyadi =2    Sifre=3 
        * 
        */

            T_KullaniciID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            T_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            T_Soyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            T_Sifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();    
        }


        //Buradaki kullanım amacı nedir? gösterdiğim yer için indeksi yanlış söylemiyorsam listelemesi için
        //Telegram ile arasam olur mu? yazım tarafında daha rahat oluyorum diyorsan sorun olmaz fark etmez arasanızda olue not alırım ben


        private void KullaniciEklemeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m.KullaniciListele();
        }
    }
}
