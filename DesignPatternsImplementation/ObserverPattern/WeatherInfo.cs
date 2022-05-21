namespace DesignPatternsImplementation.ObserverPattern;

public class WeatherInfo
{
    public decimal Temperature { get; set; }
    public decimal WindSpeed { get; set; }
    public decimal Pressure { get; set; }

    public override string ToString()
    {
        return $"{nameof(Temperature)}: {Temperature}, {nameof(WindSpeed)}: {WindSpeed}, {nameof(Pressure)}: {Pressure}";
    }
}