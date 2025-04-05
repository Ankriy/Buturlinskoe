using Buturlinskoe.Models;
using Microsoft.AspNetCore.Mvc;
using Buturlinskoe.Logic.DomainModels;

namespace Buturlinskoe.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ILogger<AdminPanelController> _logger;
        public AdminPanelController(ILogger<AdminPanelController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Admin(ContactViewModel model)
        {
            return View();
        }
    }
}