using System;

public class Sphere : IShape3D
{
    private double radius;

    public Sphere(double radius)
    {
        this.radius = radius;
    }

    public double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}
