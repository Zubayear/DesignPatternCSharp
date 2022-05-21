namespace DesignPatternsImplementation.StrategyPattern;

public class PhotoShareByText : IPhotoShare
{
    public string Share() => "Share by texting";
}