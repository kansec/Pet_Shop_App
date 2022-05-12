using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Shop_App.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //Petin bir tane ownerı olacak

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        //Petin bir kategorisi olacak

        public int PetCategoryId { get; set; }
        public PetCategory PetCategory { get; set; }


        // Hangi operasyonlar yapıldı

        public ICollection<Operation> Operations { get; set; }
    }
}
