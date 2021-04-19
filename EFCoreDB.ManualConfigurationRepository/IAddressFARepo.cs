using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface IAddressFARepo
    {
        Task<List<AddressFA>> GetAll();

        Task Attach(AddressFA addressFA);

        Task AttachRange(List<AddressFA> addressFAList);

        Task Update(AddressFA addressFA);

        Task UpdateRange(List<AddressFA> addressFAList);

        Task Delete(AddressFA addressFA);
    }
}
