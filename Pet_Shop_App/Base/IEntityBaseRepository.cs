namespace Pet_Shop_App.Base
{
    public interface IEntityBaseRepository<T>
    {
        ICollection<T> Get();
        T Get(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}
