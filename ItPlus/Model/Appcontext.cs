using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItPlus.Model
{
    public partial class Appcontext
    {
        public static ItPlusContext ctx = new ItPlusContext();

        public static User AuthUser { get; set; }
    }
}
