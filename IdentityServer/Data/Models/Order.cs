using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data.Models
{
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Range(minimum: 0, maximum: double.MaxValue)]
        public double Order_Total { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OrderState OrderState { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}
