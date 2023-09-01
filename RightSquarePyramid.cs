using System;

public class RightSquarePyramid : IShape3D
{
    private double baseLength;
    private double height;

    public RightSquarePyramid(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double CalculateVolume()
    {
        return (1.0 / 3.0) * Math.Pow(baseLength, 2) * height;
    }
}
