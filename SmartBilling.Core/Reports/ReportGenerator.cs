using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBilling.Core.Reports
{
    public abstract class ReportGenerator
    {
        public abstract void GenerateReport();
        public void Log(string message)
        {
            Console.WriteLine($"lOG :{message}");
        }

    }
}
