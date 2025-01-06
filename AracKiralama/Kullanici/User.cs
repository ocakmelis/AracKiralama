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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            User user = new User();
            Kullanici Kullanici = new Kullanici();

            if (Kullanici.Kullanici_Giris(F_KullaniciAdi.Text, F_KullaniciSifresi.Text))
            {

                int kullaniciid = Kullanici.KullaniciID;
                this.Hide(); //giriş yapıp ana forma atadıktan sonra giriş yap ekranını kapatır.
                AracKiralama anaForm = new AracKiralama();
                anaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış!");
            }
        }
    }
} 
