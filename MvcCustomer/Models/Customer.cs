using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCustomer.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
        
    }
}
