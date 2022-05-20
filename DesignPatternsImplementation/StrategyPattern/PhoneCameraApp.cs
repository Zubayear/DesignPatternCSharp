namespace DesignPatternsImplementation.StrategyPattern
{
    public abstract class PhoneCameraApp
    {
        private readonly IPhotoShare _photoShare;

        protected PhoneCameraApp(IPhotoShare photoShare) => this._photoShare = photoShare ?? throw new ArgumentNullException(nameof(photoShare));
        
        public abstract void Edit();

        public void Take() => System.Console.WriteLine("Taking Photo");

        public void Save() => System.Console.WriteLine("Saving the photo");

        public void SharePhoto() => _photoShare.Share();
    }
}