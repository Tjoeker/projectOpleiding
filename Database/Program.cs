using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    public static class Program
    {

        public static void LinkDatabase()
        {
            using (var context = new DatabaseContext())
            {
                var lijst = context.Docenten.FirstOrDefault(a=> a.Id == 0);
            }
        }
    }
}
