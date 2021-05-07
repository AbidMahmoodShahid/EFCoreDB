using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface IProcessMCRepo
    {
        #region get 

        Task<List<ProcessMixedConfiguration>> GetAll();

        Task<ProcessMixedConfiguration> GetUsingPrimaryKey(int primaryKey);

        Task<List<ProcessMixedConfiguration>> GetUsingName(string name);

        #endregion

        #region add

        Task Attach(ProcessMixedConfiguration processMC);

        Task AttachRange(List<ProcessMixedConfiguration> processMCList);

        #endregion

        #region delete

        Task Delete(ProcessMixedConfiguration processMC);

        Task DeleteRange(List<ProcessMixedConfiguration> processMCList);

        Task DeleteAll();

        #endregion

        #region update

        Task Update(ProcessMixedConfiguration processMC);

        Task UpdateRange(List<ProcessMixedConfiguration> processMCList);

        #endregion
    }
}
