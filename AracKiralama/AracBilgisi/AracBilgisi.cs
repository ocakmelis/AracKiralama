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
    class AracBilgisi
    {
        /*
         AracID
         Plaka
         Marka
         Seri
         Yil
         Renk
         Km
         Yakit
         KiraUcret
         Resim
         Durum
         Tarih
         Model
         */


        SqlBaglanti SqlBaglanti = new SqlBaglanti();
        public string AracID { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Seri { get; set; }
        public int Yil { get; set; }
        public string Renk { get; set; }
        public int Km { get; set; }
        public string Yakit { get; set; }
        public int KiraUcret { get; set; }
        public string Resim { get; set; }
        public string Durum { get; set; }
        public DateTime Tarih { get; set; }
        public string Model { get; set; }

        public bool AracEkle(string Plaka, string Marka, int Yil, string Renk, int Km, string Yakit, int KiraUcret, string Resim, string Durum, DateTime Tarih, string Model)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=DB_OTOMOBİL;Integrated Security=True");
                baglanti.Open();
                SqlCommand AracEkleme = new SqlCommand("INSERT INTO AracBilgiTablosu (Plaka, Marka, Yil, Renk, Km, Yakit, KiraUcret, Resim, Durum, Tarih, Model) VALUES (@p1, @p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ", SqlBaglanti.SqlBaglantiMetot());
                AracEkleme.Parameters.AddWithValue("@p1", Plaka);
                AracEkleme.Parameters.AddWithValue("@p2", Marka);
                AracEkleme.Parameters.AddWithValue("@p3", Yil);
                AracEkleme.Parameters.AddWithValue("@p4", Renk);
                AracEkleme.Parameters.AddWithValue("@p5", Km);
                AracEkleme.Parameters.AddWithValue("@p6", Yakit);
                AracEkleme.Parameters.AddWithValue("@p7", KiraUcret);
                AracEkleme.Parameters.AddWithValue("@p8", Resim);
                AracEkleme.Parameters.AddWithValue("@p9", Durum);
                AracEkleme.Parameters.AddWithValue("@p10", Tarih);
                AracEkleme.Parameters.AddWithValue("@p11", Model);
                AracEkleme.ExecuteNonQuery();

                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM AracBilgiTablosu", baglanti); // Musterileri Lisleyelen Sql Kodunu Yazdık
                DataTable dt = new DataTable();// Yazılan sql kodunu datatable 'a aktarmamı için nesneyi oluşturduk.
                adp.Fill(dt);//Oluşturduğumuz datatable ' ın içerisini fill ile doldurma işlemini yapıyoruz.
                //dataGridView.DataSource = dt;
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool AracSil(int AracID)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=DB_OTOMOBİL;Integrated Security=True");
                baglanti.Open();
                SqlCommand AracSilme = new SqlCommand("DELETE FROM AracBilgiTablosu WHERE AracID=@p1 ", SqlBaglanti.SqlBaglantiMetot());
                AracSilme.Parameters.AddWithValue("@p1", AracID);
                AracSilme.ExecuteNonQuery();
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
        public bool AracGuncelle(string Plaka, string Marka, string Seri, int Yil, string Renk, int Km, string Yakit, int KiraUcret, string Resim, string Durum, DateTime Tarih, string Model,int PID)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                baglanti.Open();
                SqlCommand AracGuncel = new SqlCommand("UPDATE AracBilgiTablosu SET Plaka=@Plaka, Marka=@Marka, Seri=@Seri, Yil=@Yil, Renk=@Renk, Km=@Km, Yakit=@Yakit, KiraUcret=@KiraUcret, Resim=@Resim, Durum=@Durum, Tarih=@Tarih, Model=@Model where aracID = @aracID", baglanti);
                AracGuncel.Parameters.AddWithValue("@Plaka", Plaka);
                AracGuncel.Parameters.AddWithValue("@Marka", Marka);
                AracGuncel.Parameters.AddWithValue("@Yil", Yil);
                AracGuncel.Parameters.AddWithValue("@Renk", Renk);
                AracGuncel.Parameters.AddWithValue("@Km", Km);
                AracGuncel.Parameters.AddWithValue("@Yakit", Yakit);
                AracGuncel.Parameters.AddWithValue("@KiraUcret", KiraUcret);
                AracGuncel.Parameters.AddWithValue("@Resim", Resim);
                AracGuncel.Parameters.AddWithValue("@Durum", Durum);
                AracGuncel.Parameters.AddWithValue("@Tarih", Tarih);
                AracGuncel.Parameters.AddWithValue("@Model", Model);
                AracGuncel.Parameters.AddWithValue("@Seri", Seri);
                AracGuncel.Parameters.AddWithValue("@aracID", PID);
                AracGuncel.ExecuteNonQuery();
                baglanti.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

           
        }

        public void AracListele(DataGridView dgv)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM AracBilgiTablosu",baglanti);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                baglanti.Close();
                dgv.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }


    }
}
