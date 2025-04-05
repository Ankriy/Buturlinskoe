using Buturlinskoe.Logic.DomainModels;

namespace Buturlinskoe.Models
{
    public class YslygiViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }
        public YslygiViewModel()
        {
        }
        public YslygiViewModel(Contact contact)
        {
            Name = contact.Name;
            Email = contact.Email;
            Adress = contact.Adress;
            Phone = contact.Phone;
        }
    }
}