﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp.DataTables
{
    public class DeelnemersOpleidingen
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Woonplaats { get; set; }
        public string BadgeNummer { get; set; }
    }
}