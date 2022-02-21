using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BestBookWeb.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Order must be between 1 to 100!")]
        public int displayOrder { get; set; }
        public DateTime createdDateTime { get; set; } = DateTime.Now;
    }
}
