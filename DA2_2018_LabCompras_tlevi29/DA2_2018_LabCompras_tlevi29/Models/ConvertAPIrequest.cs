using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class ConvertApiRequest
    {
        public double Amount { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public ConvertApiRequest( double amount, string from, string to)
        {
            Amount = amount;
            From = from;
            To = to;
        }
    }
}
