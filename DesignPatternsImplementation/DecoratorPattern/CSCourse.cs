namespace DesignPatternsImplementation.DecoratorPattern;

public class CSCourse : Course
{
    public CSCourse(string description) : base(description)
    {
    }

    public override decimal Cost() => 456799.980m;

}