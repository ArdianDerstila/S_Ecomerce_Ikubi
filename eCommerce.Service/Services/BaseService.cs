using eCommerce.Data;
using eCommerce.Service.Interfaces;
using eCommerce.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace eCommerce.Service.Services
{
    public class BaseService : IBaseService
    {
        private readonly AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }
        public List<Category> GetCategories()
        {
            var categories = _context.Categories.Where(x => x.ParentId == null).Select(x => new eCommerce.Service.Models.Category
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            foreach (var item in categories)
            {
                item.SubCategories = _context.Categories.Where(x => x.ParentId == item.Id).Select(x => new eCommerce.Service.Models.SubCategory
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }

            return categories;
        }
    }
}
