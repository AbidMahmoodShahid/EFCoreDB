using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class GroupMixedConfiguration
    {
        public int GroupMCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Process_MixedConfiguration

        // Foriegn Key Property
        public int ProcessMCForeignKey { get; set; }

        //// Reference Navigation Property(OneToMany)
        //public ProcessMixedConfiguration ProcessMC { get; set; }

        #endregion

        #region Point_MixedConfiguration

        //Collection Navigation Property(OneToMany)
        public List<PointMixedConfiguration> PointList { get; set; }

        #endregion

        #region Constructors

        public GroupMixedConfiguration(string groupName)
        {
            Name = groupName;
            PointList = new List<PointMixedConfiguration>();

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public GroupMixedConfiguration()
        {
            PointList = new List<PointMixedConfiguration>();
        }

        #endregion

        #region private

        private void CreateMockData()
        {
            PointList = new List<PointMixedConfiguration>()
            {
                new PointMixedConfiguration("PointMixedConfiguration 1"),
                new PointMixedConfiguration("PointMixedConfiguration 2"),
                new PointMixedConfiguration("PointMixedConfiguration 3"),
                new PointMixedConfiguration("PointMixedConfiguration 4"),
                new PointMixedConfiguration("PointMixedConfiguration 5"),
                new PointMixedConfiguration("PointMixedConfiguration 6"),
                new PointMixedConfiguration("PointMixedConfiguration 7"),
                new PointMixedConfiguration("PointMixedConfiguration 8")
            };
        }

        #endregion
    }
}
