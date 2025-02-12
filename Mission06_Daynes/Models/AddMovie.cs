using System.ComponentModel.DataAnnotations;

namespace Mission06_Daynes.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }   // Nullable bool
        public string? LentTo { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
