using FoodDelivery.Data.Entities.Foods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDelivery.Data.Entities.Reviews
{
    public class Review : BaseEntity
    {
        public Food Food { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [MaxLength(500)]
        public string Remark { get; set; }
    }
}
