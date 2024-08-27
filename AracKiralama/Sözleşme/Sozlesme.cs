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
     class Sozlesme
    {
        /*
         * SozlesmeID
         * KiraSekli
         * KiraUcret
         * G_Tarihi
         * C_Tarihi
         * 
         */
        SqlBaglanti SqlBaglanti = new SqlBaglanti();
        public int SozlesmeID { get; set; }
        public string KiraSekli { get; set; }
        public int KiraUcret { get; set; }
        public DateTime G_Tarihi { get; set; }
        public DateTime C_Tarihi { get; set; }

        SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=DB_OTOMOBİL;Integrated Security=True");

        public bool SozlesmeEkle(string KiraSekli, int KiraUcret, DateTime G_Tarihi, DateTime C_Tarihi)
        {
            try
            {
                baglanti.Open();
                SqlCommand SozlesmeEkleme = new SqlCommand("INSERT INTO SozlesmeTablosu(KiraSekli,KiraUcret,G_Tarihi,C_Tarihi) VALUES (@p1, @p2,@p3,@p4) ", SqlBaglanti.SqlBaglantiMetot());
                SozlesmeEkleme.Parameters.AddWithValue("@p1", KiraSekli);
                SozlesmeEkleme.Parameters.AddWithValue("@p2", KiraUcret);
                SozlesmeEkleme.Parameters.AddWithValue("@p3", G_Tarihi);
                SozlesmeEkleme.Parameters.AddWithValue("@p4", C_Tarihi);
                SozlesmeEkleme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool SozlesmeGuncelle(string KiraSekli, int KiraUcret, DateTime G_Tarihi, DateTime C_Tarihi)
        {
            try
            {
                
                baglanti.Open();
                SqlCommand SozlesmeGuncel = new SqlCommand("UPDATE SozlesmeTablosu SET KiraSekli=@p1, KiraUcret=p2, G_Tarihi=@p3, C_Tarihi=@p4)", baglanti);
                SozlesmeGuncel.Parameters.AddWithValue("@p1", KiraSekli);
                SozlesmeGuncel.Parameters.AddWithValue("@p2", KiraUcret);
                SozlesmeGuncel.Parameters.AddWithValue("@p3", G_Tarihi);
                SozlesmeGuncel.Parameters.AddWithValue("@p4", C_Tarihi);
                SozlesmeGuncel.ExecuteNonQuery();
                baglanti.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            

            DataTable AracListele()
            {
                try
                {
                    
                    baglanti.Open();
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM SozlesmeTablosu", SqlBaglanti.SqlBaglantiMetot());
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

        public DataTable SozlesmeListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM SozlesmeTablosu", SqlBaglanti.SqlBaglantiMetot());
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
