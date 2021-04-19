using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface IBlogFARepo
    {
        Task<List<BlogFA>> GetAll();

        Task Attach(BlogFA blogFA);

        Task AttachRange(List<BlogFA> blogFAList);

        Task Update(BlogFA blogFA);

        Task UpdateRange(List<BlogFA> blogFAList);

        Task Delete(BlogFA blogFA);
    }
}
