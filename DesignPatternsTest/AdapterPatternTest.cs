using System;
using DesignPatternsImplementation.AdapterPattern;
using Xunit;

namespace DesignPatternsTest;

public class AdapterPatternTest
{
    // private readonly Simulator _simulator;

    // public AdapterPatternTest(Simulator simulator) => _simulator = simulator ?? throw new ArgumentNullException(nameof(simulator));

    [Fact]
    public void Should_Return_Spin_Rotors_And_TakeOff()
    {
        var simulator = new Simulator();
        IDrone drone = new SuperDrone();
        IDuck duck = new DroneAdapter(drone);
        var actual = simulator.TestDuck(duck);
        const string expected = "Super Drone rotors are Spinning...\nSuper Drone taking off";
        Assert.Equal(actual, expected);
    }
}