using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class PointMixedConfiguration
    {
        public int PointMCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Group_MixedConfiguration

        // Foriegn Key Property
        public int GroupMCForeignKey { get; set; }

        //// Reference Navigation Property(OneToMany)
        //public GroupMixedConfiguration GroupMC { get; set; }

        #endregion


        #region Constructors

        public PointMixedConfiguration(string name)
        {
            Name = name;
        }

        public PointMixedConfiguration() { }

        #endregion
    }
}
