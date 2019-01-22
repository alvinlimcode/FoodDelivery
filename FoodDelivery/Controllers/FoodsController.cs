using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDelivery.Service.Foods;
using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Controllers
{
    public class FoodsController : BaseController
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

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Route("foods/details/{id}/{name}")]
        public async Task<IActionResult> Details(long id)
        {
            var food = await _foodService.GetFoodByIdAsync(id);

            return View(food);
        }

        [Route("foods/type/{id}/{name}")]
        public async Task<IActionResult> FoodsByType(long id, string name)
        {
            var foods = await _foodService.GetAllFoodsByFoodTypeIdAsync(id);

            var foodType = await _foodTypeService.GetFoodTypeByIdAsync(id);
            ViewBag.FoodType = foodType?.Name ?? name;
            ViewBag.FoodTypeId = foodType.Id;

            return View(foods);
        }
    }
}