using Buturlinskoe.EF.DomainModels;
using System.Net;

namespace Buturlinskoe.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserViewModel(User contact) {
            Name = contact.Name;
            Surname = contact.Surname;
            Email = contact.Email;
            Password = contact.Password;
        }
    }
}
