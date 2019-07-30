using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.DataTables
{
    public class Docenten
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Bedijf { get; set; }
        public virtual List<OpleidingsInformatie> Opleidings { get; set; }
        public override string ToString()
        {
            return Naam + ",  " + Bedijf;
        }
    }
}
