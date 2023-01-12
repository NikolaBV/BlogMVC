using Microsoft.AspNetCore.Mvc;

namespace BlogMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
