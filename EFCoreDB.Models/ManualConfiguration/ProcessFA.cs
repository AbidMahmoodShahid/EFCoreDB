using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class ProcessFA
    {
        public int ProcessFAPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Group_FA

        //Collection Navigation Property(OneToMany)
        public List<GroupFA> GroupList { get; set; }

        #endregion

        #region Blog_FA

        //Reference Navigation Property(OneToOne)
        public BlogFA BlogFA { get; set; }

        #endregion

        #region Constructors

        public ProcessFA(string processname)
        {
            Name = processname;
            GroupList = new List<GroupFA>();

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public ProcessFA()
        {
            GroupList = new List<GroupFA>();
        }

        #endregion

        #region private

        private void CreateMockData()
        {
            GroupList = new List<GroupFA>()
            {
                new GroupFA("GroupFA 1"),
                new GroupFA("GroupFA 2"),
                new GroupFA("GroupFA 3"),
                new GroupFA("GroupFA 4"),
                new GroupFA("GroupFA 5"),
                new GroupFA("GroupFA 6"),
                new GroupFA("GroupFA 7"),
                new GroupFA("GroupFA 8")
            };
        }

        #endregion
    }
}
