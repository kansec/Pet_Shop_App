using Pet_Shop_App.Data;
using Pet_Shop_App.Interfaces;
using Pet_Shop_App.Models;

namespace Pet_Shop_App.Repositories
{
    public class VetRepository : IVetRepository
    {
        private readonly AppDbContext _context;

        public VetRepository(AppDbContext context)
        {
            _context = context;

        }
        public void CreateVet(Vet vet)
        {
            _context.Vets.Add(vet);
            _context.SaveChanges();
        }

        public void DeleteVet(int id)
        {
            var result = _context.Vets.FirstOrDefault(vet => vet.Id == id);
            _context.Vets.Remove(result);

        }

        public ICollection<Vet> GetAllVets()
        {
            return _context.Vets.
        }

        public Vet GetVetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVet(int id, Vet vet)
        {
            throw new NotImplementedException();
        }
    }
}
