using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart { get; }
        public CartSummaryViewComponent(Cart cartSerivce)
        {
            cart = cartSerivce;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }

    }
}
