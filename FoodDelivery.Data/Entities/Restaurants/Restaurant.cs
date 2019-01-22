using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDelivery.Data.Entities.Restaurants
{
    public class Restaurant : BaseEntity
    {
        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string ImageUrl { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }
    }
}
