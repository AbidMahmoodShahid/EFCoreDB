using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class BlogMixedConfiguration
    {
        public int BlogMCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Post_MixedConfiguration

        //Collection Navigation Property(OneToMany)
        public List<PostMixedConfiguration> PostList { get; set; }

        #endregion

        #region Process_MixedConfiguration

        // Foriegn Key Property
        public int? ProcessMCForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        public ProcessMixedConfiguration ProcessMC { get; set; }

        #endregion

        #region Blog_MixedConfiguration

        //Reference Navigation Property(OneToOne)
        public BloggerMixedConfiguration BloggerMC { get; set; }

        #endregion

        #region Constructors

        public BlogMixedConfiguration(string blogname)
        {
            Name = blogname;
            PostList = new List<PostMixedConfiguration>();

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public BlogMixedConfiguration()
        {
            PostList = new List<PostMixedConfiguration>();
        }

        #endregion

        #region private

        private void CreateMockData()
        {
            PostList = new List<PostMixedConfiguration>()
            {
                new PostMixedConfiguration("PostMixedConfiguration 1"),
                new PostMixedConfiguration("PostMixedConfiguration 2"),
                new PostMixedConfiguration("PostMixedConfiguration 3"),
                new PostMixedConfiguration("PostMixedConfiguration 4"),
                new PostMixedConfiguration("PostMixedConfiguration 5"),
                new PostMixedConfiguration("PostMixedConfiguration 6"),
                new PostMixedConfiguration("PostMixedConfiguration 7"),
                new PostMixedConfiguration("PostMixedConfiguration 8")
            };
        }
        #endregion
    }
}
