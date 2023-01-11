using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.DataContext
{
    [Table("table_products")]
    public class Products
    {
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("product_name")]
        public string ProductName { get; set; }

        [Column("supplier_id")]
        public int SupplierId { get; set; }
        public Suppliers Supplier { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }
        public Categories Categoroy { get; set; }

        [Column("quantity_per_unit")]
        public string QuantityPerUnit { get; set; }

        [Column("unit_price")]
        public int UnitPrice { get; set; }

        [Column("units_in_stock")]
        public int UnitsInStock { get; set; }

        [Column("units_on_order")]
        public int UnitsOnOrder { get; set; }

        [Column("reorder_level")]
        public int ReorderLevel { get; set; }

        [Column("discontinued")]
        public bool Discontinued { get; set; }

        public ICollection<OrderDetails> OrderDetail { get; set; }
    }
}