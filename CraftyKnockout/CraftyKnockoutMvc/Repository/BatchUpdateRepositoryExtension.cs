using System;
using System.Collections.Generic;
using System.Linq;

namespace CraftyKnockoutMvc.Repository
{
    public static class BatchUpdateRepositoryExtension
    {
        public static void UpdateToMatchList<TRepo, TEntity>(this TRepo repository, IList<TEntity> listOfItemsToUpdate)
            where TRepo : IRepository<TEntity>
        {
            repository.Clear();

            foreach (var item in listOfItemsToUpdate)
            {
                repository.InsertOrUpdate(item);
            }
        }
    }
}