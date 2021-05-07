using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface IAddressMCRepo
    {
        Task<List<AddressMixedConfiguration>> GetAll();

        Task Attach(AddressMixedConfiguration addressMC);

        Task AttachRange(List<AddressMixedConfiguration> addressMCList);

        Task Update(AddressMixedConfiguration addressMC);

        Task UpdateRange(List<AddressMixedConfiguration> addressMCList);

        Task Delete(AddressMixedConfiguration addressMC);
    }
}
