namespace DesignPatternsImplementation.ObserverPattern;

public interface IWeatherStation
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObserver();
}