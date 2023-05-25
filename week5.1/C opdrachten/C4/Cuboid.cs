class Cuboid : Rectangle
{
    public int Height;

    public Cuboid(int length, int width, int hoogte) : base(length, width)
    {
        Height = hoogte;
    }
    public int Volume()
    {
        int inhoud = Length * Width * Height;
        return inhoud;
    }

    public override int Area()
    {
        int gebied = (2 * (Length * Width + Length * Height + Width * Height));
        return gebied;
    }

    public override int Perimeter()
    {
        int omtrek = (4 * (Length + Width + Height));
        return omtrek;
    }

    public override string Info()
    {
        base.Info();
        string new_info = $"Length: {Length}; Width: {Width}; Height: {Height}";
        return new_info;
    }
}