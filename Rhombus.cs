﻿public class Rhombus : IShape2D
{
    private double diagonal1;
    private double diagonal2;

    public Rhombus(double diagonal1, double diagonal2)
    {
        this.diagonal1 = diagonal1;
        this.diagonal2 = diagonal2;
    }

    public double CalculateArea()
    {
        return 0.5 * diagonal1 * diagonal2;
    }
}
