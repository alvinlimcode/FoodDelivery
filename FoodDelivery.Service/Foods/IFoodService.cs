using FoodDelivery.Data.Entities.Foods;
using FoodDelivery.Data.Entities.Foods.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Service.Foods
{
    public interface IFoodService
    {
        Task<IList<FoodListingViewModel>> GetAllFoodsAsync();

        Task<IList<Food>> GetAllFoodsByFoodTypeIdAsync(long foodTypeId);

        Task<Food> GetFoodByIdAsync(long id);
    }
}
