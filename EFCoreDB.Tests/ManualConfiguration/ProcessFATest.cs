using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EFCoreDB.Tests.ManualConfiguration
{
    [TestClass]
    public class ProcessFATest
    {
        List<ProcessFA> _allProcess;
        int _allProcessCount;
        bool _deleteAll;

        public ProcessFATest()
        {
            TestMode.IsTestMode = true;
            _deleteAll = false;
            _allProcess = new List<ProcessFA>();
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                _allProcess = uow.ProcessFARepo.GetAll().Result;
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
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                ProcessFA process = new ProcessFA("Add New Process Test");
                uow.ProcessFARepo.Attach(process);
                uow.SaveChanges();
                actualProcessCount = uow.ProcessFARepo.GetAll().Result.Count;
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
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                List<ProcessFA> processList = new List<ProcessFA>()
                {
                    new ProcessFA("Add New Process Test 1"),
                    new ProcessFA("Add New Process Test 2")
                };
                uow.ProcessFARepo.AttachRange(processList);
                uow.SaveChanges();
                actualProcessCount = uow.ProcessFARepo.GetAll().Result.Count;
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
            ProcessFA processToDelete = new ProcessFA("Add and Delete Process Test");
            int expectedProcessCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {

                uow.ProcessFARepo.Attach(processToDelete);
                uow.SaveChanges();
                expectedProcessCount = uow.ProcessFARepo.GetAll().Result.Count - 1;
            }

            //Arrange
            int actualProcessCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.ProcessFARepo.Delete(processToDelete);
                uow.SaveChanges();
                actualProcessCount = uow.ProcessFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedProcessCount, actualProcessCount, "Process not deleted from database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
        }

        [TestMethod]
        public void ProcessDeleteRangeTest()
        {
            //Act
            List<ProcessFA> processToDeleteList = new List<ProcessFA>()
            {
                new ProcessFA("Add and Delete Multiple Process Test 1"),
                new ProcessFA("Add and Delete Multiple Process Test 2")
            };
            int expectedProcessCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {

                uow.ProcessFARepo.AttachRange(processToDeleteList);
                uow.SaveChanges();
                expectedProcessCount = uow.ProcessFARepo.GetAll().Result.Count - 2;
            }

            //Arrange
            int actualProcessCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.ProcessFARepo.DeleteRange(processToDeleteList);
                uow.SaveChanges();
                actualProcessCount = uow.ProcessFARepo.GetAll().Result.Count;
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
                using(UnitOfWorkFA uow = new UnitOfWorkFA())
                {
                    uow.ProcessFARepo.DeleteAll();
                    uow.SaveChanges();
                    actualProcessCount = uow.ProcessFARepo.GetAll().Result.Count;
                }

                //Assert
                Assert.AreEqual(expectedProcessCount, actualProcessCount, "All Processes not deleted from database. Expected Process count = {0}. Actual Process count = {1}.", expectedProcessCount, actualProcessCount);
            }
        }

        #endregion

        #endregion
    }
}
