using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class ProductImage
    {
        [Key]
        public int ProductImage_ID { get; set; }

        public string ProductImage_Image { get; set; }

        public int ProductDetail_ID { get; set; }

        public ProductDetail ProductDetail { get; set; }

        public ProductImage(int id, string image, int productDetailId)
        {
            this.ProductImage_ID = id;
            this.ProductImage_Image = image;
            this.ProductDetail_ID = productDetailId;
        }
    }
}
