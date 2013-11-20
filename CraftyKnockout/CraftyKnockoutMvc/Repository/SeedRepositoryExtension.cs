using CraftyKnockoutMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CraftyKnockoutMvc.Repository
{
    public static class SeedRepositoryExtension
    {
        /// <summary>
        /// Seeds the famous coder repository with a few names
        /// </summary>
        /// <typeparam name="T">The type of the T.</typeparam>
        /// <param name="famousCoderRepository">The famous coder repository.</param>
        public static void SeedRepository<T>(this T famousCoderRepository)
            where T : IRepository<FamousCoder>
        {
            //HACK: I know this stinks but it is a quick fix for now.
            if (famousCoderRepository.GetAll().Count() == 0)
            {
                var seedCoders = GetFamousCoders();

                famousCoderRepository.UpdateToMatchList(seedCoders);
            }
        }

        private static IList<FamousCoder> GetFamousCoders()
        {
            var returnList = new List<FamousCoder>()
            {
                new FamousCoder()
                {
                    CoderName = "Jon Skeet",
                    FameScore = 20,
                    FamousFor = "Stack overflow"
                },
                new FamousCoder()
                {
                    CoderName = "Douglas Crockford",
                    FameScore = 10,
                    FamousFor = "JavaScript"
                },
                new FamousCoder()
                {
                    CoderName = "Scott Guthrie",
                    FameScore = 25,
                    FamousFor = "Red Shirt"
                },
                new FamousCoder()
                {
                    CoderName = "Steven Sanderson",
                    FameScore = 5,
                    FamousFor = "KnockoutJS"
                }
            };
            
            return returnList;
        }
    }
}