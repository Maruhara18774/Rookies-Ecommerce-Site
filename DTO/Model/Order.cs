﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Range(minimum: 0, maximum: double.MaxValue)]
        public double Order_Total { get; set; }

        public Customer Customer { get; set; }

        public OrderState OrderState { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        //public Order()
        //{
        //    this.Order_Total = 0;
        //    this.CreatedDate = DateTime.Now;
        //}

        //public Order(int id, int customerId, DateTime createDate, int orderState)
        //{
        //    this.Order_ID = id;
        //    this.Customer_ID = customerId;
        //    this.CreatedDate = createDate;
        //    this.Order_Total = 0;
        //    this.OrderState_ID = orderState;
        //}
    }
}
