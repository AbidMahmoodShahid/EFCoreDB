using EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels;
using EFCoreDB.DataStorage;
using System;

namespace EFCoreDB.ConventionalConfigurationUnitOfWork
{
    public class FDMUnitOfWork : IDisposable
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMUnitOfWork()
        {
            _eFCoreDBDataContext = new EFCoreDBDataContext();
        }

        #region Repos

        private IFDMProcessCCRepo _fDMProcessCCRepo;
        public IFDMProcessCCRepo FDMProcessCCRepo
        {
            get
            {
                if (_fDMProcessCCRepo == null)
                    _fDMProcessCCRepo = new FDMProcessCCRepo(_eFCoreDBDataContext);

                return _fDMProcessCCRepo;
            }
        }

        private IFDMGroupCCRepo _fDMGroupCCRepo;
        public IFDMGroupCCRepo FDMGroupCCRepo
        {
            get
            {
                if (_fDMGroupCCRepo == null)
                    _fDMGroupCCRepo = new FDMGroupCCRepo(_eFCoreDBDataContext);

                return _fDMGroupCCRepo;
            }
        }

        private IFDMPointCCRepo _fDMPointCCRepo;
        public IFDMPointCCRepo FDMPointCCRepo
        {
            get
            {
                if (_fDMPointCCRepo == null)
                    _fDMPointCCRepo = new FDMPointCCRepo(_eFCoreDBDataContext);

                return _fDMPointCCRepo;
            }
        }


        private IFDMBlogCCRepo _fDMBlogCCRepo;
        public IFDMBlogCCRepo FDMBlogCCRepo
        {
            get
            {
                if (_fDMBlogCCRepo == null)
                    _fDMBlogCCRepo = new FDMBlogCCRepo(_eFCoreDBDataContext);

                return _fDMBlogCCRepo;
            }
        }

        private IFDMPostCCRepo _fDMPostCCRepo;
        public IFDMPostCCRepo FDMPostCCRepo
        {
            get
            {
                if (_fDMPostCCRepo == null)
                    _fDMPostCCRepo = new FDMPostCCRepo(_eFCoreDBDataContext);

                return _fDMPostCCRepo;
            }
        }

        private IFDMTagCCRepo _fDMTagCCRepo;
        public IFDMTagCCRepo FDMTagCCRepo
        {
            get
            {
                if (_fDMTagCCRepo == null)
                    _fDMTagCCRepo = new FDMTagCCRepo(_eFCoreDBDataContext);

                return _fDMTagCCRepo;
            }
        }


        private IFDMBloggerCCRepo _fDMBloggerCCRepo;
        public IFDMBloggerCCRepo FDMBloggerCCRepo
        {
            get
            {
                if (_fDMBloggerCCRepo == null)
                    _fDMBloggerCCRepo = new FDMBloggerCCRepo(_eFCoreDBDataContext);

                return _fDMBloggerCCRepo;
            }
        }

        private IFDMAddressCCRepo _fDMAddressCCRepo;
        public IFDMAddressCCRepo FDMAddressCCRepo
        {
            get
            {
                if (_fDMAddressCCRepo == null)
                    _fDMAddressCCRepo = new FDMAddressCCRepo(_eFCoreDBDataContext);

                return _fDMAddressCCRepo;
            }
        }

        #endregion

        #region public methods

        public void SaveChanges()
        {
            _eFCoreDBDataContext.SaveChanges();
        }

        public void Dispose()
        {
            _eFCoreDBDataContext.Dispose();
        }

        #endregion
    }
}
