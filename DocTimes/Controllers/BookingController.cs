using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class BookingController : Controller
    {
        
        public IActionResult Calendar(bool isPartial = false)
        {
           
            if (isPartial)
            {
                return PartialView("Calendar");
            }

            return View();

        }
    }
}
