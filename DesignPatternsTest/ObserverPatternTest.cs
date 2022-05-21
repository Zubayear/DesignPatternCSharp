using System;
using DesignPatternsImplementation.ObserverPattern;
using Xunit;

namespace DesignPatternsTest;

public class ObserverPatternTest
{
    [Fact]
    public void Should_Return_Updated_WeatherInfo()
    {
        var weatherStation = new WeatherStation();
        var observer = new AlertSystem(weatherStation);
        const decimal pressure = 45.67m;
        const decimal temperature = 34.56m;
        const decimal windSpeed = 14.78m;
        weatherStation.WeatherInfo = new WeatherInfo()
        {
            Pressure = pressure,
            Temperature = temperature,
            WindSpeed = windSpeed
        };
        var actual = observer.Alert();
        var expected = $"Temperature: {temperature}, WindSpeed: {windSpeed}, Pressure: {pressure}";
        Assert.Equal(actual, expected);
    }
}