using etickets1.Data.Base;
using etickets1.Models;

namespace etickets1.Data.Services
{
	public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
	{
		public CinemasService(AppDbContext context) : base(context)
		{
		}
	}
}
