using Microsoft.AspNetCore.Mvc;
namespace MultiShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }

    }
}
