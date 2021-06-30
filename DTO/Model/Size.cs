using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Size
    {
        [Key]
        public int Size_ID { get; set; }

        [MaxLength(10)]
        public string Size_Key { get; set; }

        public List<Product> Products { get; set; }

        //public Size(int id, string key)
        //{
        //    this.Size_ID = id;
        //    this.Size_Key = key;
        //}
    }
}
