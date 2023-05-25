class Point
{
    public double X;
    public double Y;

    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point(Point other)
    {
        X = other.X;
        Y = other.Y;
    }
    public static double EuclideanDistance(Point p, Point q)
    {
        // hier maak je de q en p punten aan via een nieuwe class. ook zorg je ervoor dat je wortel en kwadraat gebruikt via sqrt en pow
        double afstand = Math.Sqrt(Math.Pow(q.X - p.X, 2) + Math.Pow(q.Y - p.Y, 2));
        // return de afstand
        return afstand;
    }
}
