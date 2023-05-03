using Microsoft.AspNetCore.Mvc;

namespace GlassStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
