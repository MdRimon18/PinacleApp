using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class UserMenuController : Controller
    {
        public IActionResult Create(bool isPartial = false)
        {

            if (isPartial)
            {
                return PartialView("Create");
            }

            return View();

        }
    }
}
