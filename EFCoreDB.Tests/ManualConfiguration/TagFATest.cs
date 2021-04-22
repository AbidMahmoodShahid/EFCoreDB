using EFCoreDB.ManualConfigurationUnitOfWork;
using EFCoreDB.Models;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDB.Tests.ManualConfiguration
{
    [TestClass]
    public class TagFATest
    {
        List<BlogFA> _allBlogs;
        List<PostFA> _allPosts;
        List<TagFA> _allTags;
        int _allTagsCount;
        int _allPostsCount;
        bool _deleteAll;

        public TagFATest()
        {
            TestMode.IsTestMode = true;
            _deleteAll = false;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                _allTags = uow.TagFARepo.GetAll().Result;
                _allPosts = uow.PostFARepo.GetAll().Result;
                _allBlogs = uow.BlogFARepo.GetAll().Result;
            }
            _allTagsCount = _allTags.Count;
            _allPostsCount = _allPosts.Count;
        }

        #region General Tests

        #region add

        [TestMethod]
        public void TagAttachTest()
        {
            //Act
            int expectedTagCount = _allTagsCount + 1;

            //Arrange
            int actualTagCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                TagFA tag = new TagFA("Add New Tag Test");
                uow.TagFARepo.Attach(tag);
                uow.SaveChanges();
                actualTagCount = uow.TagFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedTagCount, actualTagCount, "Tag not added to database. Expected Tag count = {0}. Actual Tag count = {1}.", expectedTagCount, actualTagCount);
        }

        [TestMethod]
        public void TagAttachWithPostTest()
        {
            //Act
            int expectedTagCount = _allTagsCount + 1;

            //Arrange
            int actualTagCount;
            PostFA post = new PostFA("Post in Tag Test");
            TagFA tag = new TagFA("Add New Tag With Post Test");
            tag.PostList.Add(post);
            BlogFA blog = _allBlogs.FirstOrDefault();
            blog.PostList.Add(post);
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.BlogFARepo.Update(blog);
                uow.TagFARepo.Attach(tag);
                uow.SaveChanges();
                actualTagCount = uow.TagFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedTagCount, actualTagCount, "Tag not added to database. Expected Tag count = {0}. Actual Tag count = {1}.", expectedTagCount, actualTagCount);
        }

        [TestMethod]
        public void TagAndPostAttachTest()
        {
            //Act
            int expectedTagCount = _allTagsCount + 1;
            int expectedPostCount = _allPostsCount + 1;

            //Arrange
            int actualTagCount;
            int actualPostCount;
            PostFA post = new PostFA("Post in Tag Test 1");
            TagFA tag = new TagFA("Tag Test 1");
            tag.PostList.Add(post);
            post.TagList.Add(tag);
            BlogFA blog = _allBlogs.FirstOrDefault();
            blog.PostList.Add(post);

            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.BlogFARepo.Update(blog);
                uow.SaveChanges();
                actualTagCount = uow.TagFARepo.GetAll().Result.Count;
                actualPostCount = uow.PostFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedTagCount, actualTagCount, "Tag not added to database. Expected Tag count = {0}. Actual Tag count = {1}.", expectedTagCount, actualTagCount);
            Assert.AreEqual(expectedPostCount, actualPostCount, "Post not added to database. Expected Post count = {0}. Actual Post count = {1}.", expectedPostCount, actualPostCount);

        }

        #endregion

        #region delete

        [TestMethod]
        public void TagDeleteTest()
        {
            //Act
            int expectedTagCount = _allTagsCount - 1;

            //Arrange
            int actualTagCount;
            using(UnitOfWorkFA uow = new UnitOfWorkFA())
            {
                uow.TagFARepo.Delete(_allTags.FirstOrDefault());
                uow.SaveChanges();
                actualTagCount = uow.TagFARepo.GetAll().Result.Count;
            }

            //Assert
            Assert.AreEqual(expectedTagCount, actualTagCount, "Tag not deleted from database. Expected Tag count = {0}. Actual Tag count = {1}.", expectedTagCount, actualTagCount);
        }

        #endregion

        #endregion
    }
}
