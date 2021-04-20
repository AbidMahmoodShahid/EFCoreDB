using EFCoreDB.ManualConfigurationDataStorage;
using EFCoreDB.ManualConfigurationRepository;
using System;

namespace EFCoreDB.ManualConfigurationUnitOfWork
{
    public class UnitOfWorkFA : IDisposable
    {
        public EFCoreDBDataContextFA EFCoreDBDataContextFA { get; }

        public UnitOfWorkFA()
        {
            EFCoreDBDataContextFA = new EFCoreDBDataContextFA();
        }

        #region Repos

        private IProcessFARepo _processFARepo;
        public IProcessFARepo ProcessFARepo
        {
            get
            {
                if(_processFARepo == null)
                    _processFARepo = new ProcessFARepo(EFCoreDBDataContextFA);

                return _processFARepo;
            }
        }

        private IGroupFARepo _groupFARepo;
        public IGroupFARepo GroupFARepo
        {
            get
            {
                if(_groupFARepo == null)
                    _groupFARepo = new GroupFARepo(EFCoreDBDataContextFA);

                return _groupFARepo;
            }
        }

        private IPointFARepo _pointFARepo;
        public IPointFARepo PointFARepo
        {
            get
            {
                if(_pointFARepo == null)
                    _pointFARepo = new PointFARepo(EFCoreDBDataContextFA);

                return _pointFARepo;
            }
        }


        private IBlogFARepo _blogFARepo;
        public IBlogFARepo BlogFARepo
        {
            get
            {
                if(_blogFARepo == null)
                    _blogFARepo = new BlogFARepo(EFCoreDBDataContextFA);

                return _blogFARepo;
            }
        }

        private IPostFARepo _postFARepo;
        public IPostFARepo PostFARepo
        {
            get
            {
                if(_postFARepo == null)
                    _postFARepo = new PostFARepo(EFCoreDBDataContextFA);

                return _postFARepo;
            }
        }

        private ITagFARepo _tagFARepo;
        public ITagFARepo TagFARepo
        {
            get
            {
                if(_tagFARepo == null)
                    _tagFARepo = new TagFARepo(EFCoreDBDataContextFA);

                return _tagFARepo;
            }
        }


        private IBloggerFARepo _bloggerFARepo;
        public IBloggerFARepo BloggerFARepo
        {
            get
            {
                if(_bloggerFARepo == null)
                    _bloggerFARepo = new BloggerFARepo(EFCoreDBDataContextFA);

                return _bloggerFARepo;
            }
        }

        private IAddressFARepo _addressFARepo;
        public IAddressFARepo AddressFARepo
        {
            get
            {
                if(_addressFARepo == null)
                    _addressFARepo = new AddressFARepo(EFCoreDBDataContextFA);

                return _addressFARepo;
            }
        }

        #endregion

        #region public methods

        public void SaveChanges()
        {
            EFCoreDBDataContextFA.SaveChanges();
        }

        public void Dispose()
        {
            EFCoreDBDataContextFA.Dispose();
        }

        #endregion
    }
}
