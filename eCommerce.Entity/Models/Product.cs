using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Entity.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float? Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }

        public virtual Category Category { get;set;}
        public ICollection<Comment> Comments { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
