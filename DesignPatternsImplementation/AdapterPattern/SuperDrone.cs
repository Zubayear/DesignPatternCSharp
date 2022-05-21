namespace DesignPatternsImplementation.AdapterPattern;

public class SuperDrone : IDrone
{
    public string Beep() => "Super Drone beeping";

    public string SpinRotors() => "Super Drone rotors are Spinning";

    public string TakeOff() => "Super Drone taking off";
}