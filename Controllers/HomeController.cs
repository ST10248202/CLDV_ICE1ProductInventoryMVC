using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductInventoryMVC.Data;
using ProductInventoryMVC.Models;
using System.Diagnostics;


namespace ProductInventoryMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductInventoryMVCContext _context;

        public HomeController(ILogger<HomeController> logger, ProductInventoryMVCContext context)
        {
            _logger = logger;
            _context = context;
            _context = context;
        }

        public IActionResult Index()
        {
            //int productCount = _context.Products.Count();
            //ViewBag.ProductCount = productCount;

            int productCount = _context.Products.Count();
            int maxProductCount = 4; // Set your desired maximum product count limit
            ViewBag.ProductCount = Math.Min(productCount, maxProductCount);
            return View();
            //only code prev
            
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
