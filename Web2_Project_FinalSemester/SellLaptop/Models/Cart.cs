using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellLaptop.Models
{
    public class Cart
    {
        public IList<CartItem> Items { get; }
        public Cart()
        {
            Items = new List<CartItem>();
        }
    }

    public class CartItem
    {
        public san_pham sp { get; set; }
        public int Quatity { get; set; }
    }
}