using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface IPointMCRepo
    {
        #region get

        Task<List<PointMixedConfiguration>> GetAll();

        #endregion

        #region add

        Task Attach(PointMixedConfiguration pointMC);

        Task AttachRange(List<PointMixedConfiguration> pointMCList);

        #endregion

        #region delete

        Task Delete(PointMixedConfiguration pointMC);

        Task DeleteRange(List<PointMixedConfiguration> pointMCList);

        #endregion

        #region update

        Task Update(PointMixedConfiguration pointMC);

        Task UpdateRange(List<PointMixedConfiguration> pointMCList);

        #endregion

    }
}
