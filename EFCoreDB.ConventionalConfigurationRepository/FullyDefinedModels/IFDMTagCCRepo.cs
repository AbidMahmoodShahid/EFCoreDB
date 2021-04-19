using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMTagCCRepo
    {
        Task<List<FDMTagCC>> GetAll();

        Task Attach(FDMTagCC fDMTagCC);

        Task AttachRange(List<FDMTagCC> fDMTagCCList);

        Task Update(FDMTagCC fDMTagCC);

        Task UpdateRange(List<FDMTagCC> fDMTagCCList);

        Task Delete(FDMTagCC fDMTagCC);
    }
}
