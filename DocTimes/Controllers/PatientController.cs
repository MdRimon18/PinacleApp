using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            // If the request is an AJAX request, return the partial view only
            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("Index");
            }

            return View("Index");
            
        }
        public IActionResult List()
        {
            // If the request is an AJAX request, return the partial view only
            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("List");
            }

            return View("List");

        }
    }
}
