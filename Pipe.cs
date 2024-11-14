using System;

namespace SebsFabrik;

public class Pipe
{
    public double Diameter { get; set; }
    public double Length { get; set; }

    public Pipe(double diameter, double length)
    {
        Diameter = diameter;
        Length = length;
    }
}
