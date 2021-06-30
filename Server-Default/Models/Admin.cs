using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Default.Models
{
    public class Admin
    {
        [Key]
        public int Admin_ID { get; set; }

        public string Admin_Username { get; set; }

        public string Admin_Password { get; set; }

        public virtual List<AdminLog> AdminLogs { get; set; } = new List<AdminLog>();

    }
}
