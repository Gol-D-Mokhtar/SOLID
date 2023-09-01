using System;

public class RightCircularCylinder : IShape3D
{
    private double radius;
    private double height;

    public RightCircularCylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public double CalculateVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }
}
