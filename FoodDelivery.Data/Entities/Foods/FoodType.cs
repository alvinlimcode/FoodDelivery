using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDelivery.Data.Entities.Foods
{
    public class FoodType : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
