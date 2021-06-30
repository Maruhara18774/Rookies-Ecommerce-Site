using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Default.Models
{
    public class OrderState
    {
        [Key]
        public int OrderState_ID { get; set; }

        public string OrderState_Name { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();

    }
}
