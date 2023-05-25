public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // GetDistanceCalculator goes here
    static public Func<Point, Point, double> GetDistanceCalculator(double getal1)
    {
        return (point1, point2) =>
        {
            double totx = point2.X - point1.X;
            double toty = point2.Y - point1.Y;
            double afstand = Math.Sqrt(totx * totx + toty * toty);
            return afstand * getal1;
        };
    }
}