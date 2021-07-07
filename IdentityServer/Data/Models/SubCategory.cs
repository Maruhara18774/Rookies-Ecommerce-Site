using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Data.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_ID { get; set; }
        [MaxLength(100)]
        public string SubCategory_Name { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
