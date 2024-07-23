using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public abstract class Report
    {
        public abstract string Generate();
    }

    // Concrete implementations of Report
    public class PDFReport : Report
    {
        public override string Generate()
        {
            return "PDF Report generated.";
        }
    }

    public class ExcelReport : Report
    {
        public override string Generate()
        {
            return "Excel Report generated.";
        }
    }
}
