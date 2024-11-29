using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class WebsiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
