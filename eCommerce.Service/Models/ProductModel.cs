using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Service.Models
{
    public class ProductModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
