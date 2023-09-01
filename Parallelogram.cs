public class Parallelogram : IShape2D
{
    private double baseLength;
    private double height;

    public Parallelogram(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double CalculateArea()
    {
        return baseLength * height;
    }
}
