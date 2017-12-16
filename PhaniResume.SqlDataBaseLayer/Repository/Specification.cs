using System;
using System.Linq.Expressions;

namespace PhaniResume.SqlDataBaseLayer.Repository
{
    public class Specification<T> 
    {
        protected readonly Expression<Func<T, bool>> _predicate;

        public Specification(Expression<Func<T, bool>> predicate)
        {
            _predicate = predicate;
        }


        public Expression<Func<T, bool>> predicate
        {
            get { return _predicate; }
            
        }
    }
}