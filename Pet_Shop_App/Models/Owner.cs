using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Shop_App.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        //Owner'ın birden fazla peti olabilir. Pet - owner arası one to many

        public ICollection<Pet> Pets { get; set; }
    }
}
