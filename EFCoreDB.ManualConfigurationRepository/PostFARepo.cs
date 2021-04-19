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
    public class PostFARepo : IPostFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public PostFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        public async Task Attach(PostFA postFA)
        {
            _eFCoreDBDataContextFA.PostFA.Attach(postFA);
        }

        public async Task AttachRange(List<PostFA> postFAList)
        {
            _eFCoreDBDataContextFA.PostFA.AttachRange(postFAList);
        }

        public async Task Delete(PostFA postFA)
        {
            _eFCoreDBDataContextFA.PostFA.Remove(postFA);
        }

        public async Task<List<PostFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.PostFA.Include(post => post.TagList).ToList();
        }

        public async Task Update(PostFA postFA)
        {
            _eFCoreDBDataContextFA.PostFA.Update(postFA);
        }

        public async Task UpdateRange(List<PostFA> postFAList)
        {
            _eFCoreDBDataContextFA.PostFA.UpdateRange(postFAList);
        }
    }
}
