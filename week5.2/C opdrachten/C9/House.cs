public class House
{
    private double _squareMeters;
    private int _numberOfRooms;
    private bool _isFurnished;
    private bool _hasGarden;

    public House(double squareMeters, int numberOfRooms)
        : this(squareMeters, numberOfRooms, false, false)
    {
    }

    public House(double squareMeters, int numberOfRooms, bool isFurnished, bool hasGarden)
    {
        _squareMeters = squareMeters;
        _numberOfRooms = numberOfRooms;
        _isFurnished = isFurnished;
        _hasGarden = hasGarden;
    }

    public double SquareMeters
    {
        get { return _squareMeters; }
        private set { _squareMeters = value; }
    }

    public int NumberOfRooms
    {
        get { return _numberOfRooms; }
        protected set { _numberOfRooms = value; }
    }

    public bool IsFurnished
    {
        get { return _isFurnished; }
        private set { _isFurnished = value; }
    }

    public bool HasGarden
    {
        get { return _hasGarden; }
        private set { _hasGarden = value; }
    }

    public double Price
    {
        get
        {
            double basePrice = _squareMeters * 1000;
            double roomPrice = _numberOfRooms * 50000;
            double furnishedPrice = _isFurnished ? 10000 : 0;
            double gardenPrice = _hasGarden ? 25000 : 0;
            return basePrice + roomPrice + furnishedPrice + gardenPrice;
        }
    }

    public string Info
    {
        get
        {
            return $"Square meters: {_squareMeters}\n" +
            $"Rooms: {_numberOfRooms}\n" +
            $"Furnished: {(_isFurnished ? "yes" : "no")}\n" +
            $"Garden: {(_hasGarden ? "yes" : "no")}";
        }
    }

    public virtual void HomeImprovement()
    {
        _squareMeters += 10;
        _isFurnished = true;
        _hasGarden = true;
    }
}
