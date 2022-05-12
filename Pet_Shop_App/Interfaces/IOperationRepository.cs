using Pet_Shop_App.Models;

namespace Pet_Shop_App.Interfaces
{
    public interface IOperationRepository
    {
        ICollection<Operation> GetAllOperations();
        Operation GetOperationById(int id);
        void CreateOperation(Operation operation);
        void DeleteOperation(int id);
        void UpdateOperation(int id,Operation operation);

    }
}
