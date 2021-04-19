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
        #region get

        Task<List<FDMProcessCC>> GetAll();

        Task<FDMProcessCC> GetUsingPrimaryKey(int primaryKey);

        Task<List<FDMProcessCC>> GetUsingName(string name);

        #endregion

        #region add

        Task Attach(FDMProcessCC fDMProcessCC);

        Task AttachRange(List<FDMProcessCC> fDMProcessCCList);

        #endregion

        #region delete

        Task Delete(FDMProcessCC fDMProcessCC);

        Task DeleteRange(List<FDMProcessCC> fDMProcessCCList);

        Task DeleteUsingPrimaryKey(int primaryKey);

        #endregion

        #region update

        Task Update(FDMProcessCC fDMProcessCC);

        Task UpdateRange(List<FDMProcessCC> fDMProcessCCList);

        #endregion

    }
}
