using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Tests.ManualConfiguration
{
    [TestClass]
    public class PointFATest
    {
        List<GroupFA> _allGroups;
        List<PointFA> _allPoints;
        int _allPointCount;
        bool _deleteAll;

        public PointFATest()
        {
            TestMode.IsTestMode = true;
            _deleteAll = false;
            _allGroups = new List<GroupFA>();
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                _allGroups = uow.GroupFARepo.GetAll().Result;
                _allPoints = uow.PointFARepo.GetAll().Result;
            }
            _allPointCount = _allPoints.Count;
        }

        #region General Tests

        #region add

        [TestMethod]
        public void PointAttachTest()
        {
            //Act
            int expectedPointCount = _allPointCount + 1;

            //Arrange
            int actualPointCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                PointFA point = new PointFA("Add New Point Test");
                point.GroupFAForeignKey = _allGroups.FirstOrDefault().GroupFAPrimaryKey;
                uow.PointFARepo.Attach(point);
                uow.SaveChanges();
                actualPointCount = uow.PointFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedPointCount, actualPointCount, "Point not added to database. Expected Process count = {0}. Actual Process count = {1}.", expectedPointCount, actualPointCount);
        }

        [TestMethod]
        public void PointAttachRangeTest()
        {
            //Act
            int expectedPointCount = _allPointCount + 2;

            //Arrange
            int actualPointCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                List<PointFA> pointsToAdd = new List<PointFA>()
                {
                    new PointFA("Add New Point Test 1"),
                    new PointFA("Add New Point Test 2")
                };
                pointsToAdd[0].GroupFAForeignKey = _allGroups.FirstOrDefault().GroupFAPrimaryKey;
                pointsToAdd[1].GroupFAForeignKey = _allGroups.FirstOrDefault().GroupFAPrimaryKey;
                uow.PointFARepo.AttachRange(pointsToAdd);
                uow.SaveChanges();
                actualPointCount = uow.PointFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedPointCount, actualPointCount, "Group not added to database. Expected Group count = {0}. Actual Group count = {1}.", expectedPointCount, actualPointCount);
        }

        #endregion

        #region delete

        [TestMethod]
        public void PointDeleteTest()
        {
            //Act
            PointFA pointToDelete = new PointFA("Add and Delete Point Test");
            pointToDelete.GroupFAForeignKey = _allGroups.FirstOrDefault().GroupFAPrimaryKey;
            int expectedPointCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.PointFARepo.Attach(pointToDelete);
                uow.SaveChanges();
                expectedPointCount = uow.PointFARepo.GetAll().Result.Count - 1;
            }

            //Arrange
            int actualPointCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.PointFARepo.Delete(pointToDelete);
                uow.SaveChanges();
                actualPointCount = uow.PointFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedPointCount, actualPointCount, "Point not deleted from database. Expected Point count = {0}. Actual Point count = {1}.", expectedPointCount, actualPointCount);
        }

        [TestMethod]
        public void PointDeleteRangeTest()
        {
            //Act
            List<PointFA> pointsToDelete = new List<PointFA>()
            {
                new PointFA("Add and Delete Point Test 1"),
                new PointFA("Add and Delete Point Test 2")
            };
            pointsToDelete[0].GroupFAForeignKey = _allGroups.FirstOrDefault().GroupFAPrimaryKey;
            pointsToDelete[1].GroupFAForeignKey = _allGroups.FirstOrDefault().GroupFAPrimaryKey;
            int expectedPointCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.PointFARepo.AttachRange(pointsToDelete);
                uow.SaveChanges();
                expectedPointCount = uow.PointFARepo.GetAll().Result.Count - 2;
            }

            //Arrange
            int actualPointCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.PointFARepo.DeleteRange(pointsToDelete);
                uow.SaveChanges();
                actualPointCount = uow.PointFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedPointCount, actualPointCount, "Points not deleted from database. Expected Point count = {0}. Actual Point count = {1}.", expectedPointCount, actualPointCount);
        }

        #endregion

        #endregion
    }
}
