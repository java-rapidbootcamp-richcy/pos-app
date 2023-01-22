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

        public OrderEntity Order { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public ProductEntity Product { get; set; }

        [Column("unit_price")]
        public double UnitPrice { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("discount")]
        public double Discount { get; set; }

        public OrderDetailEntity()
        {

        }

        public OrderDetailEntity(POS.ViewModel.OrderDetailModel model)
        {
            Id = model.Id;
            OrderId = model.OrderId;
            ProductId = model.ProductId;
            UnitPrice = model.UnitPrice;
            Quantity = model.Quantity;
            Discount = model.Discount;
        }
    }
    
}
