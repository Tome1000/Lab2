using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
