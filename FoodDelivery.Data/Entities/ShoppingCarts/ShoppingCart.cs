using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDelivery.Data.Entities.ShoppingCarts
{
    public class ShoppingCart : BaseEntity
    {
        public string UserId { get; set; }

        public DateTime DeliveryDateTime { get; set; }

        [MaxLength(250)]
        public string DeliveryAddress { get; set; }

        public decimal DeliveryFee { get; set; }
    }
}
