using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }

        public int Customer_ID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Range(minimum: 0, maximum: double.MaxValue)]
        public double Order_Total { get; set; }

        public int OrderState_ID { get; set; }

        public Customer Customer { get; set; }

        public OrderState OrderState { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Order(int id, int customerId, DateTime createDate, int orderState)
        {
            this.Order_ID = id;
            this.Customer_ID = customerId;
            this.CreatedDate = createDate;
            this.Order_Total = 0;
            this.OrderState_ID = orderState;
        }
    }
}
