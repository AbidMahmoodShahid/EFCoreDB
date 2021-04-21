using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class TagFA
    {
        public int TagFAPrimaryId { get; set; }

        public string Name { get; set; }


        #region Post_FA

        //Collection Navigation Property(ManyToMany)
        public List<PostFA> PostList { get; set; }

        #endregion


        #region Constructors

        public TagFA(string tagName)
        {
            Name = tagName;
            PostList = new List<PostFA>();
        }

        public TagFA()
        {
            PostList = new List<PostFA>();
        }

        #endregion
    }
}
