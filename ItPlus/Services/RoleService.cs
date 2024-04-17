using ItPlus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItPlus.Services
{
    public class RoleService
    {
        public enum Roles
        {
            Client = 1,
            Employee,
            Mechanic
        }

        public static bool CanLeaveRequest()
        {
            return Appcontext.AuthUser == null || Appcontext.AuthUser.Role == Convert.ToInt32(Roles.Client);
        }
    }
}
