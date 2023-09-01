public class RectangularPrism : IShape3D
{
    private double length;
    private double width;
    private double height;

    public RectangularPrism(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double CalculateVolume()
    {
        return length * width * height;
    }
}
