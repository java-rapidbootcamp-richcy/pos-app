using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    [Table("tbl_order_detail")]
    public class OrderDetailEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Required]
        public OrderEntity Order { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Required]
        public ProductEntity Product { get; set; }

        [Required]
        [Column("unit_price")]
        public double UnitPrice { get; set; }

        [Required]
        [Column("quantity")]
        public long Quantity { get; set; }

        [Required]
        [Column("discount")]
        public Double Discount { get; set; }

        public OrderDetailEntity()
        {

        }

        public OrderDetailEntity(POS.ViewModel.OrderDetailModel model)
        {
            OrderId = model.OrderId;
            ProductId = model.ProductId;
            UnitPrice = model.UnitPrice;
            Quantity = model.Quantity;
            Discount = model.Discount;
        }
    }
    
}
