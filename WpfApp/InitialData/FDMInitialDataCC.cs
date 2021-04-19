using EFCoreDB.Models.ConventionalConfiguration.FullyDefinedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.InitialData
{
    public class FDMInitialDataCC
    {
        public List<FDMProcessCC> FDMProcessCCList { get; private set; }

        public FDMInitialDataCC()
        {
            FDMProcessCCList = new List<FDMProcessCC>();
            CreateInitialData();
        }

        private void CreateInitialData()
        {
            FDMProcessCC fDMProcessCC1 = new FDMProcessCC("Process 1");
            fDMProcessCC1.FDMBlogCC = new FDMBlogCC("Blog 1");
            fDMProcessCC1.FDMBlogCC.FDMBloggerCC = new FDMBloggerCC("Blogger 1");
            FDMProcessCC fDMProcessCC2 = new FDMProcessCC("Process 2");
            fDMProcessCC2.FDMBlogCC = new FDMBlogCC("Blog 2");
            fDMProcessCC2.FDMBlogCC.FDMBloggerCC = new FDMBloggerCC("Blogger 2");
            FDMProcessCC fDMProcessCC3 = new FDMProcessCC("Process 3");
            fDMProcessCC3.FDMBlogCC = new FDMBlogCC("Blog 3");
            fDMProcessCC3.FDMBlogCC.FDMBloggerCC = new FDMBloggerCC("Blogger 3");

            FDMProcessCCList.Add(fDMProcessCC1);
            FDMProcessCCList.Add(fDMProcessCC2);
            FDMProcessCCList.Add(fDMProcessCC3);
        }

    }
}
