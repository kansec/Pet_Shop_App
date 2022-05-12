using Pet_Shop_App.Models;

namespace Pet_Shop_App.Interfaces
{
    public interface IVetRepository
    {
        ICollection<Vet> GetAllVets();
        Vet GetVetById(int id);
        void CreateVet(Vet vet);
        void UpdateVet(int id,Vet vet);
        void DeleteVet(int id);
    }
}
