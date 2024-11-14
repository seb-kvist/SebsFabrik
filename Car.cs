using System;

namespace SebsFabrik;

public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public string LicensePlate {get; set; }

    public Car(string model, string color, string licensePlate)
    {
        Model = model;
        Color = color;
        LicensePlate = licensePlate;
    }
}
