namespace CraftyKnockoutMvc.Repository
{
    using System.Data.Entity;
    using System.Linq;
    using CraftyKnockoutMvc.Models;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System;

    public class FamousCoderInMemoryRepository : IRepository<FamousCoder>
    {
        protected readonly IList<FamousCoder> inMemoryList = new List<FamousCoder>();

        public IQueryable<FamousCoder> GetAll()
        {
            return inMemoryList.AsQueryable<FamousCoder>();
        }

        public IQueryable<FamousCoder> Get(params Expression<Func<FamousCoder, object>>[] includeProperties)
        {
            var resultQuery = inMemoryList.AsQueryable();
            foreach (var includeProperty in includeProperties)
            {
                resultQuery = resultQuery.Include(includeProperty);
            }
            return resultQuery;
        }

        public FamousCoder Get(int id)
        {
            return inMemoryList.Where(t => t.Id == id).FirstOrDefault();
        }

        public void InsertOrUpdate(FamousCoder entity)
        {
            if (entity.Id == default(int)) entity.Id = inMemoryList.Count + 1;

            var savedEntity = Get(entity.Id);

            if (savedEntity != null) inMemoryList.Remove(savedEntity);

            inMemoryList.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            //do nothing as we have nothing to do here
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing,
        /// or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            //do nothing as we have nothing to do here.
        }
    }
}