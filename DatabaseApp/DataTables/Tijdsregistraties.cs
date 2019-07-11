using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.DataTables
{
    public class Tijdsregistraties
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int OpleidingId { get; set; }
        public int DeelnemerId { get; set; }
    }
}
