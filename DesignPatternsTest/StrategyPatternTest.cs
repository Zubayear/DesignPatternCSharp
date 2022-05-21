using DesignPatternsImplementation.StrategyPattern;
using Xunit;

namespace DesignPatternsTest;

public class StrategyPatternTest
{
    private readonly IPhotoShare _photoShare;
        
    public StrategyPatternTest()
    {
        _photoShare = new PhotoShareBySocialMedia();
    }
        
    [Fact]
    public void Use_Photo_Share_By_Social_Media()
    {
        var cameraPlusApp = new CameraPlusApp(_photoShare);
        var actual = cameraPlusApp.SharePhoto();
        const string expected = "Share photo by social media";
        Assert.Equal(actual, expected);
    }
}