using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMPostCC
    {
        [Key]
        public int FDMPostCCPrimaryId { get; set; }

        public string Name { get; set; }


        #region Blog_CC

        // Foriegn Key Property
        public int FDMBlogCCForeignKey { get; set; }

        // Reference Navigation Property(OneToMany)
        [ForeignKey("FDMBlogCCForeignKey")]
        public FDMBlogCC FDMBlogCC { get; set; }


        #endregion

        #region Tag_CC

        //Collection Navigation Property(ManyToMany)
        public List<FDMTagCC> TagList { get; set; }

        #endregion

        #region Constructors

        public FDMPostCC(string postName)
        {
            Name = postName;
            FDMTagCC FDMTagCC1 = new FDMTagCC("FDMTagCC 1" + FDMPostCCPrimaryId);
            FDMTagCC FDMTagCC2 = new FDMTagCC("FDMTagCC 2" + FDMPostCCPrimaryId);
            FDMTagCC FDMTagCC3 = new FDMTagCC("FDMTagCC 3" + FDMPostCCPrimaryId);
            FDMTagCC FDMTagCC4 = new FDMTagCC("FDMTagCC 4" + FDMPostCCPrimaryId);
            FDMTagCC FDMTagCC5 = new FDMTagCC("FDMTagCC 5" + FDMPostCCPrimaryId);

            TagList = new List<FDMTagCC>()
            {
                FDMTagCC1,
                FDMTagCC2,
                FDMTagCC3,
                FDMTagCC4,
                FDMTagCC5,
                FDMTagCC1,
                FDMTagCC2,
                FDMTagCC3,
                FDMTagCC4,
                FDMTagCC5
            };
        }

        public FDMPostCC()
        {
            TagList = new List<FDMTagCC>();
        }

        #endregion
    }
}
