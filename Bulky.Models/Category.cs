using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }



        [Required(ErrorMessage = "Please enter a Name")]
        [DisplayName("Category Name")]
        [MaxLength(255, ErrorMessage = "The name must be lesser than 255 characters")]
        public string Name { get; set; }



        [DisplayName("Display Order")]
        [Range(1, 100,ErrorMessage = "The number must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}