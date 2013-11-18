namespace CraftyKnockoutMvc.Repository
{
    using System.Linq.Expressions;
    using CraftyKnockoutMvc.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
   

    public class FamousCoderInMemoryRepository: IRepository<FamousCoder>
    {
        private readonly IList<FamousCoder> inMemoryFamousCoderList = new List<FamousCoder>();

        public IQueryable<FamousCoder> GetAll()
        {
            return inMemoryFamousCoderList.AsQueryable<FamousCoder>();
        }

        public IQueryable<FamousCoder> Get(params Expression<Func<FamousCoder, object>>[] includeProperties)
        {
            var resultQuery = inMemoryFamousCoderList.AsQueryable<FamousCoder>();
            foreach (var includeProperty in includeProperties)
            {
                //resultQuery = resultQuery.Include(includeProperty);
            }
            return resultQuery;
        }

        public FamousCoder Get(int id)
        {
            return inMemoryFamousCoderList.Where(coder => coder.Id == id).FirstOrDefault();
        }

        public void InsertOrUpdate(FamousCoder entity)
        {
            if (entity.Id == default(int)) entity.Id = inMemoryFamousCoderList.Count + 1;

            var savedEntity = Get(entity.Id);

            if (savedEntity != null) inMemoryFamousCoderList.Remove(savedEntity);

            inMemoryFamousCoderList.Add(entity);
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