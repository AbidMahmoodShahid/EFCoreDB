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
    public class FDMTagCCRepo : IFDMTagCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMTagCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMTagCC fDMTagCC)
        {
            _eFCoreDBDataContext.FDMTagCC.Attach(fDMTagCC);
        }

        public async Task AttachRange(List<FDMTagCC> fDMTagCCList)
        {
            _eFCoreDBDataContext.FDMTagCC.AttachRange(fDMTagCCList);
        }

        public async Task Delete(FDMTagCC fDMTagCC)
        {
            _eFCoreDBDataContext.FDMTagCC.Remove(fDMTagCC);
        }

        public async Task<List<FDMTagCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMTagCC.Include(tag => tag.PostList).ToList();
        }

        public async Task Update(FDMTagCC fDMTagCC)
        {
            _eFCoreDBDataContext.FDMTagCC.Update(fDMTagCC);
        }

        public async Task UpdateRange(List<FDMTagCC> fDMTagCCList)
        {
            _eFCoreDBDataContext.FDMTagCC.UpdateRange(fDMTagCCList);
        }
    }
}
