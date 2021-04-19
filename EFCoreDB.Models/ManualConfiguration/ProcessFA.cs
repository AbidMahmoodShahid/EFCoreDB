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
            GroupList = new List<GroupFA>()
            {
                new GroupFA("GroupFA 1" + ProcessFAPrimaryKey),
                new GroupFA("GroupFA 2" + ProcessFAPrimaryKey),
                new GroupFA("GroupFA 3" + ProcessFAPrimaryKey),
                new GroupFA("GroupFA 4" + ProcessFAPrimaryKey),
                new GroupFA("GroupFA 5" + ProcessFAPrimaryKey),
                new GroupFA("GroupFA 6" + ProcessFAPrimaryKey),
                new GroupFA("GroupFA 7" + ProcessFAPrimaryKey),
                new GroupFA("GroupFA 8" + ProcessFAPrimaryKey)
            };
        }

        public ProcessFA()
        {
            GroupList = new List<GroupFA>();
        }

        #endregion
    }
}
