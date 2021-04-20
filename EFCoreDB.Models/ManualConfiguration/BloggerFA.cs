using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models.ManualConfiguration
{
    public class BloggerFA
    {
        public int BloggerFAPrimaryKey { get; set; }

        public string Name { get; set; }


        #region Blog_FA

        //Foriegn Key Property
        public int BlogFAForeignKey { get; set; }

        //Reference Navigation Property(OneToOne)
        public BlogFA BlogFA { get; set; }

        #endregion

        #region Address_FA

        //Reference Navigation Property(OneToOne)
        public AddressFA AddressFA { get; set; }

        #endregion


        #region Constructors

        public BloggerFA(string bloggerName)
        {
            Name = bloggerName;

            if(TestMode.CreateMockData)
                CreateMockData();
        }

        public BloggerFA()
        { }

        #endregion

        #region private

        private void CreateMockData()
        {
            AddressFA = new AddressFA("AddressFA 1");
        }

        #endregion
    }
}
