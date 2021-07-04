using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Data.Models
{
    public class AdminLog
    {
        [Key]
        public int Log_ID { get; set; }

        public DateTime ChangeTime { get; set; }

        public string Log_Description { get; set; }

        public virtual Admin Admin { get; set; }

    }
}
