using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class BlogFA
    {
        public int BlogFAPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Post_FA

        //Collection Navigation Property(OneToMany)
        public List<PostFA> PostList { get; set; }

        #endregion

        #region Process_FA

        // Foriegn Key Property
        public int ProcessFAForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        public ProcessFA ProcessFA { get; set; }

        #endregion

        #region Blog_FA

        //Reference Navigation Property(OneToOne)
        public BloggerFA BloggerFA { get; set; }

        #endregion

        #region Constructors

        public BlogFA(string blogname)
        {
            Name = blogname;
            PostList = new List<PostFA>()
            {
                new PostFA("PostFA 1" + BlogFAPrimaryKey),
                new PostFA("PostFA 2" + BlogFAPrimaryKey),
                new PostFA("PostFA 3" + BlogFAPrimaryKey),
                new PostFA("PostFA 4" + BlogFAPrimaryKey),
                new PostFA("PostFA 5" + BlogFAPrimaryKey),
                new PostFA("PostFA 6" + BlogFAPrimaryKey),
                new PostFA("PostFA 7" + BlogFAPrimaryKey),
                new PostFA("PostFA 8" + BlogFAPrimaryKey)
            };
        }

        public BlogFA()
        {
            PostList = new List<PostFA>();
        }

        #endregion
    }
}
