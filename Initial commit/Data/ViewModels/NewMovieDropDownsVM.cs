using etickets1.Controllers;
using etickets1.Models;
using System.Collections.Generic;

namespace etickets1.Data.ViewModels
{
	public class NewMovieDropDownsVM
	{
        public NewMovieDropDownsVM()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }


        public List<Producer> Producers { get; set; }
		public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
