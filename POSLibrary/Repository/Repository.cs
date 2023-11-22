using Microsoft.EntityFrameworkCore;
using POSLibrary.DataContexts;
using POSLibrary.Models;

namespace POSLibrary.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly PosContext _context;
        public Repository(PosContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IEnumerable<T>? GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }
        public IQueryable<T>? GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }
        public T? GetById(string id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
