namespace DesignPatternsImplementation.StrategyPattern
{
    public class PhotoShareBySocialMedia : IPhotoShare
    {
        public void Share() => System.Console.WriteLine("Share photo by social media");
    }
}