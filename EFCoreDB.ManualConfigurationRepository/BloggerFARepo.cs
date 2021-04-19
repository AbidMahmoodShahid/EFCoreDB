using EFCoreDB.ManualConfigurationDataStorage;
using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public class BloggerFARepo : IBloggerFARepo
    {
        private EFCoreDBDataContextFA _eFCoreDBDataContextFA;

        public BloggerFARepo(EFCoreDBDataContextFA eFCoreDBDataContextFA)
        {
            _eFCoreDBDataContextFA = eFCoreDBDataContextFA;
        }

        public async Task Attach(BloggerFA bloggerFA)
        {
            _eFCoreDBDataContextFA.BloggerFA.Attach(bloggerFA);
        }

        public async Task AttachRange(List<BloggerFA> bloggerFAList)
        {
            _eFCoreDBDataContextFA.BloggerFA.AttachRange(bloggerFAList);
        }

        public async Task Delete(BloggerFA bloggerFA)
        {
            _eFCoreDBDataContextFA.BloggerFA.Remove(bloggerFA);
        }

        public async Task<List<BloggerFA>> GetAll()
        {
            return _eFCoreDBDataContextFA.BloggerFA.ToList();
        }

        public async Task Update(BloggerFA bloggerFA)
        {
            _eFCoreDBDataContextFA.BloggerFA.Update(bloggerFA);
        }

        public async Task UpdateRange(List<BloggerFA> bloggerFAList)
        {
            _eFCoreDBDataContextFA.BloggerFA.UpdateRange(bloggerFAList);
        }
    }
}
