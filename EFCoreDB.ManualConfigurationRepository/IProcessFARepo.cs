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
        #region get 

        Task<List<ProcessFA>> GetAll();

        Task<ProcessFA> GetUsingPrimaryKey(int primaryKey);

        Task<List<ProcessFA>> GetUsingName(string name);

        #endregion

        #region add

        Task Attach(ProcessFA processFA);

        Task AttachRange(List<ProcessFA> processFAList);

        #endregion

        #region delete

        Task Delete(ProcessFA processFA);

        Task DeleteRange(List<ProcessFA> processFAList);

        Task DeleteUsingPrimaryKey(int primaryKey);

        Task DeleteAllAndReseed();

        #endregion

        #region update

        Task Update(ProcessFA processFA);

        Task UpdateRange(List<ProcessFA> processFAList);

        #endregion
    }
}
