using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMPointCC
    {
        [Key]
        public int FDMPointCCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Group_CC

        // Foriegn Key Property
        public int FDMGroupCCForeignKey { get; set; }

        // Reference Navigation Property(OneToMany)
        [ForeignKey("FDMGroupCCForeignKey")]
        public FDMGroupCC FDMGroupCC { get; set; }

        #endregion


        #region Constructors

        public FDMPointCC(string name)
        {
            Name = name;
        }

        public FDMPointCC() { }

        #endregion
    }
}
