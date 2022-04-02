using eCommerce.Data;
using eCommerce.Service.Interfaces;
using eCommerce.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web.Controllers
{

    [AllowAnonymous]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBaseService _baseService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, AppDbContext context, IBaseService baseService)
        {
            _logger = logger;
            _context = context;
            _baseService = baseService;
        }

        public IActionResult Detail(int id)
        {
            var product = _context.Products.Select(x => new eCommerce.Service.Models.Product
            {
                Id = x.Id,
                Title = x.Title,
                Price = x.Price ?? 0,
            }).FirstOrDefault(x => x.Id == id);

            var comments = _context.Comments.Where(x => x.ProductId == id).Select(x => new Comment
            {
                Id = x.Id,
                Description = x.Description,
                CreteDate = x.CreatedDate,
                UserId=x.UserId
            }).ToList();


            foreach(var item in comments)
            {
                var user = _context.Users.FirstOrDefault(x => x.Id == item.UserId);
                item.UserName = user.UserName;
            }

            var model = new ProductModel
            {
                Categories = _baseService.GetCategories(),
                Product = product,
                Comments= comments
            };
            return View(model);
        }

        public IActionResult Index(int categoryId)
        {
            var products = _context.Products.Where(x => x.CategoryId == categoryId).Select(x => new eCommerce.Service.Models.Product
            {
                Id = x.Id,
                Title = x.Title,
                Price = x.Price ?? 0
            }).ToList();

            var model = new ProductModel
            {
                Categories = _baseService.GetCategories(),
                Products = products
            };
            return View(model);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
