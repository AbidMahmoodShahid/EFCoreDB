using EFCoreDB.Models.ManualConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.InitialData
{
    public class InitialDataFA
    {
        public List<ProcessFA> ProcessFAList { get; private set; }

        public InitialDataFA()
        {
            ProcessFAList = new List<ProcessFA>();
            CreateInitialData();
        }

        private void CreateInitialData()
        {
            ProcessFA processFA1 = new ProcessFA("Process 1");
            processFA1.BlogFA = new BlogFA("Blog 1");
            processFA1.BlogFA.BloggerFA = new BloggerFA("Blogger 1");
            ProcessFA ProcessFA2 = new ProcessFA("Process 2");
            ProcessFA2.BlogFA = new BlogFA("Blog 2");
            ProcessFA2.BlogFA.BloggerFA = new BloggerFA("Blogger 2");
            ProcessFA ProcessFA3 = new ProcessFA("Process 3");
            ProcessFA3.BlogFA = new BlogFA("Blog 3");
            ProcessFA3.BlogFA.BloggerFA = new BloggerFA("Blogger 3");

            ProcessFAList.Add(processFA1);
            ProcessFAList.Add(ProcessFA2);
            ProcessFAList.Add(ProcessFA3);
        }

    }
}
