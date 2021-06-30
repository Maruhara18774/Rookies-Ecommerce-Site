using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Default.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetail_ID { get; set; }

        [Range(minimum: 0, maximum: int.MaxValue)]
        public int OrderDetail_Quantity { get; set; }

        [Range(minimum: 0, maximum: double.MaxValue)]
        public double OrderDetail_Total { get; set; }

        public virtual Order Order { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }

    }
}
