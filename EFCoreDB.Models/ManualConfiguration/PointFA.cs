using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class PointFA
    {
        public int PointFAPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Group_FA

        // Foriegn Key Property
        public int GroupFAForeignKey { get; set; }

        //// Reference Navigation Property(OneToMany)
        //public GroupFA GroupFA { get; set; }

        #endregion


        #region Constructors

        public PointFA(string name)
        {
            Name = name;
        }

        public PointFA() { }

        #endregion
    }
}
