using Pet_Shop_App.Data;

namespace Pet_Shop_App.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;

        }
        public void Create(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            
        }

        public ICollection<T> Get()
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
