using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.DataTables
{
    public class DeelnemersOpleidingen
    {
        public int Id { get; set; }
        public Deelnemers Deelnemers { get; set; }
        public OpleidingsInformatie Opleiding { get; set; }
}
}
