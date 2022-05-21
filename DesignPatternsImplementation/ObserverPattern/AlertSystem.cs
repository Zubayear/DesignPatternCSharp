namespace DesignPatternsImplementation.ObserverPattern;

public class AlertSystem : IObserver
{
    private readonly IWeatherStation _weatherStation;
    private WeatherInfo WeatherInfo { get; set; }

    public AlertSystem(IWeatherStation weatherStation)
    {
        _weatherStation = weatherStation ?? throw new ArgumentNullException(nameof(weatherStation));
        _weatherStation.RegisterObserver(this);
    }
    public void Update(WeatherInfo weatherInfo) => WeatherInfo = weatherInfo;

    public string Alert() => WeatherInfo.ToString();
}