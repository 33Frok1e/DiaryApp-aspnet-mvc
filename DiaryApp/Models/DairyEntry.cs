using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DairyEntry
    {
        // [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title")]
        // [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 Characters!")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please select Date and Time")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
