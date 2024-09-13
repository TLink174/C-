using Microsoft.AspNetCore.Mvc;
using WebMVCDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace WebMVCDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyDBContext _context;

        public ProductController(MyDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Product.ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> SearchById(int id)
        {
            id = 1;
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return NotFound();
            }

            Console.WriteLine($"Product found - ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            return View(product);
        }
    }
}