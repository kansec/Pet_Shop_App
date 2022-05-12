using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Shop_App.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //Hangi operasyonlarda kullanıldı

        public ICollection<Operation> Operations { get; set; }
    }
}
