using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Data.Entities.ShoppingCarts.ViewModels
{
    public class ShoppingCartItemViewModel
    {
        public long ShoppingCartItemId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
