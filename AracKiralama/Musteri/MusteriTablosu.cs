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
{
    public partial class MusteriTablosu : Form
    {
        public MusteriTablosu()
        {
            InitializeComponent();

        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            // string Tc, string Ad_Soyad, string Telefon, string Adres, int EhliyetNo

            Musteri Musteri = new Musteri();

            var deneme = ";";

            if (TC.Text != "" && AdiSoyadi.Text != "" && Telefon.Text != "" && Adres.Text != "" && EhliyetNo.Text != "")
            {
                if (Musteri.MusteriEkle(TC.Text, AdiSoyadi.Text, Telefon.Text, Adres.Text, Convert.ToInt32(EhliyetNo.Text)))
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                    dataGridView1.DataSource = m.MusteriListele();
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

            int MusteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            m.MusteriSil(MusteriID);
            //musteri.MusteriSil(MusteriID);
            MessageBox.Show("Silindi!");
            dataGridView1.DataSource = m .MusteriListele();
            // dataGridView1.DataSource = Musteri.MusteriListele();

        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int MusteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Musteri musteri = new Musteri();
            if (musteri.MusteriGuncelle(TC.Text, AdiSoyadi.Text, Telefon.Text, Adres.Text, Convert.ToInt32(EhliyetNo.Text),MusteriID)) ;
            {
                MessageBox.Show(" Güncellendi!");
                dataGridView1.DataSource = m.MusteriListele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
          * Datagrid'in kayıtlarından herhangi birisine tıklandığında o tıklanana satırın bilgilerini belirtilen textboxların içerisine veriyi gönderir.
          *
          * MusteriID =0    TC =1     Ad_Soyad =2    Telefon=3    Adres=4      Email=5      EhliyetNo=6
          * 
          */

            MusteriID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            AdiSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Telefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Adres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            EhliyetNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        Musteri m = new Musteri();
        private void MusteriTablosu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m.MusteriListele();
        }
    }
}
