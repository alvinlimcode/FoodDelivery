using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDelivery.Data.Entities.Foods;
using FoodDelivery.Repository;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Service.Foods
{
    public class FoodTypeService : IFoodTypeService
    {
        private readonly IRepository<FoodType> _repositoryFoodType;
        
        public FoodTypeService(
            IRepository<FoodType> repositoryFoodType
        )
        {
            _repositoryFoodType = repositoryFoodType;
        }

        public async Task<IList<FoodType>> GetAvailableFoodTypesAsync()
        {
            var foodTypes = await _repositoryFoodType.GetAll().ToListAsync();

            return foodTypes;
        }

        public async Task<FoodType> GetFoodTypeByIdAsync(long id)
        {
            var foodType = await _repositoryFoodType.GetAll().FirstOrDefaultAsync(q => q.Id == id);

            return foodType;
        }
    }
}
