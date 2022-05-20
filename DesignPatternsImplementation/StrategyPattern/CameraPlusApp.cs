namespace DesignPatternsImplementation.StrategyPattern
{
    public class CameraPlusApp : PhoneCameraApp
    {
        public CameraPlusApp(IPhotoShare photoShare) : base(photoShare)
        {
        }

        public override void Edit() => System.Console.WriteLine("Editing with camera plus app");
    }
}