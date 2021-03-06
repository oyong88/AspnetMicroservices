using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }

        public ShoppingCart()
        {

        }

        public ShoppingCart(string userName)
        {
            this.UserName = userName;
        }

        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach(var item in Items)
                {
                    total = total + (item.Quantity * item.Price);
                }
                return total;
            }
        }
    }
}
