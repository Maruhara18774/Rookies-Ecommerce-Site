using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetail_ID { get; set; }

        public string Texture_Name { get; set; }

        public string Texture_Image { get; set; }

        [Range(minimum: 0, maximum: int.MaxValue)]
        public int ProductDetail_Quantity { get; set; }

        public DateTime ProductDetail_CreatedDate { get; set; }

        public DateTime ProductDetail_UpdatedDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual List<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

        public virtual List<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    }
}
