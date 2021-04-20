using EFCoreDB.DataStorage;
using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public class FDMProcessCCRepo : IFDMProcessCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMProcessCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        #region GetProcess

        public async Task<List<FDMProcessCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMProcessCC.Include(process => process.GroupList).ToList();
        }

        public async Task<FDMProcessCC> GetUsingPrimaryKey(int primaryKey)
        {
            return _eFCoreDBDataContext.FDMProcessCC.Where(process => process.FDMProcessCCPrimaryKey == primaryKey).Include(process => process.GroupList).FirstOrDefault();
        }

        public async Task<List<FDMProcessCC>> GetUsingName(string name)
        {
            return _eFCoreDBDataContext.FDMProcessCC.Where(process => process.Name == name).Include(process => process.GroupList).ToList();
        }

        #endregion

        #region add

        public async Task Attach(FDMProcessCC fDMProcessCC)
        {
            _eFCoreDBDataContext.FDMProcessCC.Attach(fDMProcessCC);
        }

        public async Task AttachRange(List<FDMProcessCC> fDMProcessCCList)
        {
            _eFCoreDBDataContext.FDMProcessCC.AttachRange(fDMProcessCCList);
        }

        #endregion

        #region delete

        public async Task Delete(FDMProcessCC fDMProcessCC)
        {
            _eFCoreDBDataContext.FDMProcessCC.Remove(fDMProcessCC);
        }

        public async Task DeleteRange(List<FDMProcessCC> fDMProcessCCList)
        {
            _eFCoreDBDataContext.FDMProcessCC.RemoveRange(fDMProcessCCList);
        }

        public async Task DeleteAll()
        {
            List<FDMProcessCC> processFAList = _eFCoreDBDataContext.FDMProcessCC.Include(process => process.GroupList).ToList();
            _eFCoreDBDataContext.FDMProcessCC.RemoveRange(processFAList);
        }

        #endregion

        #region update

        public async Task Update(FDMProcessCC fDMProcessCC)
        {
            _eFCoreDBDataContext.FDMProcessCC.Update(fDMProcessCC);
        }

        public async Task UpdateRange(List<FDMProcessCC> fDMProcessCCList)
        {
            _eFCoreDBDataContext.FDMProcessCC.UpdateRange(fDMProcessCCList);
        }

        #endregion
    }
}
