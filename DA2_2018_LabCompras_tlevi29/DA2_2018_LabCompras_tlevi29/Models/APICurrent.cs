using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class APICurrent
    {
        public double Temp_c { get; set; }
        public APICurrentCondition Condition { get; set; }

        public class APICurrentCondition
        {
            public string Text { get; set; }
            public string Icon { get; set; }
        }

    }
}
