public class Temperature
{
    private double _celsius;

    // property celcius
    public double Celsius
    {
        get { return _celsius; }
        set
        {
            if (value >= -273.15)
            {
                _celsius = value;
            }
        }
    }

    public double Kelvin
    {
        get { return _celsius + 273.15; }
        set { Celsius = value - 273.15; }
    }
}