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
    public void Sort(bool volgorde)
    {
        if (volgorde == true)
        {
            Array.Sort(_data);
        }
        else
        {
            Array.Sort(_data);
            // eerst sorteren daarna pas reversen
            Array.Reverse(_data);
        }
    }
    public double[] GetTemperaturesSorted(bool volgorde)
    {
        double[] gesorteerd = new double[NumberOfReadings];
        Array.Copy(_data, gesorteerd, NumberOfReadings);
        if (volgorde == true)
        {
            Array.Sort(gesorteerd);
        }
        else
        {
            Array.Sort(gesorteerd);
            // eerst sorteren daarna pas reversen
            Array.Reverse(gesorteerd);
        }
        return gesorteerd;
    }
    public void PrintTemperatures()
    {
        foreach (var x in _data)
        {
            Console.WriteLine(x);
        }
    }
}