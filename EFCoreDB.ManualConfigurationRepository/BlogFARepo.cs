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
    public class BlogFARepo : IBlogFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public BlogFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        public async Task Attach(BlogFA blogFA)
        {
            _eFCoreDBDataContextFA.BlogFA.Attach(blogFA);
        }

        public async Task AttachRange(List<BlogFA> blogFAList)
        {
            _eFCoreDBDataContextFA.BlogFA.AttachRange(blogFAList);
        }

        public async Task Delete(BlogFA blogFA)
        {
            _eFCoreDBDataContextFA.BlogFA.Remove(blogFA);
        }

        public async Task<List<BlogFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.BlogFA.Include(blog => blog.PostList).ToList();
        }

        public async Task Update(BlogFA blogFA)
        {
            _eFCoreDBDataContextFA.BlogFA.Update(blogFA);
        }

        public async Task UpdateRange(List<BlogFA> blogFAList)
        {
            _eFCoreDBDataContextFA.BlogFA.UpdateRange(blogFAList);
        }
    }
}
