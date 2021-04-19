using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMAddressCCRepo
    {
        Task<List<FDMAddressCC>> GetAll();

        Task Attach(FDMAddressCC fDMAddressCC);

        Task AttachRange(List<FDMAddressCC> fDMAddressCCList);

        Task Update(FDMAddressCC fDMAddressCC);

        Task UpdateRange(List<FDMAddressCC> fDMAddressCCList);

        Task Delete(FDMAddressCC fDMAddressCC);
    }
}
