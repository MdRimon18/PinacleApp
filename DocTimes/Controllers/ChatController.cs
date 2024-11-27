using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index(bool isPartial = false)
        {

            if (isPartial)
            {
                return PartialView("Calendar");
            }

            return View();

        }
    }
}
