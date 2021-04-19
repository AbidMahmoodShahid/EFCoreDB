using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class AddressFA
    {
        public int AddressFAPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blogger_CC

        //Foriegn Key Property
        public int BloggerFAForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        public BloggerFA BloggerFA { get; set; }

        #endregion


        #region Constructors

        public AddressFA(string addressName)
        {
            Name = addressName;
        }

        public AddressFA()
        { }

        #endregion
    }
}
