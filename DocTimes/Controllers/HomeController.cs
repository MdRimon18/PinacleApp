using DocTimes.Models;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics;

namespace DocTimes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("{route?}")]
        public IActionResult Index(string route, int? id = null)
        {
            var routingHelper = new RoutingHelper
            {
                RouteName = route,
                IsShow = true
            };

            // If the request is an AJAX request, return the partial view only
            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView(route); // Serve just the partial if requested via AJAX
            }

            return View(routingHelper); // Loads the default view if no route is specified
        }
        //public ActionResult Blazor()
        //{
        //    // If the request is an AJAX request, return the partial view only
        //    if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        //    {
        //        return PartialView("Chart");
        //    }
           
        //    return View("Chart");  // Full view if not an AJAX request
        //}

        // Define a route that accepts route name and ID as parameters

        //public async Task<IActionResult> Index(string route, int? id = null)
        //{
        //    // Check if route name is valid or if it maps to a specific partial view
        //    if (string.IsNullOrEmpty(route))
        //    {
        //        route = "Followers";
        //      //  return BadRequest("Route is required");
        //    }

        //    // Optional: Add any logic to fetch data based on the ID if it's provided
        //    var model = new RoutingHelper
        //    {
        //        IsShow = true,
        //        RouteName = route,
        //        // Add any additional properties or data fetched based on the ID here
        //    };

        //    // If the request is an AJAX request, return the partial view only
        //    if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        //    {
        //        return PartialView(route, model); // Serve just the partial if requested via AJAX
        //    }

        //    return PartialView(route, model);
        //}

        public IActionResult LoadMvcComponent(string route)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView();
            }
            // Return the partial view with the model
            return PartialView("_MvcPagePartial");
        }
        public IActionResult LoadBlazorComponent(string route)
        {
            RoutingHelper routingHelper = new RoutingHelper
            {
                RouteName = route,
                IsShow = true
            };

            // Return the partial view with the model
            return PartialView("_BlazorPagePartial", routingHelper);
        }
        public IActionResult Chart()
        {
            
            // Return the partial view with the model
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
