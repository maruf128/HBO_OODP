class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        // breken de omtrek? of opervlakte
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program
{
    static void Main()
    {
        // vraag voor de radius
        Console.WriteLine("Give the circle radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        // maak nietuwe circle aan
        var circle = new Circle(radius);
        double area = circle.Area();
        double roundedArea = Math.Round(area);
        // schrijf het uit
        Console.WriteLine("Rounded circle area: " + roundedArea);
    }
}
