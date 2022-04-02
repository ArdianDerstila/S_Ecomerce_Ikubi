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
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBaseService _baseService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, IBaseService baseService)
        {
            _logger = logger;
            _context = context;
            _baseService = baseService;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Select(x => new eCommerce.Service.Models.Product
            {
                Id = x.Id,
                Title = x.Title,
                Price = x.Price ?? 0
            }).ToList();

            var model = new HomeModel
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
