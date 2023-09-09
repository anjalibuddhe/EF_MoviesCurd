using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_MoviesCurd.Models
{
    [Table("MOVIES")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name  { get; set; }

        [NotMapped]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Stars { get; set; }
        public int IsActive { get; set; }
        
    }
}
