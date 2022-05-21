namespace DesignPatternsImplementation.AdapterPattern;

public class DroneAdapter : IDuck
{
    // Adapter composed with Adaptee
    private readonly IDrone _drone;

    public DroneAdapter(IDrone drone) => _drone = drone ?? throw new ArgumentNullException(nameof(drone));
    
    public string Fly() => $"{_drone.SpinRotors()}...\n{_drone.TakeOff()}";

    public string Quack() => _drone.Beep();
}