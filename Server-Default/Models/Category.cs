using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Server_Default.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
        [MaxLength(100)]
        public string Category_Name { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();

    }
}
