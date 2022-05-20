namespace DesignPatternsImplementation.StrategyPattern
{
    public class PhotoShareByText : IPhotoShare
    {
        public void Share() => System.Console.WriteLine("Share by texting");
    }
}