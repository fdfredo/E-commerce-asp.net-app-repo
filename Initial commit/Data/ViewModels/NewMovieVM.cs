using etickets1.Data.Base;
using etickets1.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace etickets1.Models
{
    public class NewMovieVM
    {

		public int Id { get; set; }

		[Display(Name = "Movie Name")]
		[Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

		[Display(Name = "Movie Description")]
		[Required(ErrorMessage = "Description is required")]
		public string Description { get; set; }

		[Display(Name = "Price in $")]
		[Required(ErrorMessage = "Price is required")]
		public double Price { get; set; }

		[Display(Name = "Movie ImageUrl")]
		[Required(ErrorMessage = "ImageUrl is required")]
		public string ImageURL { get; set; }

		[Display(Name = "Movie start Date")]
		[Required(ErrorMessage = "Start date is required")]
		public DateTime StartDate { get; set; }

		[Display(Name = "Movie end Date")]
		[Required(ErrorMessage = "End date is required")]
		public DateTime EndDate { get; set; }

		[Display(Name = "Select a category")]
		[Required(ErrorMessage = "Movie category is required")]
		public MovieCategory MovieCategory { get; set; }


		//Relationship

		[Display(Name = "Select actor(s)")]
		[Required(ErrorMessage = "Movie actor(s) is required")]
		public List<int> ActorIds { get; set; }

		[Display(Name = "Select cinema")]
		[Required(ErrorMessage = "Movie cinema is required")]
		public int CinemaId { get; set; }

		[Display(Name = "Select producer")]
		[Required(ErrorMessage = "Movie producer is required")]
		public int ProducerId { get; set; }
        
    }
}
