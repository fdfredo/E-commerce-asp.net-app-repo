using etickets1.Data.Cart;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace etickets1.Data.ViewComponents
{
	public class ShoppingCartSummary:ViewComponent
	{
		private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
			_shoppingCart = shoppingCart;
		}

		public IViewComponentResult Invoke()
		{
			var items = _shoppingCart.GetShoppingCartItems();
			return View(items.Count);
		}

    }
}
