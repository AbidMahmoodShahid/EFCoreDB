using EFCoreDB.Models.MixedConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.InitialData
{
    public class InitialDataMC
    {
        public List<ProcessMixedConfiguration> ProcessMCList { get; private set; }

        public InitialDataMC()
        {
            ProcessMCList = new List<ProcessMixedConfiguration>();
            CreateInitialData();
        }

        private void CreateInitialData()
        {
            ProcessMixedConfiguration processMC1 = new ProcessMixedConfiguration("ProcessMixedConfiguration 1");
            processMC1.BlogMC = new BlogMixedConfiguration("BlogMixedConfiguration 1");
            processMC1.BlogMC.BloggerMC = new BloggerMixedConfiguration("BloggerMixedConfiguration 1");
            ProcessMixedConfiguration ProcessMC2 = new ProcessMixedConfiguration("ProcessMixedConfiguration 2");
            ProcessMC2.BlogMC = new BlogMixedConfiguration("BlogMixedConfiguration 2");
            ProcessMC2.BlogMC.BloggerMC = new BloggerMixedConfiguration("BloggerMixedConfiguration 2");
            ProcessMixedConfiguration ProcessMC3 = new ProcessMixedConfiguration("ProcessMixedConfiguration 3");
            ProcessMC3.BlogMC = new BlogMixedConfiguration("BlogMixedConfiguration 3");
            ProcessMC3.BlogMC.BloggerMC = new BloggerMixedConfiguration("BloggerMixedConfiguration 3");

            ProcessMCList.Add(processMC1);
            ProcessMCList.Add(ProcessMC2);
            ProcessMCList.Add(ProcessMC3);
        }

    }
}
