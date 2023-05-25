public class WeatherData
{
    //Change from List to array
    private readonly double[] _data;
    public WeatherData(double[] data) => _data = data;
    public int NumberOfReadings
    {
        get
        {
            return _data.Length;
        }
    }
    public double GetHighestTemperature()
    {
        return _data.Max();
    }
}