using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Default.Models
{
    public class ProductImage
    {
        [Key]
        public int ProductImage_ID { get; set; }

        public string ProductImage_Image { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }

    }
}
