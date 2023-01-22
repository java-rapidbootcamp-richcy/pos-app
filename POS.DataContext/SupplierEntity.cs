using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    [Table("tbl_supplier")]
    public class SupplierEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("company_name")]
        public string CompanyName { get; set; }

        [Required]
        [Column("contact_name")]
        public string ContactName { get; set; }

        [Required]
        [Column("contact_title")]
        public string ContactTitle { get; set; }

        [Required]
        [Column("address")]
        public string Address { get; set; }

        [Required]
        [Column("city")]
        public string City { get; set; }

        [Required]
        [Column("region")]
        public string Region { get; set; }

        [Required]
        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Required]
        [Column("country")]
        public string Country { get; set; }

        [Required]
        [Column("phone")]
        public string Phone { get; set; }

        [Required]
        [Column("fax")]
        public string Fax { get; set; }

        [Required]
        [Column("home_page")]
        public string HomePage { get; set; }

        public ICollection<ProductEntity> productEntities { get; set; }
        public SupplierEntity()
        {

        }

        public SupplierEntity(POS.ViewModel.SupplierModel model)
        {
            CompanyName = model.CompanyName;
            ContactName = model.ContactName;
            ContactTitle = model.ContactTitle;
            Address = model.Address;
            City = model.City;
            Region = model.Region;
            PostalCode = model.PostalCode;
            Country = model.Country;
            Phone = model.Phone;
            Fax = model.Fax;
            HomePage = model.HomePage;
        }
    }
}
