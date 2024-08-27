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
} // projeyi kurtardım ama ana formu silinmiş o yuzden tekrar anaform oluşturucam ama bu sefer ribbon eklenmiyor
//Ana f0ormun adı neydi? AracKiralama

//Projeyi nereye kopyalamıştın? masaüstüne kopyalamayı denedim sonra proje çalışmmaya basladı
//Hallederiz muhtemelen Projeyi kesip mi yapıştırdın kopyalayıpo mı kopya projeyi kurtardım ama bişeyleri silmişim ana form kısım yok 
//Evet Şu şekilde şimdi klasöre - dosyaya sağtıklayarak klasör konumuna gidiyorum

//Sözleşme için .cs dosyası, .designerdosyası hepsi var ancak araçkilama için designer kaybolmuş
//frm main yeni actıgım form  arackiralama formu silinmiş bende yeni form açmıştım
//Araçkiralama yüklenmiş olmalı başarılı şekilde o zaman yukardaki kodu değiştireyim
