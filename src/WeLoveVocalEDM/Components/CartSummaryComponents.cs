using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeLoveVocalEDM.Models;

namespace WeLoveVocalEDM.Components
{
    public class CartSummaryComponents
    {

        [ViewComponent(Name = "CartSummary")]
        public class CartSummaryComponent : ViewComponent
        {
            public CartSummaryComponent(WeLoveVocalEDMContext dbContext)
            {
                DbContext = dbContext;
            }

            private WeLoveVocalEDMContext DbContext { get; }

            public async Task<IViewComponentResult> InvokeAsync()
            {
                var cart = ShoppingCart.GetCart(DbContext, HttpContext);

                var cartItems = await cart.GetCartAlbumTitles();

                ViewBag.CartCount = cartItems.Count;
                ViewBag.CartSummary = string.Join("\n", cartItems.Distinct());

                return View();
            }
        }
    }
}
