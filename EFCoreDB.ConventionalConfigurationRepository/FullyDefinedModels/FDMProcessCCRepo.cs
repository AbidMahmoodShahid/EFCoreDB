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
    public class FDMProcessCCRepo : IFDMProcessCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMProcessCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMProcessCC fDMProcessCC)
        {
            _eFCoreDBDataContext.FDMProcessCC.Attach(fDMProcessCC);
        }

        public async Task AttachRange(List<FDMProcessCC> fDMProcessCCList)
        {
            _eFCoreDBDataContext.FDMProcessCC.AttachRange(fDMProcessCCList);
        }

        public async Task Delete(FDMProcessCC fDMProcessCC)
        {
            _eFCoreDBDataContext.FDMProcessCC.Remove(fDMProcessCC);
        }

        public async Task DeleteRange(List<FDMProcessCC> fDMProcessCCList)
        {
            _eFCoreDBDataContext.FDMProcessCC.RemoveRange(fDMProcessCCList);
        }

        public async Task<List<FDMProcessCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMProcessCC.Include(process => process.GroupList).ToList();
        }

        public async Task Update(FDMProcessCC fDMProcessCC)
        {
            _eFCoreDBDataContext.FDMProcessCC.Update(fDMProcessCC);
        }

        public async Task UpdateRange(List<FDMProcessCC> fDMProcessCCList)
        {
            _eFCoreDBDataContext.FDMProcessCC.UpdateRange(fDMProcessCCList);
        }
    }
}
