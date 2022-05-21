namespace DesignPatternsImplementation.ObserverPattern;

public class UserInterface : IObserver
{
    private readonly IWeatherStation _weatherStation;
    private WeatherInfo WeatherInfo { get; set; }

    public UserInterface(IWeatherStation weatherStation)
    {
        _weatherStation = weatherStation ?? throw new ArgumentNullException(nameof(weatherStation));
        _weatherStation.RegisterObserver(this);
    }
    public void Update(WeatherInfo weatherInfo) => WeatherInfo = weatherInfo;

    public string Display() => WeatherInfo.ToString();
}