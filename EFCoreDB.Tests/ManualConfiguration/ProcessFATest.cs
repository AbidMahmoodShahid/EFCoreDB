using EFCoreDB.ManualConfigurationUnitOfWork;
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
        public ProcessFATest()
        {
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
                ProcessFA process = new ProcessFA();
                process.Name = "Add New Process Test";
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
                ProcessFA process1 = new ProcessFA();
                process1.Name = "Add New Process Test 1";
                ProcessFA process2 = new ProcessFA();
                process2.Name = "Add New Process Test 2";
                List<ProcessFA> processList = new List<ProcessFA>()
                {
                    process1,
                    process2
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
            ProcessFA processToDelete = new ProcessFA();
            processToDelete.Name = "Add and Delete Process Test";
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
            ProcessFA processToDelete1 = new ProcessFA();
            processToDelete1.Name = "Add and Delete Multiple Process Test 1";
            ProcessFA processToDelete2 = new ProcessFA();
            processToDelete2.Name = "Add and Delete Multiple Process Test 2";
            List<ProcessFA> processToDeleteList = new List<ProcessFA>()
            {
                processToDelete1,
                processToDelete2
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

        #endregion

        #endregion
    }
}
