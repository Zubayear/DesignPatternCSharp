namespace DesignPatternsImplementation.ObserverPattern;

public class Logger : IObserver
{
    private readonly IWeatherStation _weatherStation;
    private WeatherInfo WeatherInfo { get; set; }

    public Logger(IWeatherStation weatherStation)
    {
        _weatherStation = weatherStation ?? throw new ArgumentNullException(nameof(weatherStation));
        weatherStation.RegisterObserver(this);
    }

    public void Update(WeatherInfo weatherInfo) => WeatherInfo = weatherInfo;

    public string Log() => WeatherInfo.ToString();
}