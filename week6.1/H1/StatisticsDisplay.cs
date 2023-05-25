public class StatisticsDisplay : IObserver, IDisplay
{
    private IObservable _observable;
    private double _minTemperature;
    private double _maxTemperature;
    private double _averageTemperature;
    private double _totalTemperature = 0; // zodat je de update goed bijhoud
    private int _aantalTemps = 0; // zodat je de update goed bijhoud 
    List<double> alle_temps = new List<double>();
    public StatisticsDisplay(IObservable observable)
    {
        _observable = observable;
        _observable.RegisterObserver(this);
    }
    public void Update()
    {
        if (_observable is WeatherData weatherData)
        {
            double temperature = weatherData.Temperature;
            _totalTemperature += temperature;
            _aantalTemps++;

            if (temperature < _minTemperature)
            {
                _minTemperature = temperature;
            }
            else if (_aantalTemps == 1) // indien het de eerste keer is
            {
                _minTemperature = temperature;
            }

            if (temperature > _maxTemperature)
            {
                _maxTemperature = temperature;
            }

            _averageTemperature = _totalTemperature / _aantalTemps; // Update the average temperature
            alle_temps.Add(temperature);

        }
    }


    public void Display()
    {
        // benodigd van interface
        Console.WriteLine($"Avg/Min/Max temperature = {(_averageTemperature):F2}/{_minTemperature}/{_maxTemperature}");
        Console.WriteLine("------------------alle temps voor de gemiddelde----------------");
        foreach (double element in alle_temps)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine($"aantal temps: {_aantalTemps}");
    }
}