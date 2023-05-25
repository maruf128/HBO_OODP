// maak er een public class van zodat codegrade er makkelijk bij kan
public class Program
{
    // maak eerst de functie's
    public class Square
    {
        public int Side { get; set; }
        // in de verschillende functie's maak je de berekeningen
        public Square(int side)
        {
            Side = side;
        }

        public int Area()
        {
            return Side * Side;
        }

        public int Perimeter()
        {
            return Side * 4;
        }
    }
    public static void Main()
    {
        // nu maak je de eerste side
        Square square1 = new Square(5);
        // nu print je het zoals codegrade wilt
        Console.WriteLine($"Side: {square1.Side}");
        Console.WriteLine($"Area: {square1.Area()}");
        Console.WriteLine($"Perimeter: {square1.Perimeter()}");

        // nu maak je de de 2de slide
        Square square2 = new Square(10);
        // nu print je het zoals codegrade wilt
        Console.WriteLine($"Side: {square2.Side}");
        Console.WriteLine($"Area: {square2.Area()}");
        Console.WriteLine($"Perimeter: {square2.Perimeter()}");

    }

}