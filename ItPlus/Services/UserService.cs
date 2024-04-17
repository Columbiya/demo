using ItPlus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItPlus.Services
{
    public class UserService
    {
        public static User GetUserById(int id)
        {
            return Appcontext.ctx.Users.Where(u => u.IdUsers == id).FirstOrDefault();
        }
    }
}
