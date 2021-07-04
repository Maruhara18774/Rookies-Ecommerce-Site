using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data.Models
{
    public class Country
    {
        [Key]
        public int Country_ID { get; set; }

        [MaxLength(100)]
        public string Country_Name { get; set; }

        public virtual List<Customer> Customers { get; set; } = new List<Customer>();

    }
}
