using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Repository
{
    [Table("tbl_order_details")]
    public class OrderDetailEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("order_id")]
        public OrderEntity Orders { get; set; }

        [Column("product_id")]
        public ProductEntity Product { get; set; }

        [Column("unit_price")]
        public int UnitPrice { get; set; }

        [Column("quantity")]
        public long Quantity { get; set; }

        [Column("discount")]
        public Double Discount { get; set; }
    }
}