using System.Collections.Generic;
using WeLoveVocalEDM.Models;

namespace WeLoveVocalEDM.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
