﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.DataTables
{
    public class DocentenOpleidingen
    {
        public int Id { get; set; }
        public Docenten Docenten { get; set; }
        public OpleidingsInformatie Opleiding { get; set; }
    }
}
