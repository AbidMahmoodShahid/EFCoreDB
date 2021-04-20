using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDB.Tests.ManualConfiguration
{
    [TestClass]
    public class GroupFATest
    {
        List<ProcessFA> _allProcess;
        List<GroupFA> _allGroups;
        int _allGroupCount;
        bool _deleteAll;

        public GroupFATest()
        {
            TestMode.IsTestMode = true;
            _deleteAll = false;
            _allProcess = new List<ProcessFA>();
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                _allProcess = uow.ProcessFARepo.GetAll().Result;
                _allGroups = uow.GroupFARepo.GetAll().Result;
            }
            _allGroupCount = _allGroups.Count;
        }

        #region General Tests

        #region add

        [TestMethod]
        public void GroupAttachTest()
        {
            //Act
            int expectedGroupCount = _allGroupCount + 1;

            //Arrange
            int actualGroupCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                GroupFA group = new GroupFA("Add New Group Test");
                group.ProcessFAForeignKey = _allProcess.FirstOrDefault().ProcessFAPrimaryKey;
                uow.GroupFARepo.Attach(group);
                uow.SaveChanges();
                actualGroupCount = uow.GroupFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedGroupCount, actualGroupCount, "Group not added to database. Expected Process count = {0}. Actual Process count = {1}.", expectedGroupCount, actualGroupCount);
        }

        [TestMethod]
        public void GroupAttachRangeTest()
        {
            //Act
            int expectedGroupCount = _allGroupCount + 2;

            //Arrange
            int actualGroupCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                List<GroupFA> groupsToAdd = new List<GroupFA>()
                {
                    new GroupFA("Add New Group Test 1"),
                    new GroupFA("Add New Group Test 2")
                };
                groupsToAdd[0].ProcessFAForeignKey = _allProcess.FirstOrDefault().ProcessFAPrimaryKey;
                groupsToAdd[1].ProcessFAForeignKey = _allProcess.FirstOrDefault().ProcessFAPrimaryKey;
                uow.GroupFARepo.AttachRange(groupsToAdd);
                uow.SaveChanges();
                actualGroupCount = uow.GroupFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedGroupCount, actualGroupCount, "Group not added to database. Expected Group count = {0}. Actual Group count = {1}.", expectedGroupCount, actualGroupCount);
        }

        #endregion

        #region delete

        [TestMethod]
        public void GroupDeleteTest()
        {
            //Act
            GroupFA groupToDelete = new GroupFA("Add and Delete Group Test");
            groupToDelete.ProcessFAForeignKey = _allProcess.FirstOrDefault().ProcessFAPrimaryKey;
            int expectedGroupCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.GroupFARepo.Attach(groupToDelete);
                uow.SaveChanges();
                expectedGroupCount = uow.GroupFARepo.GetAll().Result.Count - 1;
            }

            //Arrange
            int actualGroupCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.GroupFARepo.Delete(groupToDelete);
                uow.SaveChanges();
                actualGroupCount = uow.GroupFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedGroupCount, actualGroupCount, "Group not deleted from database. Expected Group count = {0}. Actual Group count = {1}.", expectedGroupCount, actualGroupCount);
        }

        [TestMethod]
        public void GroupDeleteRangeTest()
        {
            //Act
            List<GroupFA> groupToDelete = new List<GroupFA>()
            {
                new GroupFA("Add and Delete Group Test 1"),
                new GroupFA("Add and Delete Group Test 2")
            };
            groupToDelete[0].ProcessFAForeignKey = _allProcess.FirstOrDefault().ProcessFAPrimaryKey;
            groupToDelete[1].ProcessFAForeignKey = _allProcess.FirstOrDefault().ProcessFAPrimaryKey;
            int expectedGroupCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.GroupFARepo.AttachRange(groupToDelete);
                uow.SaveChanges();
                expectedGroupCount = uow.GroupFARepo.GetAll().Result.Count - 2;
            }

            //Arrange
            int actualGroupCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.GroupFARepo.DeleteRange(groupToDelete);
                uow.SaveChanges();
                actualGroupCount = uow.GroupFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedGroupCount, actualGroupCount, "Groups not deleted from database. Expected Group count = {0}. Actual Group count = {1}.", expectedGroupCount, actualGroupCount);
        }

        #endregion

        #endregion
    }
}
