﻿using System;
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
        public virtual OpleidingsInformatie Opleiding { get; set; }
        public virtual Deelnemers Deelnemers { get; set; }
    }
}
