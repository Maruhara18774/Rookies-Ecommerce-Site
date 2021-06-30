using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DTO2.Model
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }

        [MaxLength(100)]
        public string Product_Name { get; set; }

        [Range(minimum:0,maximum:double.MaxValue)]
        public double Product_Price { get; set; }

        public string Product_Description { get; set; }

        public int Category_ID { get; set; }

        public int ProductState_ID { get; set; }


        public Category Category { get; set; }

        public List<Size> Sizes { get; set; }
        public ProductState ProductState { get; set; }

        public Product(int id, string name, double price, string description, int cateId, int stateId)
        {
            this.Product_ID = id;
            this.Product_Name = name;
            this.Product_Price = price;
            this.Product_Description = description;
            this.Category_ID = cateId;
            this.ProductState_ID = stateId;
        }
    }
}
