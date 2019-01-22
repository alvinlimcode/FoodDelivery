using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDelivery.Core.Extensions;
using FoodDelivery.Data.Entities.Foods;
using FoodDelivery.Data.Entities.Foods.ViewModels;
using FoodDelivery.Repository;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Service.Foods
{
    public class FoodService : IFoodService
    {
        private readonly IRepository<Food> _repositoryFood;
        
        public FoodService (
            IRepository<Food> repositoryFood
        )
        {
            _repositoryFood = repositoryFood;
        }

        public async Task<IList<FoodListingViewModel>> GetAllFoodsAsync()
        {
            var foods = await _repositoryFood.GetAll().ToListAsync();

            var foodListing = new List<FoodListingViewModel>();

            foreach(var food in foods)
            {
                foodListing.Add(new FoodListingViewModel
                {
                    Id = food.Id, 
                    Name = food.Name, 
                    ImageUrl = food.ImageUrl,
                    SeoFriendlyUrl = food.Name.SeoFriendlyUrl(),
                    Price = food.Price
                });
            }

            return foodListing;
        }

        public async Task<IList<Food>> GetAllFoodsByFoodTypeIdAsync(long foodTypeId)
        {
            var foods = await _repositoryFood.GetAll()
                .Where(q => q.FoodType.Id == foodTypeId)
                .ToListAsync();

            return foods;
        }

        public async Task<Food> GetFoodByIdAsync(long id)
        {
            var food = await _repositoryFood.GetAll()
                .FirstOrDefaultAsync(q => q.Id == id);

            return food;
        }
    }
}
