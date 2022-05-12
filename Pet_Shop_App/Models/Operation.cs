using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Shop_App.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        //Hangi pet

        public Pet Pet { get; set; }
        public int PetId { get; set; }

        //Hangi tedavi uygulandı

        public Treatment Treatment { get; set; }
        public int TreatmentId { get; set; }


        public ICollection<Operation_Vet> Operations_Vets { get; set; }


    }
}
