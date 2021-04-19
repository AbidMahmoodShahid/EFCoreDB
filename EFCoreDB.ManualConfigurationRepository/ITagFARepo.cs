using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface ITagFARepo
    {
        Task<List<TagFA>> GetAll();

        Task Attach(TagFA tagFA);

        Task AttachRange(List<TagFA> tagFAList);

        Task Update(TagFA tagFA);

        Task UpdateRange(List<TagFA> tagFAList);

        Task Delete(TagFA tagFA);
    }
}
