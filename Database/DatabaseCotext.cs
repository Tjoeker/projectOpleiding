using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseApp.DataTables;

namespace DatabaseApp
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("OpleidingDatabase")
        {

        }

        public DbSet<Deelnemers> Deelnemers { get; set; }
        public DbSet<Tijdsregistraties> Tijdsregistraties { get; set; }
        public DbSet<OpleidingsInformatie> OpleidingsInformatie { get; set; }
        public DbSet<NietOpleidingsDagen> NietOpleidingsDagen { get; set; }
        public DbSet<Docenten> Docenten { get; set; }
    }
}
