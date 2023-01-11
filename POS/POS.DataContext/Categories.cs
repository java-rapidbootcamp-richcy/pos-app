using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.DataContext
{
    [Table("table_categories")]
    public class Categories
    {
        [Key]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }

        [Column("category_desription")]
        public string Description { get; set; }

        public ICollection<Products> Product { get; set; }
    }
}