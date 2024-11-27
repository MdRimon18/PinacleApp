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

        public IActionResult Notification(bool isPartial = false)
        {
            // If the request is an AJAX request, return the partial view only
            if (isPartial)
            {
                return PartialView("Notification");
            }

            return View();

        }
        public IActionResult CreateProfile(bool isPartial = false)
        {
            // If the request is an AJAX request, return the partial view only
            if (isPartial)
            {
                return PartialView("CreateProfile");
            }

            return View();

        }


        public IActionResult Calendar(bool isPartial = false)
        {
            // If the request is an AJAX request, return the partial view only
            if (isPartial)
            {
                return PartialView("Calendar");
            }

            return View();

        }

    }
}
