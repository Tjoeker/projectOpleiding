using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.DataTables
{
    public class NietOpleidingsDagen
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public bool Voormiddag { get; set; }
        public bool Namiddag { get; set; }
        public virtual OpleidingsInformatie Opleiding { get; set; }
    }
}
