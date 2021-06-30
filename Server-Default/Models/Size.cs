using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Default.Models
{
    public class Size
    {
        [Key]
        public int Size_ID { get; set; }

        [MaxLength(10)]
        public string Size_Key { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();

    }
}
