namespace DesignPatternsImplementation.StrategyPattern;

public class CameraPlusApp : PhoneCameraApp
{
    public CameraPlusApp(IPhotoShare photoShare) : base(photoShare)
    {
    }

    public override string Edit() => "Editing with camera plus app";
}