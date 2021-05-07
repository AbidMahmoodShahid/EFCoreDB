using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class ProcessMixedConfiguration
    {
        public int ProcessMCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Group_MixedConfiguration

        //Collection Navigation Property(OneToMany)
        public List<GroupMixedConfiguration> GroupList { get; set; }

        #endregion

        #region Blog_MixedConfiguration

        //Reference Navigation Property(OneToOne)
        public BlogMixedConfiguration BlogMC { get; set; }

        #endregion

        #region Constructors

        public ProcessMixedConfiguration(string processname)
        {
            Name = processname;
            GroupList = new List<GroupMixedConfiguration>();

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public ProcessMixedConfiguration()
        {
            GroupList = new List<GroupMixedConfiguration>();
        }

        #endregion

        #region private

        private void CreateMockData()
        {
            GroupList = new List<GroupMixedConfiguration>()
            {
                new GroupMixedConfiguration("GroupMixedConfiguration 1"),
                new GroupMixedConfiguration("GroupMixedConfiguration 2"),
                new GroupMixedConfiguration("GroupMixedConfiguration 3"),
                new GroupMixedConfiguration("GroupMixedConfiguration 4"),
                new GroupMixedConfiguration("GroupMixedConfiguration 5"),
                new GroupMixedConfiguration("GroupMixedConfiguration 6"),
                new GroupMixedConfiguration("GroupMixedConfiguration 7"),
                new GroupMixedConfiguration("GroupMixedConfiguration 8")
            };
        }

        #endregion
    }
}
