using EFCoreDB.ManualConfigurationDataStorage;
using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public class PointFARepo : IPointFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public PointFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        public async Task Attach(PointFA pointFA)
        {
            _eFCoreDBDataContextFA.PointFA.Attach(pointFA);
        }

        public async Task AttachRange(List<PointFA> pointFAList)
        {
            _eFCoreDBDataContextFA.PointFA.AttachRange(pointFAList);
        }

        public async Task Delete(PointFA pointFA)
        {
            _eFCoreDBDataContextFA.PointFA.Remove(pointFA);
        }

        public async Task<List<PointFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.PointFA.ToList();
        }

        public async Task Update(PointFA pointFA)
        {
            _eFCoreDBDataContextFA.PointFA.Update(pointFA);
        }

        public async Task UpdateRange(List<PointFA> pointFAList)
        {
            _eFCoreDBDataContextFA.PointFA.UpdateRange(pointFAList);
        }
    }
}
