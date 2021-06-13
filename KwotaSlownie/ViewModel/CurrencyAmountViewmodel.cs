using KwotaSlownie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwotaSlownie.ViewModel
{
    public class CurrencyAmountViewmodel
    {
        public List<CurrencyModel> Amounts { get; set; }
        public decimal UserAmount { get; set; }
        public decimal ChoosedCurrency { get; set; }
        public string Info1 { get; set; }
    }
}
