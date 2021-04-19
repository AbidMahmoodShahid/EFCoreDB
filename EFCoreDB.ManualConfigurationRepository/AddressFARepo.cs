using EFCoreDB.ManualConfigurationDataStorage;
using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public class AddressFARepo : IAddressFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public AddressFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        public async Task Attach(AddressFA addressFA)
        {
            _eFCoreDBDataContextFA.AddressFA.Attach(addressFA);
        }

        public async Task AttachRange(List<AddressFA> addressFAList)
        {
            _eFCoreDBDataContextFA.AddressFA.AttachRange(addressFAList);
        }

        public async Task Delete(AddressFA addressFA)
        {
            _eFCoreDBDataContextFA.AddressFA.Remove(addressFA);
        }

        public async Task<List<AddressFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.AddressFA.ToList();
        }

        public async Task Update(AddressFA addressFA)
        {
            _eFCoreDBDataContextFA.AddressFA.Update(addressFA);
        }

        public async Task UpdateRange(List<AddressFA> addressFAList)
        {
            _eFCoreDBDataContextFA.AddressFA.UpdateRange(addressFAList);
        }
    }
}
