using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class PostFA
    {
        public int PostFAPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blog_FA

        // Foriegn Key Property
        public int BlogFAForeignKey { get; set; }

        //// Reference Navigation Property(OneToMany)
        //public BlogFA BlogFA { get; set; }

        #endregion

        #region Tag_FA

        //Collection Navigation Property(ManyToMany)
        public List<TagFA> TagList { get; set; }

        #endregion

        #region Constructors

        public PostFA(string postName)
        {
            Name = postName;
            TagList = new List<TagFA>();

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public PostFA()
        {
            TagList = new List<TagFA>();
        }

        #endregion

        #region private 

        private void CreateMockData()
        {
            TagFA TagFA1 = new TagFA("TagFA 1");
            TagFA TagFA2 = new TagFA("TagFA 2");
            TagFA TagFA3 = new TagFA("TagFA 3");
            TagFA TagFA4 = new TagFA("TagFA 4");
            TagFA TagFA5 = new TagFA("TagFA 5");

            TagList = new List<TagFA>()
            {
                TagFA1,
                TagFA2,
                TagFA3,
                TagFA4,
                TagFA5,
                TagFA1,
                TagFA2,
                TagFA3,
                TagFA4,
                TagFA5
            };
        }

        #endregion
    }
}
