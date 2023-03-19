using System;
using System.Collections.Generic;
using System.Data; // SQL veritabanı işlemleri için gerekli.
using System.Data.SqlClient; // SQL veritabanı işlemleri için gerekli.

namespace WindowsFormsADONet
{
    public class UrunDAL
    {
        // Bu class ürün ile alakalı veritabanı işlemleri için 
        SqlConnection connection = new SqlConnection(@"Server=.; database=AdoNetDb; trusted_connection=true"); // veritabanına bağlamak için gerekli bağlantı nesnesi. Connectionstring veritabanı bağlantı bilgileridir.
        void BaglantiyiAc()
        {
            if (connection.State == ConnectionState.Closed) // veritabanı bağlantısı kapalıysa
            {
                connection.Open(); // bağlantıyı aç
            }

        }
        public List<Urun> UrunleriGetir()
        {
            BaglantiyiAc();
            List<Urun> urunler = new List<Urun>(); // boş ürün listesi oluşturduk.
            SqlCommand sqlCommand = new SqlCommand("select * from urunler", connection); // sql komutu çalıştırmak için gerekli nesneyi oluşturup içine select kelimesini ve bağlantımızı verdik.
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); // sqlCommand çalıştırıldığında dönecek kayıtları okumak için sqlDataReader oluşturduk.
            while (sqlDataReader.Read()) // sqlDataReader dan kayıt okunduğu sürece 
            {
                Urun urun = new Urun()
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    StokMiktari = Convert.ToInt32(sqlDataReader["StokMiktari"]),
                    UrunAdi = sqlDataReader["UrunAdi"].ToString(),
                    UrunFiyati = Convert.ToDecimal(sqlDataReader["UrunFiyati"]) 
                };
                urunler.Add(urun); // db den gelen ürünü yukarıdaki boş listeye ekliyoruz.
            }
            sqlDataReader.Close(); // kapat
            sqlCommand.Dispose();  // yoket
            connection.Close();    // kapat     
            return urunler;        // bu metodun kullanılacağı yere ürünler gönder. 
        }
        public DataTable UrunleriDataTableileGetir()
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from urunler", connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            table.Load(sqlDataReader); // veritabanından çekilen verileri table a yükle.
            sqlDataReader.Close(); // kapat
            sqlCommand.Dispose();  // yoket
            connection.Close();    // kapat
            return table; 
        }
        public int Add(Urun urun)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("insert into urunler (StokMiktari, UrunAdi, UrunFiyati) values (@StokMiktari, @UrunAdi, @UrunFiyati) ", connection); // insert ile değer ekleme.
            sqlCommand.Parameters.AddWithValue("@StokMiktari" , urun.StokMiktari);
            sqlCommand.Parameters.AddWithValue("@UrunAdi" , urun.UrunAdi);
            sqlCommand.Parameters.AddWithValue("@UrunFiyati" , urun.UrunFiyati);
            islemSonucu = sqlCommand.ExecuteNonQuery(); // sorgu çalıştığında sql den bize etkilenen kayıt sayısı döner, işlem başarılıysa 0 dan büyük (genelde 1) değer gelir.
            sqlCommand.Dispose(); // yoket
            connection.Close();   // bağlantıyı kapat.
            return islemSonucu;   // eklemeden sonra geriye işlem sonucu döndür.

        }
        public int Update(Urun urun)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("update urunler set StokMiktari=@StokMiktari, UrunAdi=@UrunAdi, UrunFiyati=@UrunFiyati where Id=@UrunId", connection); // update set ile değer güncelleme
            sqlCommand.Parameters.AddWithValue("@UrunId", urun.Id);
            sqlCommand.Parameters.AddWithValue("@StokMiktari", urun.StokMiktari);
            sqlCommand.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            sqlCommand.Parameters.AddWithValue("@UrunFiyati", urun.UrunFiyati);
            islemSonucu = sqlCommand.ExecuteNonQuery(); // sorgu çalıştığında sql den bize etkilenen kayıt sayısı döner, işlem başarılıysa 0 dan büyük (genelde 1) değer gelir.
            sqlCommand.Dispose(); // yoket
            connection.Close();   // bağlantıyı kapat.
            return islemSonucu;   // eklemeden sonra geriye işlem sonucu döndür.

        }
        public int Delete(int id)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("delete from urunler where Id=@UrunId", connection);
            sqlCommand.Parameters.AddWithValue("@UrunId", id);
            islemSonucu = sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose(); // yoket
            connection.Close();   // bağlantıyı kapat.
            return islemSonucu;
        }
    }
}
