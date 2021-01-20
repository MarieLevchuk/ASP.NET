using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class GoodsDAL
    {
        string _connectionString = "Data Source=HOME-1;Initial Catalog=OnlineStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Good> GetGoods(int catalogId)
        {
            List<Good> goodsList = new List<Good>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM [Goods] WHERE CatalogID = {catalogId}", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Good good = new Good();
                    good.GoodId = (int)reader["GoodID"];
                    good.Name = reader["Name"].ToString();
                    good.Price = (double)reader["Price"];
                    good.CatalogId = (int)reader["CatalogID"];

                    goodsList.Add(good);
                }
                connection.Close();
            }
            return goodsList;
        }
    }
}
