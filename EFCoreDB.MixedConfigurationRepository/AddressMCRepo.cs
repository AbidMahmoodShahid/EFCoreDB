using EFCoreDB.MixedConfigurationDataStorage;
using EFCoreDB.Models.MixedConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public class AddressMCRepo : IAddressMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public AddressMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        public async Task Attach(AddressMixedConfiguration addressMC)
        {
            _eFCoreDBDataContextMixedConfiguration.AddressMC.Attach(addressMC);
        }

        public async Task AttachRange(List<AddressMixedConfiguration> addressMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.AddressMC.AttachRange(addressMCList);
        }

        public async Task Delete(AddressMixedConfiguration addressMC)
        {
            _eFCoreDBDataContextMixedConfiguration.AddressMC.Remove(addressMC);
        }

        public async Task<List<AddressMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.AddressMC.ToList();
        }

        public async Task Update(AddressMixedConfiguration addressMC)
        {
            _eFCoreDBDataContextMixedConfiguration.AddressMC.Update(addressMC);
        }

        public async Task UpdateRange(List<AddressMixedConfiguration> addressMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.AddressMC.UpdateRange(addressMCList);
        }
    }
}
