using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwotaSlownie.Models
{
    public class CurrencyModel
    {
        public string Date { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public decimal Currency { get; set; }
        public decimal UserAmount { get; set; }
    }
}
