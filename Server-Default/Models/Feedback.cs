using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Default.Models
{
    public class Feedback
    {
        [Key]
        public int Feedback_ID { get; set; }

        [Range(minimum: 1, maximum: 5)]
        public int Feedback_Rating { get; set; }

        [MaxLength(100)]
        public string Feedback_Title { get; set; }

        public string Feedback_Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }

    }
}
