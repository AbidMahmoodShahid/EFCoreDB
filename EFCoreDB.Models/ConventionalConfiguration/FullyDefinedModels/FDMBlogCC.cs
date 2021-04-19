using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels
{
    public class FDMBlogCC
    {
        [Key]
        public int FDMBlogCCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Post_CC

        //Collection Navigation Property(OneToMany)
        public List<FDMPostCC> PostList { get; set; }

        #endregion

        #region Process_CC

        // Foriegn Key Property
        public int FDMProcessCCForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        [ForeignKey("FDMProcessCCForeignKey")]
        public FDMProcessCC FDMProcessCC { get; set; }

        #endregion

        #region Blog_CC

        //Reference Navigation Property(OneToOne)
        public FDMBloggerCC FDMBloggerCC { get; set; }

        #endregion

        #region Constructors

        public FDMBlogCC(string blogname)
        {
            Name = blogname;
            PostList = new List<FDMPostCC>()
            {
                new FDMPostCC("FDMPostCC 1" + FDMBlogCCPrimaryKey),
                new FDMPostCC("FDMPostCC 2" + FDMBlogCCPrimaryKey),
                new FDMPostCC("FDMPostCC 3" + FDMBlogCCPrimaryKey),
                new FDMPostCC("FDMPostCC 4" + FDMBlogCCPrimaryKey),
                new FDMPostCC("FDMPostCC 5" + FDMBlogCCPrimaryKey),
                new FDMPostCC("FDMPostCC 6" + FDMBlogCCPrimaryKey),
                new FDMPostCC("FDMPostCC 7" + FDMBlogCCPrimaryKey),
                new FDMPostCC("FDMPostCC 8" + FDMBlogCCPrimaryKey)
            };
        }

        public FDMBlogCC()
        {
            PostList = new List<FDMPostCC>();
        }

        #endregion
    }
}
