using Microsoft.EntityFrameworkCore;
using ProiectDAW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProiectDAW.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        internal DatabaseContext _context;
        public BaseRepository(DatabaseContext context)
        {
            this._context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> List()
        {
            return _context.Set<T>().AsEnumerable();
        }

    }
}
