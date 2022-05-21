namespace DesignPatternsImplementation.ObserverPattern;

public class WeatherStation : IWeatherStation
{
    private readonly List<IObserver> _observers = new();
    private WeatherInfo _weatherInfo;

    public WeatherInfo WeatherInfo
    {
        get => _weatherInfo;
        set
        {
            _weatherInfo = value;
            NotifyObserver();
        }
    }

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);

    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

    public void NotifyObserver()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_weatherInfo);
        }
    }
}