using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Service.Models
{
    public class HomeModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }

    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
