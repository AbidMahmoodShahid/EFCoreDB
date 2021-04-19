using EFCoreDB.DataStorage;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public class FDMAddressCCRepo : IFDMAddressCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMAddressCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMAddressCC fDMAddressCC)
        {
            _eFCoreDBDataContext.FDMAddressCC.Attach(fDMAddressCC);
        }

        public async Task AttachRange(List<FDMAddressCC> fDMAddressCCList)
        {
            _eFCoreDBDataContext.FDMAddressCC.AttachRange(fDMAddressCCList);
        }

        public async Task Delete(FDMAddressCC fDMAddressCC)
        {
            _eFCoreDBDataContext.FDMAddressCC.Remove(fDMAddressCC);
        }

        public async Task<List<FDMAddressCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMAddressCC.ToList();
        }

        public async Task Update(FDMAddressCC fDMAddressCC)
        {
            _eFCoreDBDataContext.FDMAddressCC.Update(fDMAddressCC);
        }

        public async Task UpdateRange(List<FDMAddressCC> fDMAddressCCList)
        {
            _eFCoreDBDataContext.FDMAddressCC.UpdateRange(fDMAddressCCList);
        }
    }
}
