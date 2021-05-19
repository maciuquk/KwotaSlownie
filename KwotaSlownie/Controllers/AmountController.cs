using KwotaSlownie.Models;
using KwotaSlownie.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwotaSlownie.Controllers
{
    public class AmountController : Controller
    {
        public IActionResult Index(AmountModel amountFromView)
        {
            return View(amountFromView);
        }

        [HttpPost]
        public IActionResult AmountInWords(AmountModel amountFromView)
        {
            if (amountFromView.Amount.Contains(".") || !amountFromView.Amount.Contains(","))
            {
                amountFromView.Amount = "Wpisz poprawdne dane!";
                return RedirectToAction("Index", amountFromView);
            }


            var amountInWords = AmountToWords.ToWords(amountFromView.Amount);

            var newAmount = new AmountModel { Amount = amountFromView.Amount, AmountInWords = amountInWords, IsNBPCurrency = amountFromView.IsNBPCurrency };

            return RedirectToAction("Index",newAmount);
        }
    }
}
 