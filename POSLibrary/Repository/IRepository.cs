using POSLibrary.Models;

namespace POSLibrary.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T>? GetAll();
        IQueryable<T>? GetQueryable();

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Delete(T entity);
        T? GetById(ulong id);
        void SaveChanges();
        bool Update(T entity);
        PosContext Context();
    }
}