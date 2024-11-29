using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DocTimes.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index(bool isPartial = false)
        {
            InvoiceViewModel invoiceViewModel = new InvoiceViewModel();
            if (isPartial)
            {
                return PartialView("Index", invoiceViewModel);
            }
            return View("Index", invoiceViewModel);

        }
    }
}
