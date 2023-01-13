using System.ComponentModel.DataAnnotations;

namespace POS.ViewModel
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
