using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.MixedConfigurationRepository
{
    public interface ITagMCRepo
    {
        Task<List<TagMixedConfiguration>> GetAll();

        Task Attach(TagMixedConfiguration tagMC);

        Task AttachRange(List<TagMixedConfiguration> tagMCList);

        Task Update(TagMixedConfiguration tagMC);

        Task UpdateRange(List<TagMixedConfiguration> tagMCList);

        Task Delete(TagMixedConfiguration tagMC);
    }
}
