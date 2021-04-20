using EFCoreDB.ManualConfigurationDataStorage;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public class ProcessFARepo : IProcessFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public ProcessFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        #region get 

        public async Task<List<ProcessFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.ProcessFA.Include(process => process.GroupList).ToList();
        }

        public async Task<ProcessFA> GetUsingPrimaryKey(int primaryKey)
        {
            return _eFCoreDBDataContextFA.ProcessFA.Where(process => process.ProcessFAPrimaryKey == primaryKey).Include(process => process.GroupList).FirstOrDefault();
        }

        public async Task<List<ProcessFA>> GetUsingName(string name)
        {
            return _eFCoreDBDataContextFA.ProcessFA.Where(process => process.Name == name).Include(process => process.GroupList).ToList();
        }

        #endregion

        #region add

        public async Task Attach(ProcessFA processFA)
        {
            _eFCoreDBDataContextFA.ProcessFA.Attach(processFA);
        }

        public async Task AttachRange(List<ProcessFA> processFAList)
        {
            _eFCoreDBDataContextFA.ProcessFA.AttachRange(processFAList);
        }

        #endregion

        #region delete

        public async Task Delete(ProcessFA processFA)
        {
            _eFCoreDBDataContextFA.ProcessFA.Remove(processFA);
        }

        public async Task DeleteRange(List<ProcessFA> processFAList)
        {
            _eFCoreDBDataContextFA.ProcessFA.RemoveRange(processFAList);
        }

        public async Task DeleteUsingPrimaryKey(int primaryKey)
        {
            _eFCoreDBDataContextFA.Remove((_eFCoreDBDataContextFA.ProcessFA.Single(process => process.ProcessFAPrimaryKey == primaryKey)));
        }

        public async Task DeleteAllAndReseed()
        {
            _eFCoreDBDataContextFA.Database.ExecuteSqlCommand("DBCC CHECKIDENT('TableName', RESEED, 0)");
        }

        #endregion

        #region update

        public async Task Update(ProcessFA processFA)
        {
            _eFCoreDBDataContextFA.ProcessFA.Update(processFA);
        }

        public async Task UpdateRange(List<ProcessFA> processFAList)
        {
            _eFCoreDBDataContextFA.ProcessFA.UpdateRange(processFAList);
        }

        #endregion

    }
}
