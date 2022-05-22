using DesignPatternsImplementation.DecoratorPattern;
using Xunit;

namespace DesignPatternsTest;

public class DecoratorPatternTest
{
    [Fact]
    public void Calculate_Cost_For_CS_With_Music()
    {
        Course csCourse = new CSCourse("CS");
        csCourse = new Music(" with Music", csCourse);
        var actual = csCourse.Cost();
        var expected = 555367.650m;
        Assert.Equal(actual, expected);
    }
}