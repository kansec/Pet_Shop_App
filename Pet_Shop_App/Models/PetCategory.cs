using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Shop_App.Models
{
    public class PetCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Pet kategoride birden fazla pet olabilir

        public ICollection<Pet> Pets { get; set; }
    }
}
