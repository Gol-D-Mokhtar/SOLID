public class Trapezium : IShape2D
{
    private double topLength;
    private double bottomLength;
    private double height;

    public Trapezium(double topLength, double bottomLength, double height)
    {
        this.topLength = topLength;
        this.bottomLength = bottomLength;
        this.height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * (topLength + bottomLength) * height;
    }
}
