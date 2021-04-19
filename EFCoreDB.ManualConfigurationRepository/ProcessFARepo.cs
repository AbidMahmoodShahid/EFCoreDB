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

        public async Task Attach(ProcessFA processFA)
        {
            _eFCoreDBDataContextFA.ProcessFA.Attach(processFA);
        }

        public async Task AttachRange(List<ProcessFA> processFAList)
        {
            _eFCoreDBDataContextFA.ProcessFA.AttachRange(processFAList);
        }

        public async Task Delete(ProcessFA processFA)
        {
            _eFCoreDBDataContextFA.ProcessFA.Remove(processFA);
        }

        public async Task DeleteRange(List<ProcessFA> processFAList)
        {
            _eFCoreDBDataContextFA.ProcessFA.RemoveRange(processFAList);
        }

        public async Task<List<ProcessFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.ProcessFA.Include(process => process.GroupList).ToList();
        }

        public async Task Update(ProcessFA processFA)
        {
            _eFCoreDBDataContextFA.ProcessFA.Update(processFA);
        }

        public async Task UpdateRange(List<ProcessFA> processFAList)
        {
            _eFCoreDBDataContextFA.ProcessFA.UpdateRange(processFAList);
        }
    }
}
