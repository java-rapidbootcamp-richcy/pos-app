using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    [Table("table_suppliers")]
    public class Suppliers
    {
        [Key]
        [Column("supplier_id")]
        public int SupplierId { get; set; }

        [Column("company_name")]
        public string CompanyName { get; set; }

        [Column("contact_name")]
        public string ContactName { get; set; }

        [Column("contact_title")]
        public string ContactTitle { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("region")]
        public string Region { get; set; }

        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("fax")]
        public string Fax { get; set; }

        [Column("homepage")]
        public string Homepage { get; set; }

        public ICollection<Products> Product { get; set; }
    }
}
