namespace DesignPatternsImplementation.AdapterPattern;

public class MallardDuck : IDuck
{
    public string Fly() => "Mallard Duck flying";

    public string Quack() => "Mallard Duck quacking";
}