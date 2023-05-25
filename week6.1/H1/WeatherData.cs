public class WeatherData : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();
    public double Temperature { get; private set; } // private voor de set
    public double Humidity { get; private set; }
    public double Pressure { get; private set; }

    public void RegisterObserver(IObserver observer)
    {
        // voeg de observer toe aan de lijst
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        // verwijder het van de lijst
        _observers.Remove(observer);
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        // sett het en roep de measerment changed aan
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }

    public void MeasurementsChanged()
    {
        // roep de nitify observers aan
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            // voor iedere observer roep de update aan
            observer.Update();
        }
    }
}
