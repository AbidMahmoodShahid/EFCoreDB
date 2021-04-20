using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface IGroupFARepo
    {
        #region get

        Task<List<GroupFA>> GetAll();

        #endregion

        #region add

        Task Attach(GroupFA groupFA);

        Task AttachRange(List<GroupFA> groupFAList);

        #endregion

        #region delete

        Task Delete(GroupFA groupFA);

        Task DeleteRange(List<GroupFA> groupFAList);

        #endregion

        #region update

        Task Update(GroupFA groupFA);

        Task UpdateRange(List<GroupFA> groupFAList);

        #endregion

    }
}
