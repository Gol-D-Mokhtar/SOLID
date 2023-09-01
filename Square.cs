public class Square : IShape2D
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }
}
