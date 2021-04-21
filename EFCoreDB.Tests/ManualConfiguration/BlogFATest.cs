using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDB.Tests.ManualConfiguration
{
    [TestClass]
    public class BlogFATest
    {
        List<BlogFA> _allBlogs;
        List<ProcessFA> _allProcess;
        int _allBlogsCount;
        bool _deleteAll;

        public BlogFATest()
        {
            TestMode.IsTestMode = true;
            _deleteAll = false;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                _allProcess = uow.ProcessFARepo.GetAll().Result;
                _allBlogs = uow.BlogFARepo.GetAll().Result;
            }
            _allBlogsCount = _allBlogs.Count;
        }

        #region General Tests

        #region add

        [TestMethod]
        public void BlogAttachTest()
        {
            //Act
            int expectedBlogCount = _allBlogsCount + 1;

            //Arrange
            int actualBlogCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                BlogFA blog = new BlogFA("Add New Blog Test");
                blog.ProcessFAForeignKey = _allProcess.FirstOrDefault().ProcessFAPrimaryKey;
                uow.BlogFARepo.Attach(blog);
                uow.SaveChanges();
                actualBlogCount = uow.BlogFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedBlogCount, actualBlogCount, "Blog not added to database. Expected Blog count = {0}. Actual Blog count = {1}.", expectedBlogCount, actualBlogCount);
        }

        #endregion

        #region delete


        #endregion

        #endregion
    }
}
