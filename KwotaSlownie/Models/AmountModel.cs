using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwotaSlownie.Models
{
    public class AmountModel
    {
        public string Amount { get; set; }
        public string AmountInWords { get; set; }
        //public bool IsPolish { get; set; }
        //public bool IsEnglish { get; set; }
        public bool IsNBPCurrency { get; set; }

    }


}
