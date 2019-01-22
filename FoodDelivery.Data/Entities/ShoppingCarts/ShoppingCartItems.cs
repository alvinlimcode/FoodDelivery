using FoodDelivery.Data.Entities.Foods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDelivery.Data.Entities.ShoppingCarts
{
    public class ShoppingCartItems : BaseEntity
    {
        public ShoppingCart ShoppingCart { get; set; }

        public Food Food { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [MaxLength(500)]
        public string Remark { get; set; }
    }
}
