namespace DesignPatternsImplementation.StrategyPattern
{
    public class PhotoShareByEmail : IPhotoShare
    {
        public void Share() => System.Console.WriteLine("Share the photo by email");
    }
}