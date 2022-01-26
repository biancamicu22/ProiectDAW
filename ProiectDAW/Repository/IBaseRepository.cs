using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProiectDAW.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(Guid id);
        IEnumerable<T> List();
        bool Add(T entity);
        bool Delete(Guid Id);
        bool Edit(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    }
}
