using etickets1.Data.Base;
using etickets1.Data.ViewModels;
using etickets1.Models;
using System.Threading.Tasks;

namespace etickets1.Data.Services
{
	public interface IMoviesService:IEntityBaseRepository<Movie>
	{
		Task<Movie> GetMoviesByIdAsync(int id);
		Task<NewMovieDropDownsVM> GetNewMovieDropDownsValues();

		Task AddNewMovieAsync(NewMovieVM data);
		Task UpdateMovieAsync(NewMovieVM data);
	}
}