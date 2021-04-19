using EFCoreDB.ConventionalConfigurationUnitOfWork;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDB.Tests.ConventionalConfiguration
{
    [TestClass]
    public class FDMProcessCCTest
    {
        [TestMethod]
        public void ProcessAddWithPrimaryKeyTest()
        {
            //Act
            int expectedProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                expectedProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count + 1;
            }

            //Arrange
            int actualProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                FDMProcessCC process = new FDMProcessCC();
                process.Name = "Add New Process Test";
                process.FDMProcessCCPrimaryKey = 1;//TODO AM: INFO --> primary key can not be added using fully defined conventional configuration
                uow.FDMProcessCCRepo.Attach(process);
                uow.SaveChanges();
                actualProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedProcessCount, actualProcessCount, "Process not added to database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
        }

        [TestMethod]
        public void ProcessAttachWithoutPrimaryKeyTest()
        {
            //Act
            int expectedProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                expectedProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count + 1;
            }

            //Arrange
            int actualProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                FDMProcessCC process = new FDMProcessCC();
                process.Name = "Add New Process Test";
                uow.FDMProcessCCRepo.Attach(process);
                uow.SaveChanges();
                actualProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedProcessCount, actualProcessCount, "Process not added to database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
        }

        [TestMethod]
        public void ProcessRemoveTest()
        {
            //Act
            int expectedProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                expectedProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
                FDMProcessCC process = new FDMProcessCC();
                process.Name = "Add New Process Test";
                uow.FDMProcessCCRepo.Attach(process);
                uow.SaveChanges();
            }

            //Arrange
            int actualProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                List<FDMProcessCC> processList = uow.FDMProcessCCRepo.GetUsingName("Add New Process Test").Result;
                uow.FDMProcessCCRepo.Delete(processList.FirstOrDefault());
                uow.SaveChanges();
                actualProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedProcessCount, actualProcessCount, "Process not deleted from database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
        }

        [TestMethod]
        public void ProcessRemoveRangeTest()
        {
            //Act
            int initialProcessCount;
            int expectedDeletedCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                FDMProcessCC process = new FDMProcessCC();
                process.Name = "Add New Process Test";
                uow.FDMProcessCCRepo.Attach(process);
                uow.SaveChanges();
            }
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                initialProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
            }

            //Arrange
            int actualDeletedCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                List<FDMProcessCC> processList = uow.FDMProcessCCRepo.GetUsingName("Add New Process Test").Result;
                uow.FDMProcessCCRepo.DeleteRange(processList);
                uow.SaveChanges();
                actualDeletedCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
                expectedDeletedCount = initialProcessCount - processList.Count;
            }

            //Assert
            Assert.AreEqual(expectedDeletedCount, actualDeletedCount, "Processes not correctly deleted from database. Expected No. of Processes deleted = {0}. Actual No. of Process deleted = {1}.", expectedDeletedCount, actualDeletedCount);
        }

        //[TestMethod]
        //public void ProcessAddUnique()
        //{
        //    int primaryKey = 1;
        //    FDMProcessCC testProcess = new FDMProcessCC();
        //    testProcess.Name = "Test Process";
        //    testProcess.FDMProcessCCPrimaryKey = primaryKey;
        //    bool testProcessExists = false;

        //    FDMProcessCC process;
        //    using(FDMUnitOfWork uow = new FDMUnitOfWork())
        //    {
        //        process = uow.FDMProcessCCRepo.GetUsingPrimaryKey(primaryKey).Result;
        //    }

        //    if(process == null)
        //    {
        //        using(FDMUnitOfWork uow = new FDMUnitOfWork())
        //        {
        //            uow.FDMProcessCCRepo.Attach(testProcess);
        //            uow.SaveChanges();
        //        }
        //    }
        //    else
        //    {
        //        if(process.FDMProcessCCPrimaryKey == 1 && process.Name == "Test Process")
        //        {
        //            testProcessExists = true;
        //        }
        //        else
        //        {
        //            using(FDMUnitOfWork uow = new FDMUnitOfWork())
        //            {
        //                uow.FDMProcessCCRepo.DeleteUsingPrimaryKey(primaryKey);
        //                uow.FDMProcessCCRepo.Attach(testProcess);
        //                uow.SaveChanges();
        //            }
        //        }
        //    }
        //    testProcessExists = TestProcessExists();

        //    //Assert
        //    Assert.AreEqual(true, testProcessExists, "Test Process with primary key: '1' and name: 'Test Process', does not exist in Database.");
        //}

        #region private methods

        private bool TestProcessExists()
        {
            int primaryKey = 1;
            FDMProcessCC process;

            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                process = uow.FDMProcessCCRepo.GetUsingPrimaryKey(primaryKey).Result;
            }

            if(process == null)
                return false;

            if(process.Name == "Test Process")
                return true;

            return false;
        }

        #endregion
    }
}
