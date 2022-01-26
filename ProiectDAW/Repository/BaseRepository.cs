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

        public bool Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var obj = _context.Set<T>().Find(id);
                if(obj != null)
                {
                    _context.Remove(obj);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch   (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> List()
        {
            return _context.Set<T>().AsEnumerable();
        }

    }
}
