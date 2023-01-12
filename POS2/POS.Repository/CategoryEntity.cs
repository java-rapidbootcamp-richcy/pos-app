using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Repository
{
    [Table("tbl_category")]
    public class CategoryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("category_name")]
        public string CategoryName { get; set; }
        [Required]
        [Column("description")]
        public string Description { get; set; }

        public ICollection<ProductEntity> productEntities { get; set; }
        public CategoryEntity(POS.ViewModel.CategoryModel model)
        {
            CategoryName = model.CategoryName;
            Description = model.Description;
        }
        public CategoryEntity()
        {
                    
        }


    }
}