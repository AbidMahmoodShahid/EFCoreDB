using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EFCoreDB.Tests.ManualConfiguration
{
    [TestClass]
    public class ProcessFATest
    {
        [TestMethod]
        public void ProcessAttachTest()
        {
            //Act
            int expectedProcessCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                expectedProcessCount = uow.ProcessFARepo.GetAll().Result.Count + 1;
            }

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
    }
}
