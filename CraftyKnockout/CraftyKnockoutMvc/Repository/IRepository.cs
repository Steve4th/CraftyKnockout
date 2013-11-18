using System;
using System.Linq;
using System.Linq.Expressions;

namespace CraftyKnockoutMvc.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(params Expression<Func<T, object>>[] includeProperties);
        T Get(int id);
        void InsertOrUpdate(T entity);
        void Delete(int id);
        void Save();
    }
}