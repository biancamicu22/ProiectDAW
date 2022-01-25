using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProiectDAW.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> List();
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    }
}
