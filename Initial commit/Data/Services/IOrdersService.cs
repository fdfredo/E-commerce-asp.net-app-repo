using etickets1.Data.Static;
using etickets1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace etickets1.Data.Services
{
	public interface IOrdersService
	{
		Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
		Task<List<Order>> GetOrderByUserIdAndRoleAsync(string userId, string userRole);
	}
}
