using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface IGroupMCRepo
    {
        #region get

        Task<List<GroupMixedConfiguration>> GetAll();

        #endregion

        #region add

        Task Attach(GroupMixedConfiguration groupMC);

        Task AttachRange(List<GroupMixedConfiguration> groupMCList);

        #endregion

        #region delete

        Task Delete(GroupMixedConfiguration groupMC);

        Task DeleteRange(List<GroupMixedConfiguration> groupMCList);

        #endregion

        #region update

        Task Update(GroupMixedConfiguration groupMC);

        Task UpdateRange(List<GroupMixedConfiguration> groupMCList);

        #endregion

    }
}
