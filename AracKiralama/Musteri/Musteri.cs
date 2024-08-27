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
    //public olması erişilebilirlik açısından bir özellik
    public class Musteri
    {
        /* 
         * MusteriID
         * TC
         * Ad_Soyad
         * Telefon
         * Adres
         * Email
         * EhliyetNo
         */

        SqlBaglanti SqlBaglanti = new SqlBaglanti();
        public int MusteriID { get; set; }
        public string TC { get; set; }
        public string Ad_Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public int EhliyetNo { get; set; }

        public bool MusteriEkle(string Tc, string Ad_Soyad, string Telefon, string Adres, int EhliyetNo)
        {
            try
            {
              
                baglanti.Open();
                SqlCommand cmm = new SqlCommand("INSERT INTO MusteriTablosu (Tc,Ad_Soyad,Telefon,Adres,EhliyetNo) VALUES (@p1, @p2,@p3,@p4,@p5) ", SqlBaglanti.SqlBaglantiMetot());
                cmm.Parameters.AddWithValue("@p1", Tc);
                cmm.Parameters.AddWithValue("@p2", Ad_Soyad);
                cmm.Parameters.AddWithValue("@p3", Telefon);
                cmm.Parameters.AddWithValue("@p4", Adres);
                cmm.Parameters.AddWithValue("@p5", Convert.ToInt32(EhliyetNo));
                cmm.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool MusteriSil(int MusteriID)
        {
            try
            {
                baglanti.Open();
                SqlCommand MusteriSilme = new SqlCommand("DELETE FROM MusteriTablosu WHERE MusteriID=@p1 ", baglanti);
                MusteriSilme.Parameters.AddWithValue("@p1", MusteriID);
                MusteriSilme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /*
        public bool MusteriGuncelle(string Tc)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=DB_OTOMOBİL;Integrated Security=True");
                baglanti.Open();

                SqlCommand MusteriGuncel = new SqlCommand("UPDATE MusteriTablosu SET Tc=@p1, Ad_Soyad=@p2, Telefon=@p3, Adres=@p4, EhliyetNo=@p5 WHERE Tc=@p6)", baglanti);
                MusteriGuncel.Parameters.AddWithValue("@p1", Tc);
                MusteriGuncel.Parameters.AddWithValue("@p2", Ad_Soyad);
                MusteriGuncel.Parameters.AddWithValue("@p3", Telefon);
                MusteriGuncel.Parameters.AddWithValue("@p4", Adres);
                MusteriGuncel.Parameters.AddWithValue("@p5", EhliyetNo);
                MusteriGuncel.Parameters.AddWithValue("@p6", Convert.ToInt32(MusteriID));
                MusteriGuncel.ExecuteNonQuery();
                baglanti.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }
        */
        public bool MusteriGuncelle(string Tc, string Ad_Soyad, string Telefon, string Adres, int EhliyetNo, int MusteriID)
        {
            try
            {
                baglanti.Open();
                SqlCommand comm = new SqlCommand("UPDATE MusteriTablosu SET Tc=@tc, Ad_Soyad=@p2, Telefon=@p3, Adres=@p4, EhliyetNo=@p5 WHERE MusteriID=@p6", baglanti);
                comm.Parameters.AddWithValue("@tc", Tc);
                comm.Parameters.AddWithValue("@p2", Ad_Soyad);
                comm.Parameters.AddWithValue("@p3", Telefon);
                comm.Parameters.AddWithValue("@p4", Adres);
                comm.Parameters.AddWithValue("@p5", EhliyetNo);
                comm.Parameters.AddWithValue("@p6", Convert.ToInt32(MusteriID));
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

        SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=DB_OTOMOBİL;Integrated Security=True");
        public DataTable MusteriListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM MusteriTablosu", SqlBaglanti.SqlBaglantiMetot());
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

        /*
        public DataTable MusteriListele(int a ) // overload// 
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM MusteriTablosu", SqlBaglanti.SqlBaglantiMetot());
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
        */
    }
}
