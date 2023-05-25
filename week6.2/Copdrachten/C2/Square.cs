public class Square : Shape
{
    public double Lenght;
    public Square(double getl)
    {
        Lenght = getl;
    }
    public override double Area { get { return Lenght * Lenght; } }
    public override double Perimeter { get { return 4 * Lenght; } }

    public override string Info()
    {
        return $"Square with sides of {Lenght}";
    }
}