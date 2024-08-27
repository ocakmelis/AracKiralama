using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AracKiralama
{
    class SqlBaglanti
    {
        public SqlConnection SqlBaglantiMetot()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=DB_OTOMOBİL;Integrated Security=True");
            baglanti.Open();
            return baglanti;

            // configden oku
        }
    }
}

