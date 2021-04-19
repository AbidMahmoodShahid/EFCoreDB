using EFCoreDB.ManualConfigurationDataStorage;
using EFCoreDB.Models.ManualConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public class TagFARepo : ITagFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public TagFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        public async Task Attach(TagFA tagFA)
        {
            _eFCoreDBDataContextFA.TagFA.Attach(tagFA);
        }

        public async Task AttachRange(List<TagFA> tagFAList)
        {
            _eFCoreDBDataContextFA.TagFA.AttachRange(tagFAList);
        }

        public async Task Delete(TagFA tagFA)
        {
            _eFCoreDBDataContextFA.TagFA.Remove(tagFA);
        }

        public async Task<List<TagFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.TagFA.Include(tag => tag.PostList).ToList();
        }

        public async Task Update(TagFA tagFA)
        {
            _eFCoreDBDataContextFA.TagFA.Update(tagFA);
        }

        public async Task UpdateRange(List<TagFA> tagFAList)
        {
            _eFCoreDBDataContextFA.TagFA.UpdateRange(tagFAList);
        }
    }
}
