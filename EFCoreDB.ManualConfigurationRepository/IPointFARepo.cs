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
        #region get

        Task<List<PointFA>> GetAll();

        #endregion

        #region add

        Task Attach(PointFA pointFA);

        Task AttachRange(List<PointFA> pointFAList);

        #endregion

        #region delete

        Task Delete(PointFA pointFA);

        Task DeleteRange(List<PointFA> pointFAList);

        #endregion

        #region update

        Task Update(PointFA pointFA);

        Task UpdateRange(List<PointFA> pointFAList);

        #endregion

    }
}
