using EFCoreDB.ConventionalConfigurationUnitOfWork;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFCoreDB.Tests.ConventionalConfiguration
{
    [TestClass]
    public class FDMPointCCTest
    {
        //[TestMethod]
        //public void AddPointDirectly()
        //{
        //    //Arrange 
        //    int expectedPointCount;
        //    using(FDMUnitOfWork uow = new FDMUnitOfWork())
        //    {
        //        expectedPointCount = uow.FDMPointCCRepo.GetAll().Result.Count + 1;
        //    }

        //    //Act
        //    int actualpointCount = 0;
        //    using(FDMUnitOfWork uow = new FDMUnitOfWork())
        //    {
        //        FDMPointCC point = new FDMPointCC();
        //        point.Name = "Testing Adding Point";
        //        uow.FDMPointCCRepo.Attach(point);
        //        uow.SaveChanges();
        //    }
        //    using(FDMUnitOfWork uow = new FDMUnitOfWork())
        //    {
        //        actualpointCount = uow.FDMPointCCRepo.GetAll().Result.Count;
        //    }

        //    //Assert
        //    Assert.AreEqual(expectedPointCount, actualpointCount, "The point was not added to the database. Expected Points = {0}. Actual Points= {1}", expectedPointCount, actualpointCount);
        //}
    }
}
