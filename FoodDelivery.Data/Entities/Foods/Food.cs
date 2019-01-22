using FoodDelivery.Data.Entities.Restaurants;
using FoodDelivery.Data.Entities.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodDelivery.Data.Entities.Foods
{
    public class Food : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        [MaxLength(500)]
        public string ImageUrl { get; set; }

        public FoodType FoodType { get; set; }

        public Restaurant Restaurant { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public IList<Review> Reviews { get; set; }
    }
}
