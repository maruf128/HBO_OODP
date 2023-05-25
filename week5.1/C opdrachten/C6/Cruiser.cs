public class Cruiser : Motorcycle
{
    // extra field
    public int SeatHeight;

    public Cruiser(string make, string model, int year, int stoelhoogte) : base(make, model, year)
    {
        SeatHeight = stoelhoogte;
    }
    public override string Ride()
    {
        // pak de basis ervan
        string nieuwe_text = base.Ride() + $" with a seat height of {SeatHeight} cm";
        return nieuwe_text;
    }
}