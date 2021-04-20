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
        List<FDMProcessCC> _allProcess;
        int _allProcessCount;
        bool _deleteAll;

        public FDMProcessCCTest()
        {
            _deleteAll = false;
            _allProcess = new List<FDMProcessCC>();
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                _allProcess = uow.FDMProcessCCRepo.GetAll().Result;
            }
            _allProcessCount = _allProcess.Count;
        }

        #region General Tests

        #region add

        [TestMethod]
        public void ProcessAttachTest()
        {
            //Act
            int expectedProcessCount = _allProcessCount + 1;

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
        public void ProcessAttachRangeTest()
        {
            //Act
            int expectedProcessCount = _allProcessCount + 2;

            //Arrange
            int actualProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                FDMProcessCC process1 = new FDMProcessCC();
                process1.Name = "Add New Process Test 1";
                FDMProcessCC process2 = new FDMProcessCC();
                process2.Name = "Add New Process Test 2";
                List<FDMProcessCC> processList = new List<FDMProcessCC>()
                {
                    process1,
                    process2
                };
                uow.FDMProcessCCRepo.AttachRange(processList);
                uow.SaveChanges();
                actualProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedProcessCount, actualProcessCount, "Process not added to database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
        }

        #endregion

        #region delete

        [TestMethod]
        public void ProcessDeleteTest()
        {
            //Act
            FDMProcessCC processToDelete = new FDMProcessCC();
            processToDelete.Name = "Add and Delete Process Test";
            int expectedProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {

                uow.FDMProcessCCRepo.Attach(processToDelete);
                uow.SaveChanges();
                expectedProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count - 1;
            }

            //Arrange
            int actualProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                uow.FDMProcessCCRepo.Delete(processToDelete);
                uow.SaveChanges();
                actualProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedProcessCount, actualProcessCount, "Process not deleted from database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
        }

        [TestMethod]
        public void ProcessDeleteRangeTest()
        {
            //Act
            FDMProcessCC processToDelete1 = new FDMProcessCC();
            processToDelete1.Name = "Add and Delete Multiple Process Test 1";
            FDMProcessCC processToDelete2 = new FDMProcessCC();
            processToDelete2.Name = "Add and Delete Multiple Process Test 2";
            List<FDMProcessCC> processToDeleteList = new List<FDMProcessCC>()
            {
                processToDelete1,
                processToDelete2
            };
            int expectedProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {

                uow.FDMProcessCCRepo.AttachRange(processToDeleteList);
                uow.SaveChanges();
                expectedProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count - 2;
            }

            //Arrange
            int actualProcessCount;
            using(FDMUnitOfWork uow = new FDMUnitOfWork())
            {
                uow.FDMProcessCCRepo.DeleteRange(processToDeleteList);
                uow.SaveChanges();
                actualProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedProcessCount, actualProcessCount, "Processes not deleted from database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
        }

        [TestMethod]
        public void ProcessDeleteAllTest()
        {
            if(_deleteAll)
            {
                //Act
                int expectedProcessCount = 0;

                //Arrange
                int actualProcessCount;
                using(FDMUnitOfWork uow = new FDMUnitOfWork())
                {
                    uow.FDMProcessCCRepo.DeleteAll();
                    uow.SaveChanges();
                    actualProcessCount = uow.FDMProcessCCRepo.GetAll().Result.Count;
                }

                //Assert
                Assert.AreEqual(expectedProcessCount, actualProcessCount, "All Processes not deleted from database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);

                using(FDMUnitOfWork uow = new FDMUnitOfWork())
                {
                    uow.FDMProcessCCRepo.AttachRange(_allProcess);
                    uow.SaveChanges();
                }
            }
        }

        #endregion

        #region update
        #endregion

        #endregion

    }
}
