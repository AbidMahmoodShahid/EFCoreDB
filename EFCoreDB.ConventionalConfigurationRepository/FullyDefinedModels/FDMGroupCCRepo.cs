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
    public class FDMGroupCCRepo : IFDMGroupCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMGroupCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMGroupCC fDMGroupCC)
        {
            _eFCoreDBDataContext.FDMGroupCC.Attach(fDMGroupCC);
        }

        public async Task AttachRange(List<FDMGroupCC> fDMGroupCCList)
        {
            _eFCoreDBDataContext.FDMGroupCC.AttachRange(fDMGroupCCList);
        }

        public async Task Delete(FDMGroupCC fDMGroupCC)
        {
            _eFCoreDBDataContext.FDMGroupCC.Remove(fDMGroupCC);
        }

        public async Task<List<FDMGroupCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMGroupCC.Include(group => group.PointList).ToList();
        }

        public async Task Update(FDMGroupCC fDMGroupCC)
        {
            _eFCoreDBDataContext.FDMGroupCC.Update(fDMGroupCC);
        }

        public async Task UpdateRange(List<FDMGroupCC> fDMGroupCCList)
        {
            _eFCoreDBDataContext.FDMGroupCC.UpdateRange(fDMGroupCCList);
        }
    }
}
