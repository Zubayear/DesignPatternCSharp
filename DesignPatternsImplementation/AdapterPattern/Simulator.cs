namespace DesignPatternsImplementation.AdapterPattern;

public class Simulator
{
    public string TestDuck(IDuck duck) => duck.Fly();
}