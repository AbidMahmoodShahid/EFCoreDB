using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class TagMixedConfiguration
    {
        public int TagMCPrimaryId { get; set; }

        public string Name { get; set; }


        #region Post_MixedConfiguration

        //Collection Navigation Property(ManyToMany)
        public List<PostMixedConfiguration> PostList { get; set; }

        #endregion


        #region Constructors

        public TagMixedConfiguration(string tagName)
        {
            Name = tagName;
            PostList = new List<PostMixedConfiguration>();
        }

        public TagMixedConfiguration()
        {
            PostList = new List<PostMixedConfiguration>();
        }

        #endregion
    }
}
