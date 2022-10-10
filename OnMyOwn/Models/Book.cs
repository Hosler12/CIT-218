using System.ComponentModel.DataAnnotations;

namespace OnMyOwn.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter a cost.")]
        public double ? Cost { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string Genre { get; set; }
    }
}
