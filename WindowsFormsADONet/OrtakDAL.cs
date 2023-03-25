using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsADONet
{
    public class OrtakDAL
    {
        // Bu class ürün ile alakalı veritabanı işlemleri için 
        public SqlConnection connection = new SqlConnection(@"Server=.; database=AdoNetDb; trusted_connection=true"); // veritabanına bağlamak için gerekli bağlantı nesnesi. Connectionstring veritabanı bağlantı bilgileridir.
        public void BaglantiyiAc()
        {
            if (connection.State == ConnectionState.Closed) // veritabanı bağlantısı kapalıysa
            {
                connection.Open(); // bağlantıyı aç
            }

        }
        public DataTable GetAllDataTable(string sql)
        {
            DataTable table = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            table.Load(sqlDataReader); // veritabanından çekilen verileri table a yükle.
            sqlDataReader.Close(); // kapat
            sqlCommand.Dispose();  // yoket
            connection.Close();    // kapat
            return table;

        }
    }
}

