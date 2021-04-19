using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMTagCC
    {
        [Key]
        public int FDMTagCCPrimaryId { get; set; }

        public string Name { get; set; }


        #region Post_CC

        //Collection Navigation Property(ManyToMany)
        public List<FDMPostCC> PostList { get; set; }

        #endregion


        #region Constructors

        public FDMTagCC(string tagName)
        {
            Name = tagName;
        }

        public FDMTagCC()
        { }

        #endregion
    }
}
