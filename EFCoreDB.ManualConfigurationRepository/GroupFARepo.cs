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
    public class GroupFARepo : IGroupFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public GroupFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        #region get

        public async Task<List<GroupFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.GroupFA.Include(group => group.PointList).ToList();
        }

        #endregion

        #region add

        public async Task Attach(GroupFA groupFA)
        {
            _eFCoreDBDataContextFA.GroupFA.Attach(groupFA);
        }

        public async Task AttachRange(List<GroupFA> groupFAList)
        {
            _eFCoreDBDataContextFA.GroupFA.AttachRange(groupFAList);
        }

        #endregion

        #region delete

        public async Task Delete(GroupFA groupFA)
        {
            _eFCoreDBDataContextFA.GroupFA.Remove(groupFA);
        }

        public async Task DeleteRange(List<GroupFA> groupFAList)
        {
            _eFCoreDBDataContextFA.GroupFA.RemoveRange(groupFAList);
        }

        #endregion

        #region update

        public async Task Update(GroupFA groupFA)
        {
            _eFCoreDBDataContextFA.GroupFA.Update(groupFA);
        }

        public async Task UpdateRange(List<GroupFA> groupFAList)
        {
            _eFCoreDBDataContextFA.GroupFA.UpdateRange(groupFAList);
        }

        #endregion

    }
}
