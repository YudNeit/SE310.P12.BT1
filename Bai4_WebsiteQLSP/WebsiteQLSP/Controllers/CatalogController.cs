using Microsoft.AspNetCore.Mvc;
using WebsiteQLSP.Models;

namespace WebsiteQLSP.Controllers
{
    public class CatalogController : Controller
    {
        private readonly Context _context;

        // Constructor nhận DbContext từ dependency injection
        public CatalogController(Context context)
        {
            _context = context;
        }

        // GET: Catalog
        public IActionResult Index()
        {
            var catalogs = _context.Catalogs.ToList();
            return View("Catalog", catalogs);  // Chỉ định view Catalog.cshtml
        }

    }
}
