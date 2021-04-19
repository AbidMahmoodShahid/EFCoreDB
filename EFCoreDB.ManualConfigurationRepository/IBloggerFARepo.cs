using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface IBloggerFARepo
    {
        Task<List<BloggerFA>> GetAll();

        Task Attach(BloggerFA bloggerFA);

        Task AttachRange(List<BloggerFA> bloggerFAList);

        Task Update(BloggerFA bloggerFA);

        Task UpdateRange(List<BloggerFA> bloggerFAList);

        Task Delete(BloggerFA bloggerFA);
    }
}
