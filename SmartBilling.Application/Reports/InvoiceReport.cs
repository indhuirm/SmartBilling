using System;

using SmartBilling.Core.Contracts;
using SmartBilling.Core.Reports;

namespace SmartBilling.Application.Reports;

public class InvoiceReport : ReportGenerator, IExportable
{
    public override void GenerateReport()
    {
        Console.WriteLine("Report Generated");
    }
    public void Export(string format)
    {
        Console.WriteLine($"Report Exported in {format}");
    }
}
