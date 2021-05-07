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
    public class PostMCRepo : IPostMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public PostMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        public async Task Attach(PostMixedConfiguration postMC)
        {
            _eFCoreDBDataContextMixedConfiguration.PostMC.Attach(postMC);
        }

        public async Task AttachRange(List<PostMixedConfiguration> postMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.PostMC.AttachRange(postMCList);
        }

        public async Task Delete(PostMixedConfiguration postMC)
        {
            _eFCoreDBDataContextMixedConfiguration.PostMC.Remove(postMC);
        }

        public async Task<List<PostMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.PostMC.Include(post => post.TagList).ToList();
        }

        public async Task Update(PostMixedConfiguration postMC)
        {
            _eFCoreDBDataContextMixedConfiguration.PostMC.Update(postMC);
        }

        public async Task UpdateRange(List<PostMixedConfiguration> postMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.PostMC.UpdateRange(postMCList);
        }
    }
}
