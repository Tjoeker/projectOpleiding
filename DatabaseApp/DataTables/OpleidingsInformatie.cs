using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.DataTables
{
    public class OpleidingsInformatie
    {
        public int Id { get; set; }
        public string Opleidingsinstelling { get; set; }
        public string Opleiding { get; set; }
        public string Contactpersoon { get; set; }
        public string Opleidingsplaats { get; set; }
        public string ReferentieOpleidingsplaats { get; set; }
        public int OeNummer { get; set; }
        public int Opleidingscode { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
    }
}
