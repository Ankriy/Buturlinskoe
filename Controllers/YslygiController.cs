using Buturlinskoe.Logic.DomainModels;
using Buturlinskoe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buturlinskoe.Controllers
{
    public class YslygiController : Controller
    {
        private readonly ILogger<YslygiController> _logger;
        public YslygiController(ILogger<YslygiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetYslygi()
        {
               return View();
        }
        [HttpPost]
        public IActionResult GetYslygi(YslygiViewModel model)
        {
            return View();
        }

    }
}
