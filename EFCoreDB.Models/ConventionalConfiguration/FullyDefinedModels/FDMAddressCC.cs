using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMAddressCC
    {
        [Key]
        public int FDMAddressCCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blogger_CC

        //Foriegn Key Property
        public int FDMBloggerCCForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        [ForeignKey("FDMBloggerCCForeignKey")]
        public FDMBloggerCC FDMBloggerCC { get; set; }

        #endregion


        #region Constructors

        public FDMAddressCC(string addressName)
        {
            Name = addressName;
        }

        public FDMAddressCC()
        { }

        #endregion
    }
}
