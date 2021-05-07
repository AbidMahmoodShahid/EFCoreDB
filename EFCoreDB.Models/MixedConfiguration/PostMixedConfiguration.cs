using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class PostMixedConfiguration
    {
        public int PostMCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blog_MixedConfiguration

        // Foriegn Key Property
        public int BlogMCForeignKey { get; set; }

        //// Reference Navigation Property(OneToMany)
        //public BlogMixedConfiguration BlogMC { get; set; }

        #endregion

        #region Tag_MixedConfiguration

        //Collection Navigation Property(ManyToMany)
        public List<TagMixedConfiguration> TagList { get; set; }

        #endregion

        #region Constructors

        public PostMixedConfiguration(string postName)
        {
            Name = postName;
            TagList = new List<TagMixedConfiguration>();

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public PostMixedConfiguration()
        {
            TagList = new List<TagMixedConfiguration>();
        }

        #endregion

        #region private 

        private void CreateMockData()
        {
            TagMixedConfiguration TagMC1 = new TagMixedConfiguration("TagMixedConfiguration 1");
            TagMixedConfiguration TagMC2 = new TagMixedConfiguration("TagMixedConfiguration 2");
            TagMixedConfiguration TagMC3 = new TagMixedConfiguration("TagMixedConfiguration 3");
            TagMixedConfiguration TagMC4 = new TagMixedConfiguration("TagMixedConfiguration 4");
            TagMixedConfiguration TagMC5 = new TagMixedConfiguration("TagMixedConfiguration 5");

            TagList = new List<TagMixedConfiguration>()
            {
                TagMC1,
                TagMC2,
                TagMC3,
                TagMC4,
                TagMC5,
                TagMC1,
                TagMC2,
                TagMC3,
                TagMC4,
                TagMC5
            };
        }

        #endregion
    }
}
