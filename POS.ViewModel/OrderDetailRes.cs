using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModel
{
    public class OrderDetailRes
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double Subtotal { get; set; }
    }
}