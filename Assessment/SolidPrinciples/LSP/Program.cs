using LSP;

class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle { Width = 5, Height = 10 };
        Shape triangle = new Triangle { Base = 5, Height = 10 };

        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
    }
}