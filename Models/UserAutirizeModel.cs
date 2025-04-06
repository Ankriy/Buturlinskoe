using Buturlinskoe.EF.DomainModels;
using System.Net;

namespace Buturlinskoe.Models
{
    public class UserAutirizeModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public UserAutirizeModel(User contact) {
            Email = contact.Email;
            Password = contact.Password;
        }
    }
}
