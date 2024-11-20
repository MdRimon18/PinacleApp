using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult List(bool isPartial = false)
        {
            // If the request is an AJAX request, return the partial view only
            if (isPartial)
            {
                return PartialView("List");
            }

            return View();

        }
    }
}
