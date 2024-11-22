using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class DoctorProfileController : Controller
    {
        public IActionResult Index(bool isPartial = false)
        {
            if (isPartial)
            {
                return PartialView("Index");
            }
            return View();
        }
    }
}
