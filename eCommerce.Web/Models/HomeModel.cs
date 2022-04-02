using eCommerce.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Web.Models
{
    public class HomeModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }

}
