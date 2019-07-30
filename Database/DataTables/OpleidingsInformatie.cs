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
        public string OeNummer { get; set; }
        public string Opleidingscode { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public List<Docenten> Docentens { get; set; }
        public List<Deelnemers> Deelnemers { get; set; }

        public override string ToString()
        {
            return Opleiding + ",  " + Opleidingsplaats + ",  " + StartDatum.ToShortDateString();
        }
    }
}
