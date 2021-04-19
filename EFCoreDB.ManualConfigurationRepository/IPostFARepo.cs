using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.ManualConfigurationRepository
{
    public interface IPostFARepo
    {
        Task<List<PostFA>> GetAll();

        Task Attach(PostFA postFA);

        Task AttachRange(List<PostFA> postFAList);

        Task Update(PostFA postFA);

        Task UpdateRange(List<PostFA> postFAList);

        Task Delete(PostFA postFA);
    }
}
