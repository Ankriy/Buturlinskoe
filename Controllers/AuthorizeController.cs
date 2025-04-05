using Buturlinskoe.EF.Services;
using Buturlinskoe.EF.DomainModels;
using Buturlinskoe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buturlinskoe.Controllers
{
    public class AuthorizeController : Controller
    {
        private readonly ILogger<AuthorizeController> _logger;
        private readonly UserService _userService;
        public AuthorizeController(ILogger<AuthorizeController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Authorize()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Authorize([FromForm] User data)
        {
            var model = new UserViewModel(_userService.GetUser(data.Email, data.Password));
            return View(model);
        }
    }
}