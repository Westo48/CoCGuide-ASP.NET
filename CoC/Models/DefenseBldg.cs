using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoC.Models
{
    public class DefenseBldg : Building
    {
        public int DPS { get; set; }
        public double DPH { get; set; }
        public int TH { get; set; }

    }
}