using EFCoreDB.MixedConfigurationDataStorage;
using EFCoreDB.Models.MixedConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public class ProcessMCRepo : IProcessMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public ProcessMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        #region get 

        public async Task<List<ProcessMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.ProcessMC.Include(process => process.GroupList).ToList();
        }

        public async Task<ProcessMixedConfiguration> GetUsingPrimaryKey(int primaryKey)
        {
            return _eFCoreDBDataContextMixedConfiguration.ProcessMC.Where(process => process.ProcessMCPrimaryKey == primaryKey).Include(process => process.GroupList).FirstOrDefault();
        }

        public async Task<List<ProcessMixedConfiguration>> GetUsingName(string name)
        {
            return _eFCoreDBDataContextMixedConfiguration.ProcessMC.Where(process => process.Name == name).Include(process => process.GroupList).ToList();
        }

        #endregion

        #region add

        public async Task Attach(ProcessMixedConfiguration processMC)
        {
            _eFCoreDBDataContextMixedConfiguration.ProcessMC.Attach(processMC);
        }

        public async Task AttachRange(List<ProcessMixedConfiguration> processMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.ProcessMC.AttachRange(processMCList);
        }

        #endregion

        #region delete

        public async Task Delete(ProcessMixedConfiguration processMC)
        {
            _eFCoreDBDataContextMixedConfiguration.ProcessMC.Remove(processMC);
        }

        public async Task DeleteRange(List<ProcessMixedConfiguration> processMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.ProcessMC.RemoveRange(processMCList);
        }

        public async Task DeleteAll()
        {
            List<ProcessMixedConfiguration> processMCList = _eFCoreDBDataContextMixedConfiguration.ProcessMC.Include(process => process.GroupList).ToList();
            _eFCoreDBDataContextMixedConfiguration.ProcessMC.RemoveRange(processMCList);
        }

        #endregion

        #region update

        public async Task Update(ProcessMixedConfiguration processMC)
        {
            _eFCoreDBDataContextMixedConfiguration.ProcessMC.Update(processMC);
        }

        public async Task UpdateRange(List<ProcessMixedConfiguration> processMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.ProcessMC.UpdateRange(processMCList);
        }

        #endregion

    }
}
