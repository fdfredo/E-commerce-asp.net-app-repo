using etickets1.Data.Base;
using etickets1.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace etickets1.Data.Services
{
	public class ActorsService :EntityBaseRepository<Actor>, IActorsService
	{
		private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context) { }
	}
}
