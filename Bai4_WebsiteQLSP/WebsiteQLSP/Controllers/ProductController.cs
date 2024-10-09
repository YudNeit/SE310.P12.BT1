using Microsoft.AspNetCore.Mvc;
using WebsiteQLSP.Models;

namespace WebsiteQLSP.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;

        // Constructor nhận DbContext từ dependency injection
        public ProductController(Context context)
        {
            _context = context;
        }

        // GET: Catalog
        public IActionResult Index()    
        {
            var product = _context.Products.ToList();
            return View("Product", product);  // Chỉ định view Catalog.cshtml
        }

    }
}
