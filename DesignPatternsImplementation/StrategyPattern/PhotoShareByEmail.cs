namespace DesignPatternsImplementation.StrategyPattern;

public class PhotoShareByEmail : IPhotoShare
{
    public string Share() => "Share the photo by email";
}