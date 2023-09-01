using System;

public class RightCircularCone : IShape3D
{
    private double radius;
    private double height;

    public RightCircularCone(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public double CalculateVolume()
    {
        return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
    }
}
