using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
        [MaxLength(100)]
        public string Category_Name { get; set; }
        public List<Product> Products { get; set; }

        /*
        public Category(int id, string name)
        {
            this.Category_ID = id;
            this.Category_Name = name;
        }
        */
    }
}
