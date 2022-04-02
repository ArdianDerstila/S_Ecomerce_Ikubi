using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Entity.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserId { get; set; }
        
        public virtual Product Product { get; set; }
    }
}
