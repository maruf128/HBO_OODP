public class Program
{
    static void Main()
    {
        Console.WriteLine("Give two numbers:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        PrintResult((x, y) => x + y, number1, number2);
        PrintResult((x, y) => x - y, number1, number2);
        PrintResult((x, y) => x * y, number1, number2);
        PrintResult((x, y) => (int)Math.Pow(x, y), number1, number2);
    }

    // PrintResult goes here
    static public void PrintResult(Func<int, int, int> berkening, int getal1, int getal2)
    {
        int resultaat = berkening(getal1, getal2);
        Console.WriteLine($"The result is: {resultaat}");
    }
}