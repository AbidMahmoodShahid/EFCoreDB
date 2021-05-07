using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class BloggerMixedConfiguration
    {
        public int BloggerMCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blog_MixedConfiguration

        //Foriegn Key Property
        public int BlogMCForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        public BlogMixedConfiguration BlogMC { get; set; }

        #endregion

        #region Address_MixedConfiguration

        //Reference Navigation Property(OneToOne)
        public AddressMixedConfiguration AddressMC { get; set; }

        #endregion


        #region Constructors

        public BloggerMixedConfiguration(string bloggerName)
        {
            Name = bloggerName;

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public BloggerMixedConfiguration()
        { }

        #endregion

        #region private

        private void CreateMockData()
        {
            AddressMC = new AddressMixedConfiguration("AddressMixedConfiguration 1");
        }

        #endregion
    }
}
