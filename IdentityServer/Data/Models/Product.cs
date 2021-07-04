using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }

        [MaxLength(100)]
        public string Product_Name { get; set; }

        [Range(minimum: 0, maximum: double.MaxValue)]
        public double Product_Price { get; set; }

        public string Product_Description { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Size> Sizes { get; set; } = new List<Size>();
        public virtual ProductState ProductState { get; set; }

    }
}
