using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMBloggerCCRepo
    {
        Task<List<FDMBloggerCC>> GetAll();

        Task Attach(FDMBloggerCC fDMBloggerCC);

        Task AttachRange(List<FDMBloggerCC> fDMBloggerCCList);

        Task Update(FDMBloggerCC fDMBloggerCC);

        Task UpdateRange(List<FDMBloggerCC> fDMBloggerCCList);

        Task Delete(FDMBloggerCC fDMBloggerCC);
    }
}
