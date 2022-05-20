namespace DesignPatternsImplementation.StrategyPattern
{
    public class BasicCameraApp : PhoneCameraApp
    {
        public BasicCameraApp(IPhotoShare photoShare) : base(photoShare)
        {
        }

        public override void Edit() => System.Console.WriteLine("Editing with basic camera app");
    }
}