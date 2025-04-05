using Buturlinskoe.Models;
using Microsoft.AspNetCore.Mvc;
using Buturlinskoe.Logic.DomainModels;

namespace Buturlinskoe.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetContacts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetContacts(ContactViewModel model)
        {
            return View();
        }
    }
}