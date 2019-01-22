using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Data.Entities.Foods.ViewModels
{
    public class FoodListingViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string SeoFriendlyUrl { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
