using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class CatalogsDAL
    {
        string _connectionString = "Data Source=HOME-1;Initial Catalog=OnlineStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<string> GetCatalogs()
        {
            List<string> catalogsList = new List<string>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT [Name] FROM [Catalogs]", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {              
                    catalogsList.Add(reader["Name"].ToString());
                }
                connection.Close();
            }
            return catalogsList;
        }
    }
}
