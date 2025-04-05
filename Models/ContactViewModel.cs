using Buturlinskoe.Logic.DomainModels;
using System.Net;

namespace Buturlinskoe.Models
{
    public class ContactViewModel
    {
        public string Fio { get; set; }

       
        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
               public ContactViewModel(Contact contact) {
            Fio = contact.Name;
            Email = contact.Email;
            Address = contact.Adress;
            Phone = contact.Phone;
        }
        public bool Fill()
        {

            return true;
        }
    }
}
