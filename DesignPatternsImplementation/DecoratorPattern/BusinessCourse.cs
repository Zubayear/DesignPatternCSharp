namespace DesignPatternsImplementation.DecoratorPattern;

public class BusinessCourse : Course
{
    protected BusinessCourse(string description) : base(description)
    {
    }
    
    public override decimal Cost() => 980.789m;
}