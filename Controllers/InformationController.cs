using Buturlinskoe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buturlinskoe.Controllers
{
    public class InformationController : Controller
    {
        private readonly ILogger<InformationController> _logger;

        public InformationController(ILogger<InformationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetInformation()
        {
            return View();
        }

        [HttpPost]

        public IActionResult GetInformation (InformationViewModel model)
        {
            return View();
        }
    }
}
