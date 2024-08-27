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
    public partial class SozlesmeForm : Form
    {
        public SozlesmeForm()
        {
            InitializeComponent();
        }

        //KiraSekli,KiraUcret,G_Tarihi,C_Tarihi

        Sozlesme Sozlesme = new Sozlesme();

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            if (T_KiraSekli.Text != "" && KiraUcret.Text != "" && date_G_Tarihi.Value != null && date_C_Tarihi.Value != null)
            {

                if (Sozlesme.SozlesmeEkle(T_KiraSekli.Text, Convert.ToInt32(KiraUcret.Text), date_G_Tarihi.Value, date_C_Tarihi.Value))
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                    
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

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int SozlesmeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            if (Sozlesme.SozlesmeGuncelle(T_KiraSekli.Text, Convert.ToInt32(KiraUcret.Text), date_G_Tarihi.Value, date_C_Tarihi.Value))
            {
                MessageBox.Show("Sözleşme Güncellendi!");
                dataGridView1.DataSource = s.SozlesmeListele();
            }
            else
            {
                MessageBox.Show("Güncellendi");

            }
        }

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s.SozlesmeListele();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // SozlesmeID=0     KiraSekli=1      KiraUcret=2    G_Tarihi=3    C_Tarihi=4 
            //db de musteriıd de var bunu sor

            T_SozlesmeID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            T_KiraSekli.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            KiraUcret.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            date_G_Tarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            date_C_Tarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        Sozlesme s = new Sozlesme();

        private void SozlesmeForm_Load(object sender, EventArgs e)
        {
            s.SozlesmeListele();
        }
    }
}
