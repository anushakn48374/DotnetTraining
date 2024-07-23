using OpenClosedPrinciple;

class Program
{
    static void Main(string[] args)
    {
        
        Report pdfReport = new PDFReport();
        Report excelReport = new ExcelReport();

        pdfReport.Generate();
        excelReport.Generate();
    }
}