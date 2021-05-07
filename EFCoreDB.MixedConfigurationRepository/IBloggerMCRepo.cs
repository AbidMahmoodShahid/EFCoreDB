using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface IBloggerMCRepo
    {
        Task<List<BloggerMixedConfiguration>> GetAll();

        Task Attach(BloggerMixedConfiguration bloggerMC);

        Task AttachRange(List<BloggerMixedConfiguration> bloggerMCList);

        Task Update(BloggerMixedConfiguration bloggerMC);

        Task UpdateRange(List<BloggerMixedConfiguration> bloggerMCList);

        Task Delete(BloggerMixedConfiguration bloggerMC);
    }
}
