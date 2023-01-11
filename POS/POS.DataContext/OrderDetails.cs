using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DataContext
{
    [Table("table_order_details")]
    public class OrderDetails
    {
        [Key]
        [Column("order_details_id")]
        public int OrderDetailsId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }
        public Orders Order { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }
        public Products Product { get; set; }

        [Column("price")]
        public int Price { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("discount")]
        public int Discount { get; set; }

    }
}