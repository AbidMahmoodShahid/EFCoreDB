using EFCoreDB.DataStorage;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public class FDMPointCCRepo : IFDMPointCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMPointCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMPointCC fDMPointCC)
        {
            _eFCoreDBDataContext.FDMPointCC.Attach(fDMPointCC);
        }

        public async Task AttachRange(List<FDMPointCC> fDMPointCCList)
        {
            _eFCoreDBDataContext.FDMPointCC.AttachRange(fDMPointCCList);
        }

        public async Task Delete(FDMPointCC fDMPointCC)
        {
            _eFCoreDBDataContext.FDMPointCC.Remove(fDMPointCC);
        }

        public async Task<List<FDMPointCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMPointCC.ToList();
        }

        public async Task Update(FDMPointCC fDMPointCC)
        {
            _eFCoreDBDataContext.FDMPointCC.Update(fDMPointCC);
        }

        public async Task UpdateRange(List<FDMPointCC> fDMPointCCList)
        {
            _eFCoreDBDataContext.FDMPointCC.UpdateRange(fDMPointCCList);
        }
    }
}
