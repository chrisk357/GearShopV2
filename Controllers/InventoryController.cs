using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GearShopV2.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Jersey()
        {
            return View();
        }
        public IActionResult Pant()
        {
            return View();
        }
    }
}