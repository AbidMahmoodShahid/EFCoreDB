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
    public class BloggerMCRepo : IBloggerMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public BloggerMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        public async Task Attach(BloggerMixedConfiguration bloggerMC)
        {
            _eFCoreDBDataContextMixedConfiguration.BloggerMC.Attach(bloggerMC);
        }

        public async Task AttachRange(List<BloggerMixedConfiguration> bloggerMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.BloggerMC.AttachRange(bloggerMCList);
        }

        public async Task Delete(BloggerMixedConfiguration bloggerMC)
        {
            _eFCoreDBDataContextMixedConfiguration.BloggerMC.Remove(bloggerMC);
        }

        public async Task<List<BloggerMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.BloggerMC.ToList();
        }

        public async Task Update(BloggerMixedConfiguration bloggerMC)
        {
            _eFCoreDBDataContextMixedConfiguration.BloggerMC.Update(bloggerMC);
        }

        public async Task UpdateRange(List<BloggerMixedConfiguration> bloggerMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.BloggerMC.UpdateRange(bloggerMCList);
        }
    }
}
