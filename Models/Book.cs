using System;
using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
		[Required(ErrorMessage = "Id is required.")]
		[StringLength(255)]
        public int Id { get; set; }
		[Required(ErrorMessage = "Name is required.")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Author name is required.")]
		public string AuthorName { get; set; }
		[Required(ErrorMessage = "Genre is required.")]
		public Genre Genre { get; set; }
		[Required(ErrorMessage = "Genre id is required.")]
		public byte GenreId { get; set; }
		[Required(ErrorMessage = "Date added is required.")]
		public DateTime DateAdded { get; set; }
		[Required(ErrorMessage = "Release date is required.")]
		public DateTime ReleaseDate { get; set; }
		[Required(ErrorMessage = "Number in stock is required.")]
		[Range(1, 20, ErrorMessage = "Number in stock must be metween 1 and 20.")]
		public int NumberInStock { get; set; }
		[Required(ErrorMessage = "Number available is required.")]
		public int NumberAvailable { get; set; }
	}
      
}
