using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMProcessCC
    {
        [Key]
        public int FDMProcessCCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Group_CC

        //Collection Navigation Property(OneToMany)
        public List<FDMGroupCC> GroupList { get; set; }

        #endregion

        #region Blog_CC

        //Reference Navigation Property(OneToOne)
        public FDMBlogCC FDMBlogCC { get; set; }

        #endregion

        #region Constructors

        public FDMProcessCC(string processname)
        {
            Name = processname;
            GroupList = new List<FDMGroupCC>()
            {
                new FDMGroupCC("FDMGroupCC 1" + FDMProcessCCPrimaryKey),
                new FDMGroupCC("FDMGroupCC 2" + FDMProcessCCPrimaryKey),
                new FDMGroupCC("FDMGroupCC 3" + FDMProcessCCPrimaryKey),
                new FDMGroupCC("FDMGroupCC 4" + FDMProcessCCPrimaryKey),
                new FDMGroupCC("FDMGroupCC 5" + FDMProcessCCPrimaryKey),
                new FDMGroupCC("FDMGroupCC 6" + FDMProcessCCPrimaryKey),
                new FDMGroupCC("FDMGroupCC 7" + FDMProcessCCPrimaryKey),
                new FDMGroupCC("FDMGroupCC 8" + FDMProcessCCPrimaryKey)
            };
        }

        public FDMProcessCC()
        {
            GroupList = new List<FDMGroupCC>();
        }

        #endregion
    }
}
