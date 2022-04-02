using eCommerce.Service.Models;
using System;
using System.Collections.Generic;

namespace eCommerce.Web.Models
{
    public class ProductModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreteDate { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
    }
}
