using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AracKiralama
{
    class DBProses
    {
        SqlBaglanti SqlBaglanti = new SqlBaglanti();

        //connection işlemleri. aç/ kapa / con string / comma

        //public void AracEkle(string aracPlaka, string Kolon1);
        
        public void AracSil(int AracID)
        {
            SqlCommand AracSilme = new SqlCommand("DELETE FROM AracBilgiTablosu WHERE AracID=@p1 ", SqlBaglanti.SqlBaglantiMetot());
            AracSilme.Parameters.AddWithValue("@p1", AracID);
            AracSilme.ExecuteNonQuery();
        }
        public void AracGuncelle(string Plaka, string Marka, int Yil, string Renk, int Km, string Yakit, int KiraUcret, string Resim, string Durum, int Tarih, string Model)
        {
            SqlCommand AracGuncel = new SqlCommand("UPDATE AracBilgiTablosu SET Plaka=@p1, Marka=qp2, Yil=@p3, Renk=@p4, Km=@p5, Yakit=@p6, KiraUcret=@p7, Resim=@p8, Durum=@p9, Tarih=@p10, Model=@p11)", SqlBaglanti.SqlBaglantiMetot());
            AracGuncel.Parameters.AddWithValue("@p1", Plaka);
            AracGuncel.Parameters.AddWithValue("@p2", Marka);
            AracGuncel.Parameters.AddWithValue("@p3", Yil);
            AracGuncel.Parameters.AddWithValue("@p4", Renk);
            AracGuncel.Parameters.AddWithValue("@p5", Km);
            AracGuncel.Parameters.AddWithValue("@p6", Yakit);
            AracGuncel.Parameters.AddWithValue("@p7", KiraUcret);
            AracGuncel.Parameters.AddWithValue("@p8", Resim);
            AracGuncel.Parameters.AddWithValue("@p9", Durum);
            AracGuncel.Parameters.AddWithValue("@p10", Tarih);
            AracGuncel.Parameters.AddWithValue("@p11", Model);
            AracGuncel.ExecuteNonQuery();
        }

        public void KullaniciEkle(string Adi, string Soyadi, string Sifre)
        {
            SqlCommand KullaniciEkleme = new SqlCommand("INSERT INTO KullaniciTablosu(Adi,Soyadi,Sifre) VALUES(@p1,@p2,@p3)", SqlBaglanti.SqlBaglantiMetot());
            KullaniciEkleme.Parameters.AddWithValue("@p1", Adi);
            KullaniciEkleme.Parameters.AddWithValue("@p2", Soyadi);
            KullaniciEkleme.Parameters.AddWithValue("@p3", Sifre);
            KullaniciEkleme.ExecuteNonQuery();
        }
        public void KullaniciSil(int KullaniciID)
        {
            SqlCommand KullaniciSilme = new SqlCommand("DELETE FROM KullaniciTablosu WHERE KullaniciID=@P1", SqlBaglanti.SqlBaglantiMetot());
            KullaniciSilme.Parameters.AddWithValue("@P1", KullaniciID);
            KullaniciSilme.ExecuteNonQuery();
        }

        public void KullaniciGuncelle(string Adi, string Soyadi, string Sifre, int KullaniciID)
        {
            SqlCommand KullaniciGuncel = new SqlCommand("UPDATE KullaniciTablosu SET Adi=@p1, Soyadi=@p2, Adresi=@p3, Sifre = @P3 WHERE KullaniciID=@P4 ", SqlBaglanti.SqlBaglantiMetot());
            KullaniciGuncel.Parameters.AddWithValue("@p1", Adi);
            KullaniciGuncel.Parameters.AddWithValue("@p2", Soyadi);
            KullaniciGuncel.Parameters.AddWithValue("@p3", Sifre);
            KullaniciGuncel.Parameters.AddWithValue("@p4", Convert.ToInt32(KullaniciID));
            KullaniciGuncel.ExecuteNonQuery();
        }

        public bool aracGetir(int AracID)
        {
            try
            {
                SqlCommand AracGetir = new SqlCommand("SELECT * FROM AracBilgiTablosu WHERE AracID=@p1 ", SqlBaglanti.SqlBaglantiMetot());
                AracGetir.Parameters.AddWithValue("@p1", AracID);
                AracGetir.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // public string Kisi(id)

        public int Topla (int say1, int sayi2 )
        {
            int c = say1 + sayi2;
            return c;
        }

        public void Toplama(int say1, int say2)
        {
            int c = say1 + say2;
        }




    }
}
