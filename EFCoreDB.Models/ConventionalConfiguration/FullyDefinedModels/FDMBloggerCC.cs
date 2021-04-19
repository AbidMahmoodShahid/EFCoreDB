using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMBloggerCC
    {
        [Key]
        public int FDMBloggerCCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blog_CC

        //Foriegn Key Property
        public int FDMBlogCCForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        [ForeignKey("FDMBlogCCForeignKey")]
        public FDMBlogCC FDMBlogCC { get; set; }

        #endregion

        #region Address_CC

        //Reference Navigation Property(OneToOne)
        public FDMAddressCC FDMAddressCC { get; set; }

        #endregion


        #region Constructors

        public FDMBloggerCC(string bloggerName)
        {
            Name = bloggerName;
            FDMAddressCC = new FDMAddressCC("FDMAddressCC " + FDMBloggerCCPrimaryKey);
        }

        public FDMBloggerCC()
        { }

        #endregion
    }
}
