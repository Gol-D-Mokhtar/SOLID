public class Cube : IShape3D
{
    private double side;

    public Cube(double side)
    {
        this.side = side;
    }

    public double CalculateVolume()
    {
        return side * side * side;
    }
}
