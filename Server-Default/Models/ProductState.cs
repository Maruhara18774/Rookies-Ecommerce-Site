using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Default.Models
{
    public class ProductState
    {
        [Key]
        public int ProductState_ID { get; set; }

        public string ProductState_Name { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
