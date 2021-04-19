using EFCoreDB.DataStorage;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public class FDMBloggerCCRepo : IFDMBloggerCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMBloggerCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMBloggerCC fDMBloggerCC)
        {
            _eFCoreDBDataContext.FDMBloggerCC.Attach(fDMBloggerCC);
        }

        public async Task AttachRange(List<FDMBloggerCC> fDMBloggerCCList)
        {
            _eFCoreDBDataContext.FDMBloggerCC.AttachRange(fDMBloggerCCList);
        }

        public async Task Delete(FDMBloggerCC fDMBloggerCC)
        {
            _eFCoreDBDataContext.FDMBloggerCC.Remove(fDMBloggerCC);
        }

        public async Task<List<FDMBloggerCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMBloggerCC.ToList();
        }

        public async Task Update(FDMBloggerCC fDMBloggerCC)
        {
            _eFCoreDBDataContext.FDMBloggerCC.Update(fDMBloggerCC);
        }

        public async Task UpdateRange(List<FDMBloggerCC> fDMBloggerCCList)
        {
            _eFCoreDBDataContext.FDMBloggerCC.UpdateRange(fDMBloggerCCList);
        }
    }
}
