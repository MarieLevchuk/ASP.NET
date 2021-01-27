using ModelsLibrary;
using System;
using System.Linq;

namespace DAL
{
    public class UserData
    {
        public static User GetUserByRegistrationData(string login, string password)
        {
            using (var db = new UserContext())
            {
                var user = db.Users.Where(u => u.Login == login && u.Password == password);
                return user.FirstOrDefault();
            }
        }
    }
}
