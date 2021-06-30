using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Country
    {
        [Key]
        public int Country_ID { get; set; }

        [MaxLength(100)]
        public string Country_Name { get; set; }

        public List<Customer> Customers { get; set; } = new List<Customer>();

        //public Country() { }
        //public Country(int id, string name)
        //{
        //    this.Country_ID = id;
        //    this.Country_Name = name;
        //}
    }
}
