using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class ProductState
    {
        [Key]
        public int ProductState_ID { get; set; }

        public string ProductState_Name { get; set; }

        public List<Product> Products { get; set; }

        public ProductState(int id, string name)
        {
            this.ProductState_ID = id;
            this.ProductState_Name = name;
        }
    }
}
