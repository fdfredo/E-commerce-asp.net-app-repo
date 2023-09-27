using etickets1.Data.Base;
using etickets1.Models;

namespace etickets1.Data.Services
{
	public class ProducersService:EntityBaseRepository<Producer>, IProducersService
	{
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
