using ISP;

class Program
{
    static void Main(string[] args)
    {


        IPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        multiFunctionPrinter.Print();
        ((IScanner)multiFunctionPrinter).Scan();
    }
}