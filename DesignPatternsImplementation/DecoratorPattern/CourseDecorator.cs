namespace DesignPatternsImplementation.DecoratorPattern;

public abstract class CourseDecorator : Course
{
    protected CourseDecorator(string description) : base(description)
    {
    }
}