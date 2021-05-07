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
    public class PointMCRepo : IPointMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public PointMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        #region get

        public async Task<List<PointMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.PointMC.ToList();
        }

        #endregion

        #region add

        public async Task Attach(PointMixedConfiguration pointMC)
        {
            _eFCoreDBDataContextMixedConfiguration.PointMC.Attach(pointMC);
        }

        public async Task AttachRange(List<PointMixedConfiguration> pointMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.PointMC.AttachRange(pointMCList);
        }

        #endregion

        #region delete

        public async Task Delete(PointMixedConfiguration pointMC)
        {
            _eFCoreDBDataContextMixedConfiguration.PointMC.Remove(pointMC);
        }

        public async Task DeleteRange(List<PointMixedConfiguration> pointMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.PointMC.RemoveRange(pointMCList);
        }

        #endregion

        #region update

        public async Task Update(PointMixedConfiguration pointMC)
        {
            _eFCoreDBDataContextMixedConfiguration.PointMC.Update(pointMC);
        }

        public async Task UpdateRange(List<PointMixedConfiguration> pointMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.PointMC.UpdateRange(pointMCList);
        }

        #endregion

    }
}
