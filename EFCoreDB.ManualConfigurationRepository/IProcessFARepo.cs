using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface IProcessFARepo
    {
        Task<List<ProcessFA>> GetAll();

        Task Attach(ProcessFA processFA);

        Task AttachRange(List<ProcessFA> processFAList);

        Task Update(ProcessFA processFA);

        Task UpdateRange(List<ProcessFA> processFAList);

        Task Delete(ProcessFA processFA);

        Task DeleteRange(List<ProcessFA> processFAList);
    }
}
