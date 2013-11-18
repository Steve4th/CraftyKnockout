using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CraftyKnockoutMvc.Repository;
using System.Linq;
using CraftyKnockoutMvc.Models;

namespace CraftyKnockoutMvc.Tests
{
    [TestClass]
    public class FamousCoderInMemoryRepositoryTests
    {
        [TestMethod]
        [TestCategory("FamousCoderInMemoryRepository")]
        public void FamousCoderInMemoryRepository_All_ExpectNoRecordsReturned()
        {
            using (var famousCoderRepository = new FamousCoderInMemoryRepository())
            {
                var results = famousCoderRepository.GetAll();

                Assert.AreEqual(0, results.Count());
            }
        }

        [TestMethod]
        [TestCategory("FamousCoderInMemoryRepository")]
        public void FamousCoderInMemoryRepository_InsertOneCoder_ExpectCoderAdded()
        {
            using (var famousCoderRepository = new FamousCoderInMemoryRepository())
            {
                FamousCoder a = new FamousCoder() { Id = 1, CoderName ="Scott", FamousFor = "Unit testing?", FameScore = 50 };
                famousCoderRepository.InsertOrUpdate(a);
                Assert.AreEqual(1, famousCoderRepository.GetAll().Count());
            }
        }

        [TestMethod]
        [TestCategory("FamousCoderInMemoryRepository")]
        public void FamousCoderInMemoryRepository_InsertTwoCoder_ExpectFamousCoderAdded()
        {
            using (var famousCoderRepository = new FamousCoderInMemoryRepository())
            {
                FamousCoder a = new FamousCoder() { Id = 1, CoderName ="Scott", FamousFor = "Unit testing?", FameScore = 50 };
                FamousCoder b = new FamousCoder() { Id = 2, CoderName ="Ian", FamousFor = "Unit testing?", FameScore = 50 };
                famousCoderRepository.InsertOrUpdate(a);
                famousCoderRepository.InsertOrUpdate(b);
                Assert.AreEqual(2, famousCoderRepository.GetAll().Count());
            }
        }

        [TestMethod]
        [TestCategory("FamousCoderInMemoryRepository")]
        public void FamousCoderInMemoryRepository_InsertTwoCoderWithoutSpecifyingIdValue_ExpectCoderAdded()
        {
            using (var famousCoderRepository = new FamousCoderInMemoryRepository())
            {
                FamousCoder a = new FamousCoder() { CoderName ="Scott", FamousFor = "Unit testing?", FameScore = 50 };
                FamousCoder b = new FamousCoder() { CoderName ="Ian", FamousFor = "Unit testing?", FameScore = 50 };
                famousCoderRepository.InsertOrUpdate(a);
                famousCoderRepository.InsertOrUpdate(b);
                Assert.AreEqual(2, famousCoderRepository.GetAll().Count());
            }
        }

        [TestMethod]
        [TestCategory("FamousCoderInMemoryRepository")]
        public void FamousCoderInMemoryRepository_UpdateCoder_ExpectNoAdditionalCoderAdded()
        {
            using (var famousCoderRepository = new FamousCoderInMemoryRepository())
            {
                FamousCoder a = new FamousCoder() { Id = 1, CoderName ="Scott", FamousFor = "Unit testing?", FameScore = 50 };
                FamousCoder b = new FamousCoder() { Id = 2, CoderName ="Ian", FamousFor = "Unit testing?", FameScore = 50 };
                famousCoderRepository.InsertOrUpdate(a);
                famousCoderRepository.InsertOrUpdate(b);
                Assert.AreEqual(2, famousCoderRepository.GetAll().Count());

                FamousCoder c = new FamousCoder() { Id = 1, CoderName = "Andres", FamousFor = "Need you ask?", FameScore = 80 };
                famousCoderRepository.InsertOrUpdate(c);

                Assert.AreEqual(2, famousCoderRepository.GetAll().Count());
            }
        }

        [TestMethod]
        [TestCategory("FamousCoderInMemoryRepository")]
        public void FamousCoderInMemoryRepository_UpdateCoder_ExpectCoderUpdated()
        {
            using (var famousCoderRepository = new FamousCoderInMemoryRepository())
            {
                const int CoderId = 1;

                FamousCoder coderOne = new FamousCoder() { Id = CoderId, CoderName = "Scott", FamousFor = "Unit testing?", FameScore = 50 };
                famousCoderRepository.InsertOrUpdate(coderOne);

                FamousCoder coderTwo = new FamousCoder() { Id = CoderId, CoderName = "Ian", FamousFor = "Writing Code", FameScore = 20 };
                famousCoderRepository.InsertOrUpdate(coderTwo);

                var updatedCoder = famousCoderRepository.Get(CoderId);

                Assert.AreEqual(coderTwo.CoderName, updatedCoder.CoderName);
            }
        }
    }
}
