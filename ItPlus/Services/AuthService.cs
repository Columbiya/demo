using ItPlus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ItPlus.Services
{
    public class AuthService
    {
        public static int Authorization(string username, string password)
        {
            using var ctx = new ItPlusContext();

            var candidate = ctx.Users.Where(x => x.Login == username && x.Password == password).FirstOrDefault();

            if (candidate == null)
            {
                return -1;
            } 

            var id = candidate.IdUsers;

            return id;
        }
    }
}
