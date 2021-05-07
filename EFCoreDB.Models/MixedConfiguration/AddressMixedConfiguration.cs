using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.MixedConfiguration
{
    public class AddressMixedConfiguration
    {
        public int AddressMCPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blogger_MixedConfiguration

        //Foriegn Key Property
        public int BloggerMCForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        public BloggerMixedConfiguration BloggerMC { get; set; }

        #endregion


        #region Constructors

        public AddressMixedConfiguration(string addressName)
        {
            Name = addressName;
        }

        public AddressMixedConfiguration()
        { }

        #endregion
    }
}
