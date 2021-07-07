using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }
        [MaxLength(100)]
        public string Category_Name { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

    }
}
