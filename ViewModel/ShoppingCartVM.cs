using OnlineStoreForJewellery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreForJewellery.ViewModel
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; }
        //public double CartTotal { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
