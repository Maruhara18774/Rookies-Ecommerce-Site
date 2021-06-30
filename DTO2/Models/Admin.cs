using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO2.Model
{
    public class Admin
    {
        [Key]
        public int Admin_ID { get; set; }

        public string Admin_Username { get; set; }

        public string Admin_Password { get; set; }

        public List<AdminLog> AdminLogs { get; set; }

        public Admin(int id, string username, string password)
        {
            this.Admin_ID = id;
            this.Admin_Username = username;
            this.Admin_Password = password;
        }
    }
}
