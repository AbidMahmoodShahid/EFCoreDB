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
        Task<List<GroupFA>> GetAll();

        Task Attach(GroupFA groupFA);

        Task AttachRange(List<GroupFA> groupFAList);

        Task Update(GroupFA groupFA);

        Task UpdateRange(List<GroupFA> groupFAList);

        Task Delete(GroupFA groupFA);
    }
}
