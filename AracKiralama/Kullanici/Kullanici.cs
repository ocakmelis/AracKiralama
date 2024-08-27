using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AracKiralama
{
    public class Kullanici
    {
        /* KullaniciID
         * Adi
         * Soyadi
         * Sifre
         */

        SqlBaglanti SqlBaglanti = new SqlBaglanti();
        SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=DB_OTOMOBİL;Integrated Security=True");

        public int KullaniciID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }

        public bool KullaniciEkle(string Adi, string Soyadi, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand KullaniciEkleme = new SqlCommand("INSERT INTO KullaniciTablosu (Adi,Soyadi,Sifre) VALUES (@p1, @p2,@p3) ", SqlBaglanti.SqlBaglantiMetot());
                KullaniciEkleme.Parameters.AddWithValue("@p1", Adi);
                KullaniciEkleme.Parameters.AddWithValue("@p2", Soyadi);
                KullaniciEkleme.Parameters.AddWithValue("@p3", Sifre);
                KullaniciEkleme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool KullaniciSil(int KullaniciID)
        {
            try
            {
                baglanti.Open();
                SqlCommand KullaniciSilme = new SqlCommand("DELETE FROM KullaniciTablosu WHERE KullaniciID=@p1 ", baglanti);
                KullaniciSilme.Parameters.AddWithValue("@p1", KullaniciID);
                KullaniciSilme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool KullaniciGuncelle(int KullaniciID, string Adi, string Soyadi, string Sifre)
        {
            try
            {
                baglanti.Open();
                SqlCommand comm = new SqlCommand("UPDATE KullaniciTablosu SET Adi=@p1, Soyadi=@p2, Sifre=@p3, WHERE KullaniciID=@p4", baglanti);
                comm.Parameters.AddWithValue("@p1", Adi);
                comm.Parameters.AddWithValue("@p2", Soyadi);
                comm.Parameters.AddWithValue("@p3", Sifre);
                comm.Parameters.AddWithValue("@p4", Convert.ToInt32(KullaniciID));
                comm.ExecuteNonQuery();
                baglanti.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        public bool Kullanici_Giris(string username, string password)
        {

            try
            {
                baglanti.Open();
                SqlCommand KullaniciEkleme = new SqlCommand("SeleCt * from KullaniciTablosu where Adi=@p1 and Sifre=@p2", SqlBaglanti.SqlBaglantiMetot());
                KullaniciEkleme.Parameters.AddWithValue("@p1", username);
                KullaniciEkleme.Parameters.AddWithValue("@p2", password);
                var count = (int)KullaniciEkleme.ExecuteScalar();
                baglanti.Close();

                if (count <= 0)
                {
                    return false;
                }
                else 
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable KullaniciListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM KullaniciTablosu", SqlBaglanti.SqlBaglantiMetot());
                DataTable dt = new DataTable();
                adp.Fill(dt);

                baglanti.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        




    }
}
