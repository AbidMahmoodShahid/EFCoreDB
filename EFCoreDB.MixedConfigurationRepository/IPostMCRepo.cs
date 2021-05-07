using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface IPostMCRepo
    {
        Task<List<PostMixedConfiguration>> GetAll();

        Task Attach(PostMixedConfiguration postMC);

        Task AttachRange(List<PostMixedConfiguration> postMCList);

        Task Update(PostMixedConfiguration postMC);

        Task UpdateRange(List<PostMixedConfiguration> postMCList);

        Task Delete(PostMixedConfiguration postMC);
    }
}
