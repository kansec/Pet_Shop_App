using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Shop_App.Models
{
    public class Vet
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Title { get; set; }

        //Hangi operasyonları yaptı

        public ICollection<Operation_Vet> Operations_Vets { get; set; }
    }
}
