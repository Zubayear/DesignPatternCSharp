namespace DesignPatternsImplementation.StrategyPattern;

public abstract class PhoneCameraApp
{
    private readonly IPhotoShare _photoShare;

    protected PhoneCameraApp(IPhotoShare photoShare) => this._photoShare = photoShare ?? throw new ArgumentNullException(nameof(photoShare));
        
    public abstract string Edit();

    public string Take() => "Taking Photo";

    public string Save() => "Saving the photo";

    public string SharePhoto() => _photoShare.Share();
}