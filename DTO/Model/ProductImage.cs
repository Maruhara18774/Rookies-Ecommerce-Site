using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class ProductImage
    {
        [Key]
        public int ProductImage_ID { get; set; }

        public string ProductImage_Image { get; set; }

        public ProductDetail ProductDetail { get; set; }

        //public ProductImage() { }
        //public ProductImage(int id, string image, int productDetailId)
        //{
        //    this.ProductImage_ID = id;
        //    this.ProductImage_Image = image;
        //    this.ProductDetail_ID = productDetailId;
        //}
    }
}
