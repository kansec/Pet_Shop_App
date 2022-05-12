using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Shop_App.Models
{
    public class Operation_Vet
    {
        public int OperationId { get; set; }
        public Operation Operation { get; set; }
        public int VetId { get; set; }
        public Vet Vet { get; set; }
    }
}
