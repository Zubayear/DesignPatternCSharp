namespace DesignPatternsImplementation.StrategyPattern;

public class BasicCameraApp : PhoneCameraApp
{
    public BasicCameraApp(IPhotoShare photoShare) : base(photoShare)
    {
    }

    public override string Edit() => "Editing with basic camera app";
}