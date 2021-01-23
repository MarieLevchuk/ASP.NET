using LinqToDB;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
using static LinqToDB.Reflection.Methods.LinqToDB;

namespace LoginPage.Models
{
    public class UsersDAL
    {
        string _connectionString = "Data Source=HOME-1;Initial Catalog=UsersDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public User GetUserByRegistrationData(string login, string password)
        {
            DataContext dataContext = new DataContext(_connectionString);
            var user = dataContext.GetTable<User>().Where(u => u.Login == login && u.Password==password);
            
            return user.FirstOrDefault();
        }
    }
}
