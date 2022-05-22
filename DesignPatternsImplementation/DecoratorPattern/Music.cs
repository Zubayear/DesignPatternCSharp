namespace DesignPatternsImplementation.DecoratorPattern;

public class Music : CourseDecorator
{
    private readonly Course _course;

    public Music(string description, Course course) : base(description) => _course = course ?? throw new ArgumentNullException(nameof(course));

    public override decimal Cost() => _course.Cost() + 98567.67m;
}