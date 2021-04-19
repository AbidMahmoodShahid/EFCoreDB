using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ConventionalConfigurationRepository.FullyDefinedModels
{
    public interface IFDMBlogCCRepo
    {
        Task<List<FDMBlogCC>> GetAll();

        Task Attach(FDMBlogCC fDMBlogCC);

        Task AttachRange(List<FDMBlogCC> fDMBlogCCList);

        Task Update(FDMBlogCC fDMBlogCC);

        Task UpdateRange(List<FDMBlogCC> fDMBlogCCList);

        Task Delete(FDMBlogCC fDMBlogCC);
    }
}
