using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class ConvertApiResponse
    {
        public double Amount { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public double ConvertedAmount { get; set; }
    }
}
