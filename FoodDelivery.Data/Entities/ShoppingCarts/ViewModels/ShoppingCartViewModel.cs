using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDelivery.Data.Entities.ShoppingCarts.ViewModels
{
    public class ShoppingCartViewModel
    {
        [MaxLength(250)]
        public string DeliveryAddress { get; set; }

        public IList<ShoppingCartItemViewModel> Items { get; set; } = new List<ShoppingCartItemViewModel>();
    }
}
