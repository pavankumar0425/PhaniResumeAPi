using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.SqlDataBaseLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private IPhaniDbContext _context;
        private DbSet<T> _entities;
        string errorMessage = string.Empty;

        public Repository()
        {
                
        }
        public void SetValues(IPhaniDbContext context, DbSet<T> entities)
        {
            _context = context;
            _entities = entities;
        }

        public Repository(IPhaniDbContext context)
        {
            this._context = context;
            _entities = context.Set<T>();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Add(entity);
            _context.Save();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Attach(entity);
            _context.Save();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            //entities.Remove(entity);
            _context.Entity(entity).State = EntityState.Deleted;
        }

        public IQueryable<T> SelectAll()
        {
            return _entities;
        }

        public T SelectById(object id)
        {
            return _entities.Find(id);
        }

        public void Delete(object id)
        {
            T existing = _entities.Find(id);
            if (existing != null)
            {
                _entities.Remove(existing);
            }
        }

        public void Save()
        {
            _context.Save();
        }

        public void Save(int userid)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void SetValues(T obj, T obj2)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query(Specification<T> specification)
        {
            return _entities.Where(specification.predicate);
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }
    }
}
