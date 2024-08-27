using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace AracKiralama
{
    public partial class AracBilgiForm : Form
    {
        public AracBilgiForm()
        {
            InitializeComponent();
        }
        AracBilgisi AracBilgisi = new AracBilgisi();
        string resimYolu;

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            if (plaka.Text != "" && marka.Text != "" && seri.Text != "" && yil.Text != "" && renk.Text != "" && km.Text != "" && yakit.Text != "" && kira.Text != "" && resim.Image != null && durum.Text != "" && Tarih.Value != null && model.Text != "")
            {
                //string Plaka, string Marka, int Yil, string Renk, int Km, string Yakit, int KiraUcret, string Resim, string Durum, DateTime Tarih, string Model
                if (AracBilgisi.AracEkle(plaka.Text, marka.Text, Convert.ToInt32(yil.Text), renk.Text, Convert.ToInt32(km.Text), yakit.Text, Convert.ToInt32(kira.Text), resimYolu, durum.Text, Tarih.Value, model.Text))
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                    //dataGridView1.DataSource = AracBilgisi.AracListele();
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

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int AracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            AracBilgisi.AracSil(AracID);
            MessageBox.Show("Silindi!");
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int AracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            if (AracBilgisi.AracGuncelle(plaka.Text, marka.Text, seri.Text ,Convert.ToInt32(yil.Text),renk.Text, Convert.ToInt32(km.Text), yakit.Text, Convert.ToInt32(kira.Text), resimYolu, durum.Text, Tarih.Value, model.Text,AracID))
            {
                MessageBox.Show("Araç Güncellendi!");
                ab.AracListele(dataGridView1);
            }
            else
            {
                MessageBox.Show("Güncellendi");
                
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // AracID=0     Plaka=1      Marka=2    Seri=3    Yil=4   Renk=5   Km=6   Yakit=7    KiraUcret=8    Resim=9   Durum=10  Tarih=11   Model=12

            AracID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            seri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            renk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            km.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            yakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            kira.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            resim.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            durum.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            Tarih.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString(); 
        }

        private void Btn_Sec_Click(object sender, EventArgs e)
        {
            // Kullanıcının seçtiği resim dosyasını picturebox ' a ekler.
            // OpenFileDialog => bu bilgisayardan bir dosya seçme penceresini açar 
            OpenFileDialog ResimSec = new OpenFileDialog();                  // Nesne Türettik
            ResimSec.ShowDialog();                                           // Butona Tıkladığında Pencereyi açmayı sağlayan ShowDialog() komutunu yazdık
            if (ResimSec.FileName == "")
            {
                return;
            }
            resim.Image = Image.FromFile(ResimSec.FileName);           // picturebox'ın resmi nereden alacağını belirten komut
            resimYolu = ResimSec.FileName;                                   // Veritabanına kaydetmek için resimYolu değişkenine resmin dosya yolunu atadık ve üstteki insert komutunda @p5 e resim yolu değişkinene tanımladık.
            //dataGridView1.DataSource
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "")
            {
                MessageBox.Show("BU ARACIN RESMİ YOK!");
            }
            else
            {//contains: içi 
                if (dataGridView1.CurrentRow.Cells[9].Value.ToString().Contains("Resim"))
                {
                    resim.Image = null;
                    resimYolu = "ResimYolu";

                }
                else
                {
                    resim.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[9].Value.ToString());
                }
            }
            //Datagrid'in kayıtlarından herhangi birisine tıklandığında o tıklanana satırın bilgilerini belirtilen textboxların içerisine veriyi gönderir.
            // AracID=0     Plaka=1      Marka=2    Seri=3    Yil=4   Renk=5   Km=6   Yakit=7    KiraUcret=8    Resim=9   Durum=10  Tarih=11   Model=12

            AracID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            seri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            renk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            km.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            yakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            kira.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            resim.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            durum.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            Tarih.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

        }

        AracBilgisi ab = new AracBilgisi();
        private void AracBilgiForm_Load(object sender, EventArgs e)
        {
            ab.AracListele(dataGridView1);
        }
    }
}
