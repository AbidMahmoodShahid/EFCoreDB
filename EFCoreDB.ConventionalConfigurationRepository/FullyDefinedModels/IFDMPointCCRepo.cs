using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMPointCCRepo
    {
        Task<List<FDMPointCC>> GetAll();

        Task Attach(FDMPointCC fDMPointCC);

        Task AttachRange(List<FDMPointCC> fDMPointCCList);

        Task Update(FDMPointCC fDMPointCC);

        Task UpdateRange(List<FDMPointCC> fDMPointCCList);

        Task Delete(FDMPointCC fDMPointCC);
    }
}
