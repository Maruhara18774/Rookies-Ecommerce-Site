using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
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

        public int Product_ID { get; set; }

        public Product Product { get; set; }

        public List<ProductImage> ProductImages { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        //public ProductDetail(int id, string textureName, string textureImage, int quantity, DateTime createDate, int productId)
        //{
        //    this.ProductDetail_ID = id;
        //    this.Texture_Name = textureName;
        //    this.Texture_Image = textureImage;
        //    this.ProductDetail_Quantity = quantity;
        //    this.ProductDetail_CreatedDate = createDate;
        //    this.ProductDetail_UpdatedDate = createDate;
        //    this.Product_ID = productId;
        //}
    }
}
