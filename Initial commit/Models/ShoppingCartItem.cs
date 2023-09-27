using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
	public class ShoppingCartItem
	{
		[Key]
		public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }

        public string ShoppingcartId { get; set; }
    }
}
