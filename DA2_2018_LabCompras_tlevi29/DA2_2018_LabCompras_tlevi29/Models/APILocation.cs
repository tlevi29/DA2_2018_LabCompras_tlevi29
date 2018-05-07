using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class APILocation
    {

        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Tz_id { get; set; }
        public int Localtime_epoch { get; set; }
        public DateTime Localtime { get; set; }

    }
}
