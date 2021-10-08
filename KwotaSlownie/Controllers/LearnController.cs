using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwotaSlownie.Controllers
{
    [Authorize]
    public class LearnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
