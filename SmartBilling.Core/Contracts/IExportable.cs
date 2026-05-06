using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBilling.Core.Contracts
{
    public interface IExportable
    {
        void Export(string format);
    }
}
