public class Circle : Shape
{
    public double Radius;
    public Circle(double getl)
    {
        Radius = getl;
    }
    // pi om mee te rekenen
    double pi = Math.PI;
    public override double Area { get { return pi * Radius * Radius; } }
    public override double Perimeter { get { return (2 * pi) * Radius; } }
    public override string Info()
    {
        return $"Circle with a radius of {Radius}";
    }
}