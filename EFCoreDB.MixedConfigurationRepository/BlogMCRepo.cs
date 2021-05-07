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
    public class BlogMCRepo : IBlogMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public BlogMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        public async Task Attach(BlogMixedConfiguration blogMC)
        {
            _eFCoreDBDataContextMixedConfiguration.BlogMC.Attach(blogMC);
        }

        public async Task AttachRange(List<BlogMixedConfiguration> blogMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.BlogMC.AttachRange(blogMCList);
        }

        public async Task Delete(BlogMixedConfiguration blogMC)
        {
            _eFCoreDBDataContextMixedConfiguration.BlogMC.Remove(blogMC);
        }

        public async Task<List<BlogMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.BlogMC.Include(blog => blog.PostList).ToList();
        }

        public async Task Update(BlogMixedConfiguration blogMC)
        {
            _eFCoreDBDataContextMixedConfiguration.BlogMC.Update(blogMC);
        }

        public async Task UpdateRange(List<BlogMixedConfiguration> blogMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.BlogMC.UpdateRange(blogMCList);
        }
    }
}
