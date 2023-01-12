﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Repository
{
    [Table("tbl_order")]
    public class OrderEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
         public int CustomerId { get; set; }

        public CustomerEntity Customers { get; set; }
        
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        public EmployeeEntity Employees { get; set; }

        [Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Column("required_date")]
        public DateTime RequiredDate { get; set; }

        [Column("shipped_date")]
        public DateTime ShippedDate { get; set; }

        [Column("ship_via")]
        public int ShipVia { get; set; }

        [Column("freight")]
        public int Freight { get; set; }

        [Column("ship_name")]
        public string ShipName { get; set; }

        [Column("ship_address")]
        public string ShipAddress { get; set; }

        [Column("ship_city")]
        public string ShipCity { get; set; }

        [Column("ship_region")]
        public string ShipRegion { get; set; }

        [Column("ship_postal_code")]
        public string ShipPostalCode { get; set; }

        [Column("ship_country")]
        public string ShipCountry { get; set; }

        public ICollection<OrderDetailEntity> orderDetailsEntities { get; set; }

    }
}