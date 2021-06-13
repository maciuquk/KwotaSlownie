using KwotaSlownie.Models;
using KwotaSlownie.Services;
using KwotaSlownie.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwotaSlownie.Controllers
{
    public class CurrencyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //ściągnij daty i waluty z ostatniego miesiąca 

            var currencyList = new List<CurrencyModel>();
            GetCurrency get = new GetCurrency();

            currencyList = await get.ParseRSS();
            //var caurrencyList = get.ParseRSS();
            var amountViewModel = new CurrencyAmountViewmodel();
            amountViewModel.Amounts = currencyList;
            


            return View(amountViewModel);
        }
        [HttpPost]
        public IActionResult CalculatedCurrency(CurrencyAmountViewmodel model)
        {
            var amountChoosed= model.ChoosedCurrency / 10000;
            model.ChoosedCurrency = amountChoosed;

            if (model.UserAmount == 0)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
