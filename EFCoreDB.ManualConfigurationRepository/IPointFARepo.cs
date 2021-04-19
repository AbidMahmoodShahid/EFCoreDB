using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface IPointFARepo
    {
        Task<List<PointFA>> GetAll();

        Task Attach(PointFA pointFA);

        Task AttachRange(List<PointFA> pointFAList);

        Task Update(PointFA pointFA);

        Task UpdateRange(List<PointFA> pointFAList);

        Task Delete(PointFA pointFA);
    }
}
