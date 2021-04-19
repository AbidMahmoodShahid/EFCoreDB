using EFCoreDB.DataStorage;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public class FDMPostCCRepo : IFDMPostCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMPostCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMPostCC fDMPostCC)
        {
            _eFCoreDBDataContext.FDMPostCC.Attach(fDMPostCC);
        }

        public async Task AttachRange(List<FDMPostCC> fDMPostCCList)
        {
            _eFCoreDBDataContext.FDMPostCC.AttachRange(fDMPostCCList);
        }

        public async Task Delete(FDMPostCC fDMPostCC)
        {
            _eFCoreDBDataContext.FDMPostCC.Remove(fDMPostCC);
        }

        public async Task<List<FDMPostCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMPostCC.Include(post => post.TagList).ToList();
        }

        public async Task Update(FDMPostCC fDMPostCC)
        {
            _eFCoreDBDataContext.FDMPostCC.Update(fDMPostCC);
        }

        public async Task UpdateRange(List<FDMPostCC> fDMPostCCList)
        {
            _eFCoreDBDataContext.FDMPostCC.UpdateRange(fDMPostCCList);
        }
    }
}
