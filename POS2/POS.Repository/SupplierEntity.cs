using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Repository
{
    [Table("tbl_supplier")]
    public class SupplierEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
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
        public int PostalCode { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("fax")]
        public string Fax { get; set; }
        [Column("home_page")]
        public string HomePage { get; set; }

        public ICollection<ProductEntity> productEntities { get; set; }
    }
}