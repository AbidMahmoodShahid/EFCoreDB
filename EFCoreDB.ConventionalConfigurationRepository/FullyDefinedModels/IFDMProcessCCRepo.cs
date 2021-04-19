using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMProcessCCRepo
    {
        Task<List<FDMProcessCC>> GetAll();

        Task Attach(FDMProcessCC fDMProcessCC);

        Task AttachRange(List<FDMProcessCC> fDMProcessCCList);

        Task Update(FDMProcessCC fDMProcessCC);

        Task UpdateRange(List<FDMProcessCC> fDMProcessCCList);

        Task Delete(FDMProcessCC fDMProcessCC);

        Task DeleteRange(List<FDMProcessCC> fDMProcessCCList);
    }
}
