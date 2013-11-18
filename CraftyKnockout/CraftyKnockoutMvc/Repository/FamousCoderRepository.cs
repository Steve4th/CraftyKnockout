namespace CraftyKnockoutMvc.Repository
{
    using CraftyKnockoutMvc.Models;
    using System;
    using System.Linq;

    public class FamousCoderRepository: IRepository<FamousCoder>
    {
        public IQueryable<FamousCoder> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<FamousCoder> Get(params System.Linq.Expressions.Expression<Func<FamousCoder, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public FamousCoder Get(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(FamousCoder address)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}