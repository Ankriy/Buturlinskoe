using Buturlinskoe.Models;
using Microsoft.AspNetCore.Mvc;
using Buturlinskoe.Logic.DomainModels;

namespace Buturlinskoe.Controllers
{
    public class AuthorizeController : Controller
    {
        private readonly ILogger<AuthorizeController> _logger;
        public AuthorizeController(ILogger<AuthorizeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Authorize()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Authorize(ContactViewModel model)
        {
            return View();
        }
    }
}