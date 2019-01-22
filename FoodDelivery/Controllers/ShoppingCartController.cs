using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Controllers
{
    public class ShoppingCartController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}