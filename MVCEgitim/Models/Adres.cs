﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEgitim.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string AcikAdres { get; set; }
    }
}