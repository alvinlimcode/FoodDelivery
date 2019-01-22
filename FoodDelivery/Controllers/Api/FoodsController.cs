using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDelivery.Service.Foods;
using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    public class FoodsController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly IFoodTypeService _foodTypeService;

        public FoodsController(
            IFoodService foodService,
            IFoodTypeService foodTypeService
        )
        {
            _foodService = foodService;
            _foodTypeService = foodTypeService;
        }

        public async Task<IActionResult> AllFoods()
        {
            var foods = await _foodService.GetAllFoodsAsync();

            return Json(new { isSuccess = true, data = foods });
        }

        public async Task<IActionResult> FoodsByType(long id)
        {
            var foods = await _foodService.GetAllFoodsByFoodTypeIdAsync(id);

            return Json(new { isSuccess = true, data = foods });
        }
    }
}