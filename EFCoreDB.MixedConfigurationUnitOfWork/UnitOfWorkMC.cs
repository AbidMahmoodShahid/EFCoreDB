using EFCoreDB.MixedConfigurationDataStorage;
using EFCoreDB.MixedConfigurationRepository;
using System;

namespace EFCoreDB.MixedConfigurationUnitOfWork
{
    public class UnitOfWorkMC : IDisposable
    {
        public EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration { get; }

        public UnitOfWorkMC()
        {
            _eFCoreDBDataContextMixedConfiguration = new EFCoreDBDataContextMixedConfiguration();
        }

        #region Repos

        private IProcessMCRepo _processMCRepo;
        public IProcessMCRepo ProcessMCRepo
        {
            get
            {
                if(_processMCRepo == null)
                    _processMCRepo = new ProcessMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _processMCRepo;
            }
        }

        private IGroupMCRepo _groupMCRepo;
        public IGroupMCRepo GroupMCRepo
        {
            get
            {
                if(_groupMCRepo == null)
                    _groupMCRepo = new GroupMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _groupMCRepo;
            }
        }

        private IPointMCRepo _pointMCRepo;
        public IPointMCRepo PointMCRepo
        {
            get
            {
                if(_pointMCRepo == null)
                    _pointMCRepo = new PointMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _pointMCRepo;
            }
        }


        private IBlogMCRepo _blogMCRepo;
        public IBlogMCRepo BlogMCRepo
        {
            get
            {
                if(_blogMCRepo == null)
                    _blogMCRepo = new BlogMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _blogMCRepo;
            }
        }

        private IPostMCRepo _postMCRepo;
        public IPostMCRepo PostMCRepo
        {
            get
            {
                if(_postMCRepo == null)
                    _postMCRepo = new PostMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _postMCRepo;
            }
        }

        private ITagMCRepo _tagMCRepo;
        public ITagMCRepo TagMCRepo
        {
            get
            {
                if(_tagMCRepo == null)
                    _tagMCRepo = new TagMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _tagMCRepo;
            }
        }


        private IBloggerMCRepo _bloggerMCRepo;
        public IBloggerMCRepo BloggerMCRepo
        {
            get
            {
                if(_bloggerMCRepo == null)
                    _bloggerMCRepo = new BloggerMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _bloggerMCRepo;
            }
        }

        private IAddressMCRepo _addressMCRepo;
        public IAddressMCRepo AddressMCRepo
        {
            get
            {
                if(_addressMCRepo == null)
                    _addressMCRepo = new AddressMCRepo(_eFCoreDBDataContextMixedConfiguration);

                return _addressMCRepo;
            }
        }

        #endregion

        #region public methods

        public void SaveChanges()
        {
            _eFCoreDBDataContextMixedConfiguration.SaveChanges();
        }

        public void Dispose()
        {
            _eFCoreDBDataContextMixedConfiguration.Dispose();
        }

        #endregion
    }
}
