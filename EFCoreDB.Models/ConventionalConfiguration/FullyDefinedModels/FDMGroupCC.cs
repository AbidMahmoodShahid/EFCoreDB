using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMGroupCC
    {
        [Key]
        public int FDMGroupCCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Process_CC

        // Foriegn Key Property
        public int FDMProcessCCForeignKey { get; set; }

        // Reference Navigation Property(OneToMany)
        [ForeignKey("FDMProcessCCForeignKey")]
        public FDMProcessCC FDMProcessCC { get; set; }

        #endregion

        #region Point_CC

        //Collection Navigation Property(OneToMany)
        public List<FDMPointCC> PointList { get; set; }

        #endregion

        #region Constructors

        public FDMGroupCC(string groupName)
        {
            Name = groupName;
            PointList = new List<FDMPointCC>()
            {
                new FDMPointCC("FDMPointCC 1" + FDMGroupCCPrimaryKey),
                new FDMPointCC("FDMPointCC 2" + FDMGroupCCPrimaryKey),
                new FDMPointCC("FDMPointCC 3" + FDMGroupCCPrimaryKey),
                new FDMPointCC("FDMPointCC 4" + FDMGroupCCPrimaryKey),
                new FDMPointCC("FDMPointCC 5" + FDMGroupCCPrimaryKey),
                new FDMPointCC("FDMPointCC 6" + FDMGroupCCPrimaryKey),
                new FDMPointCC("FDMPointCC 7" + FDMGroupCCPrimaryKey),
                new FDMPointCC("FDMPointCC 8" + FDMGroupCCPrimaryKey)
            };
        }

        public FDMGroupCC()
        {
            PointList = new List<FDMPointCC>();
        }

        #endregion
    }
}
