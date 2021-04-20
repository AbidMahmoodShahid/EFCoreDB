using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDB.Models
{
    public static class TestMode
    {
        public static bool IsTestMode { get; set; }

        public static bool CreateMockData { get; set; }
    }
}
