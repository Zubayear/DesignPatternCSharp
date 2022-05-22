namespace DesignPatternsImplementation.DecoratorPattern;

public abstract class Art : Course
{
    private readonly Course _course;

    protected Art(string description, Course course) : base(description) =>
        _course = course ?? throw new ArgumentNullException(nameof(course));

    public override decimal Cost() => _course.Cost() + 7869.789m;
}