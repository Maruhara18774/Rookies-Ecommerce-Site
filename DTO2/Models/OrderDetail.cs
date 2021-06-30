using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO2.Model
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetail_ID { get; set; }

        public int Order_ID { get; set; }

        public int ProductDetail_ID { get; set; }

        [Range(minimum: 0, maximum: int.MaxValue)]
        public int OrderDetail_Quantity { get; set; }

        [Range(minimum: 0, maximum: double.MaxValue)]
        public double OrderDetail_Total { get; set; }

        public Order Order { get; set; }

        public OrderDetail(int id, int orderId, int productDetailId, int quantity, double total)
        {
            this.OrderDetail_ID = id;
            this.Order_ID = id;
            this.OrderDetail_ID = productDetailId;
            this.OrderDetail_Quantity = quantity;
            this.OrderDetail_Total = total;
        }
    }
}
