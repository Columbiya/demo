using ItPlus.Model;
using ItPlus.Pages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItPlus.Services
{
    public class RequestService
    {
     
        public static List<Request> RequestList()
        {
            using ItPlusContext context = new ItPlusContext();
            return context.Requests.Include(r => r.StatusNavigation).Include(r => r.UserNavigation).Include(r => r.ResponseEemployeeNavigation).ToList();
        }
    }
}
