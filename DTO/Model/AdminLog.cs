using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class AdminLog
    {
        [Key]
        public int Log_ID { get; set; }

        public int Admin_ID { get; set; }

        public string Log_Description { get; set; }

        public Admin Admin { get; set; }

        /*
        public AdminLog(int id, int admin_id, string description)
        {
            this.Log_ID = id;
            this.Admin_ID = admin_id;
            this.Log_Description = description;
        }
        */
    }
}
