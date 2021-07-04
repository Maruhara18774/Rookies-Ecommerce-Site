using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data.Models
{
    public class Customer : IdentityUser
    {
        [MaxLength(50)]
        public string Customer_FirstName { get; set; }

        [MaxLength(150)]
        public string Customer_LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Customer_Email { get; set; }

        public string Customer_Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Customer_PhoneNumber { get; set; }

        public string Password { get; set; }

        public virtual Country Country { get; set; }

        public virtual List<Feedback> Feedbacks { get; set; } = new List<Feedback>();

        public virtual List<Order> Orders { get; set; } = new List<Order>();

    }
}
