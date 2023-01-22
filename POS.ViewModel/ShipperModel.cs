using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModel
{
    public class ShipperModel
    {
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Phone { get; set; }
    }

}