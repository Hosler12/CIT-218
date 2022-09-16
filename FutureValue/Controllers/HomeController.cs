using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FutureValue.Models;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
