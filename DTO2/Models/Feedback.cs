using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DTO2.Model
{
    public class Feedback
    {
        [Key]
        public int Feedback_ID { get; set; }

        public int ProductDetail_ID { get; set; }

        public int Customer_ID { get; set; }

        [Range(minimum:1, maximum:5)]
        public int Feedback_Rating { get; set; }

        [MaxLength(100)]
        public string Feedback_Title { get; set; }

        public string Feedback_Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public Customer Customer { get; set; }
        public ProductDetail ProductDetail { get; set; }

        public Feedback(int id, int productDetailId, int customerId, int rating, string title, string content, DateTime createDate)
        {
            this.Feedback_ID = id;
            this.ProductDetail_ID = productDetailId;
            this.Customer_ID = customerId;
            this.Feedback_Rating = rating;
            this.Feedback_Title = title;
            this.Feedback_Content = content;
            this.CreatedDate = createDate;
        }
    }
}
