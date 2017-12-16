using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhaniResume.SqlDataBaseLayer.Repository
{
    public interface IRepository<T> where T:class 
    {
        IQueryable<T> SelectAll();
        T SelectById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object entity);
        void Delete(T entity);
        void Save();
        void Save(int userid);
        Task SaveAsync();

        void SetValues(T obj, T obj2);

        IQueryable<T> Query(Specification<T> specification);

        IQueryable<T> Query(Expression<Func<T, bool>> specification);
    }
}
