using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMPostCCRepo
    {
        Task<List<FDMPostCC>> GetAll();

        Task Attach(FDMPostCC FDMPostCC);

        Task AttachRange(List<FDMPostCC> FDMPostCCList);

        Task Update(FDMPostCC FDMPostCC);

        Task UpdateRange(List<FDMPostCC> FDMPostCCList);

        Task Delete(FDMPostCC FDMPostCC);
    }
}
