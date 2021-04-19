using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class GroupFA
    {
        public int GroupFAPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Process_FA

        // Foriegn Key Property
        public int ProcessFAForeignKey { get; set; }

        //// Reference Navigation Property(OneToMany)
        //public ProcessFA ProcessFA { get; set; }

        #endregion

        #region Point_FA

        //Collection Navigation Property(OneToMany)
        public List<PointFA> PointList { get; set; }

        #endregion

        #region Constructors

        public GroupFA(string groupName)
        {
            Name = groupName;
            PointList = new List<PointFA>()
            {
                new PointFA("PointFA 1" + GroupFAPrimaryKey),
                new PointFA("PointFA 2" + GroupFAPrimaryKey),
                new PointFA("PointFA 3" + GroupFAPrimaryKey),
                new PointFA("PointFA 4" + GroupFAPrimaryKey),
                new PointFA("PointFA 5" + GroupFAPrimaryKey),
                new PointFA("PointFA 6" + GroupFAPrimaryKey),
                new PointFA("PointFA 7" + GroupFAPrimaryKey),
                new PointFA("PointFA 8" + GroupFAPrimaryKey)
            };
        }

        public GroupFA()
        {
            PointList = new List<PointFA>();
        }

        #endregion
    }
}
