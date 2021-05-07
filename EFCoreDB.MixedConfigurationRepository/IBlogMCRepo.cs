using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface IBlogMCRepo
    {
        Task<List<BlogMixedConfiguration>> GetAll();

        Task Attach(BlogMixedConfiguration blogMC);

        Task AttachRange(List<BlogMixedConfiguration> blogMCList);

        Task Update(BlogMixedConfiguration blogMC);

        Task UpdateRange(List<BlogMixedConfiguration> blogMCList);

        Task Delete(BlogMixedConfiguration blogMC);
    }
}
