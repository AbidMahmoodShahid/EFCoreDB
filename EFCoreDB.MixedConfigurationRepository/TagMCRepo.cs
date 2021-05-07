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
    public class TagMCRepo : ITagMCRepo
    {
        private EFCoreDBDataContextMixedConfiguration _eFCoreDBDataContextMixedConfiguration;

        public TagMCRepo(EFCoreDBDataContextMixedConfiguration eFCoreDBDataContextMixedConfiguration)
        {
            _eFCoreDBDataContextMixedConfiguration = eFCoreDBDataContextMixedConfiguration;
        }

        public async Task Attach(TagMixedConfiguration tagMC)
        {
            _eFCoreDBDataContextMixedConfiguration.TagMC.Attach(tagMC);
        }

        public async Task AttachRange(List<TagMixedConfiguration> tagMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.TagMC.AttachRange(tagMCList);
        }

        public async Task Delete(TagMixedConfiguration tagMC)
        {
            _eFCoreDBDataContextMixedConfiguration.TagMC.Remove(tagMC);
        }

        public async Task<List<TagMixedConfiguration>> GetAll()
        {
            return _eFCoreDBDataContextMixedConfiguration.TagMC.Include(tag => tag.PostList).ToList();
        }

        public async Task Update(TagMixedConfiguration tagMC)
        {
            _eFCoreDBDataContextMixedConfiguration.TagMC.Update(tagMC);
        }

        public async Task UpdateRange(List<TagMixedConfiguration> tagMCList)
        {
            _eFCoreDBDataContextMixedConfiguration.TagMC.UpdateRange(tagMCList);
        }
    }
}
