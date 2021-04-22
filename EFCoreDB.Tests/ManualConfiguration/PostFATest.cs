using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDB.Tests.ManualConfiguration
{
    [TestClass]
    public class PostFATest
    {
        List<BlogFA> _allBlogs;
        List<PostFA> _allPosts;
        int _allPostsCount;
        bool _deleteAll;

        public PostFATest()
        {
            TestMode.IsTestMode = true;
            _deleteAll = false;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                _allPosts = uow.PostFARepo.GetAll().Result;
                _allBlogs = uow.BlogFARepo.GetAll().Result;
            }
            _allPostsCount = _allPosts.Count;
        }

        #region General Tests

        #region add

        [TestMethod]
        public void PostAttachTest()
        {
            //Act
            int expectedPostCount = _allPostsCount + 1;

            //Arrange
            int actualPostCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                PostFA post = new PostFA("Add New Post Test");
                post.BlogFAForeignKey = _allBlogs.FirstOrDefault().BlogFAPrimaryKey;
                uow.PostFARepo.Attach(post);
                uow.SaveChanges();
                actualPostCount = uow.PostFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedPostCount, actualPostCount, "Post not added to database. Expected Post count = {0}. Actual Post count = {1}.", expectedPostCount, actualPostCount);
        }

        [TestMethod]
        public void TagAttachWithPostTest()
        {
            //Act
            int expectedPostCount = _allPostsCount + 1;

            //Arrange
            int actualPostCount;
            BlogFA blog = _allBlogs.FirstOrDefault();
            TagFA tag = new TagFA("Add New Tag In Post Test");
            PostFA post = new PostFA("Post with Tag Test");
            post.TagList.Add(tag);
            post.BlogFAForeignKey = blog.BlogFAPrimaryKey;

            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.PostFARepo.Attach(post);
                uow.SaveChanges();
                actualPostCount = uow.PostFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedPostCount, actualPostCount, "Post not added to database. Expected Post count = {0}. Actual Post count = {1}.", expectedPostCount, actualPostCount);
        }

        #endregion

        #region delete


        #endregion

        #endregion
    }
}
