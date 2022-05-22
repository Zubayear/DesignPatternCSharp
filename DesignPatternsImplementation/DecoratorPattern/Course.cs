namespace DesignPatternsImplementation.DecoratorPattern;

public abstract class Course
{
    private readonly string _description;
    protected Course(string description) => _description = description ?? throw new ArgumentNullException(nameof(description));
    public abstract decimal Cost();
}