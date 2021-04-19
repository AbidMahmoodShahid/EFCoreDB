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
    public class FDMBlogCCRepo : IFDMBlogCCRepo
    {
        private EFCoreDBDataContext _eFCoreDBDataContext;

        public FDMBlogCCRepo(EFCoreDBDataContext eFCoreDBDataContext)
        {
            _eFCoreDBDataContext = eFCoreDBDataContext;
        }

        public async Task Attach(FDMBlogCC fDMBlogCC)
        {
            _eFCoreDBDataContext.FDMBlogCC.Attach(fDMBlogCC);
        }

        public async Task AttachRange(List<FDMBlogCC> fDMBlogCCList)
        {
            _eFCoreDBDataContext.FDMBlogCC.AttachRange(fDMBlogCCList);
        }

        public async Task Delete(FDMBlogCC fDMBlogCC)
        {
            _eFCoreDBDataContext.FDMBlogCC.Remove(fDMBlogCC);
        }

        public async Task<List<FDMBlogCC>> GetAll()
        {
            return _eFCoreDBDataContext.FDMBlogCC.Include(blog => blog.PostList).ToList();
        }

        public async Task Update(FDMBlogCC fDMBlogCC)
        {
            _eFCoreDBDataContext.FDMBlogCC.Update(fDMBlogCC);
        }

        public async Task UpdateRange(List<FDMBlogCC> fDMBlogCCList)
        {
            _eFCoreDBDataContext.FDMBlogCC.UpdateRange(fDMBlogCCList);
        }
    }
}
