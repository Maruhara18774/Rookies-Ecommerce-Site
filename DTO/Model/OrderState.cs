﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class OrderState
    {
        [Key]
        public int OrderState_ID { get; set; }

        public string OrderState_Name { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        //public OrderState() { }

        //public OrderState(int id, string name)
        //{
        //    this.OrderState_ID = id;
        //    this.OrderState_Name = name;
        //}
    }
}
