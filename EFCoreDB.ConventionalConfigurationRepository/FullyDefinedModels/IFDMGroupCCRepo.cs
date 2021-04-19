using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMGroupCCRepo
    {
        Task<List<FDMGroupCC>> GetAll();

        Task Attach(FDMGroupCC fDMGroupCC);

        Task AttachRange(List<FDMGroupCC> fDMGroupCCList);

        Task Update(FDMGroupCC fDMGroupCC);

        Task UpdateRange(List<FDMGroupCC> fDMGroupCCList);

        Task Delete(FDMGroupCC fDMGroupCC);
    }
}
