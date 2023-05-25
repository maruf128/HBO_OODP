public class CurrentConditionsDisplay : IObserver, IDisplay
{
    private IObservable _observable;
    private double _temperature;
    private double _humidity;

    public CurrentConditionsDisplay(IObservable observable)
    {
        _observable = observable;
        _observable.RegisterObserver(this);
    }
    public void Update()
    {
        // benodigd van interface
        // zet de fields naar de observable temp en humi
        if (_observable is WeatherData weatherData) // doe het alleen als het een weatherdata type is anders heeft het geen temperature en humidity
        {
            _temperature = weatherData.Temperature;
            _humidity = weatherData.Humidity;
        }
    }

    public void Display()
    {
        // benodigd van interface
        Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity} humidity");
    }
}