using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }

        [MaxLength(50)]
        public string Customer_FirstName { get; set; }

        [MaxLength(150)]
        public string Customer_LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Customer_Email { get; set; }

        public int Country_ID { get; set; }

        public string Customer_Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Customer_PhoneNumber { get; set; }

        public string Password { get; set; }

        public Country Country { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public Customer(int id, string firstName, string lastName, string email, int countryId, string address, string phone, string password)
        {
            this.Customer_ID = id;
            this.Customer_FirstName = firstName;
            this.Customer_LastName = lastName;
            this.Customer_Email = email;
            this.Country_ID = countryId;
            this.Customer_Address = address;
            this.Customer_PhoneNumber = phone;
            this.Password = password;
        }
    }
}
