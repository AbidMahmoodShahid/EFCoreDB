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
    public class GroupMCRepo : IGroupMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public GroupMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        #region get

        public async Task<List<GroupMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.GroupMC.Include(group => group.PointList).ToList();
        }

        #endregion

        #region add

        public async Task Attach(GroupMixedConfiguration groupMC)
        {
            _eFCoreDBDataContextMixedConfiguration.GroupMC.Attach(groupMC);
        }

        public async Task AttachRange(List<GroupMixedConfiguration> groupMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.GroupMC.AttachRange(groupMCList);
        }

        #endregion

        #region delete

        public async Task Delete(GroupMixedConfiguration groupMC)
        {
            _eFCoreDBDataContextMixedConfiguration.GroupMC.Remove(groupMC);
        }

        public async Task DeleteRange(List<GroupMixedConfiguration> groupMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.GroupMC.RemoveRange(groupMCList);
        }

        #endregion

        #region update

        public async Task Update(GroupMixedConfiguration groupMC)
        {
            _eFCoreDBDataContextMixedConfiguration.GroupMC.Update(groupMC);
        }

        public async Task UpdateRange(List<GroupMixedConfiguration> groupMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.GroupMC.UpdateRange(groupMCList);
        }

        #endregion

    }
}
