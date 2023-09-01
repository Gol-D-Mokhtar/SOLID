using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which type of shape do you want to calculate?");
        Console.WriteLine("1. 2D Shape");
        Console.WriteLine("2. 3D Shape");

        var shapeTypeChoice = int.Parse(Console.ReadLine());

        switch (shapeTypeChoice)
        {
            case 1:
                Console.WriteLine("Which 2D shape do you want to calculate the area for?");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Trapezium");
                Console.WriteLine("5. Parallelogram");
                Console.WriteLine("6. Rhombus");
                Console.WriteLine("7. Kite");

                var shape2DChoice = int.Parse(Console.ReadLine());

                switch (shape2DChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the side length of the square:");
                        double squareSide = double.Parse(Console.ReadLine());
                        Square square = new Square(squareSide);
                        AreaCalculator squareAreaCalculator = new AreaCalculator();
                        double squareArea = squareAreaCalculator.CalculateArea(square);
                        Console.WriteLine($"The area of the square is: {squareArea}");
                        break;

                    case 2:
                        Console.WriteLine("Enter the length of the rectangle:");
                        double rectangleLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width of the rectangle:");
                        double rectangleWidth = double.Parse(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(rectangleLength, rectangleWidth);
                        AreaCalculator rectangleAreaCalculator = new AreaCalculator();
                        double rectangleArea = rectangleAreaCalculator.CalculateArea(rectangle);
                        Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
                        break;

                    case 3:
                        Console.WriteLine("Enter the base length of the triangle:");
                        double triangleBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the triangle:");
                        double triangleHeight = double.Parse(Console.ReadLine());
                        Triangle triangle = new Triangle(triangleBase, triangleHeight);
                        AreaCalculator triangleAreaCalculator = new AreaCalculator();
                        double triangleArea = triangleAreaCalculator.CalculateArea(triangle);
                        Console.WriteLine($"The area of the triangle is: {triangleArea}");
                        break;

                    case 4:
                        Console.WriteLine("Enter the top length of the trapezium:");
                        double trapeziumTop = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the bottom length of the trapezium:");
                        double trapeziumBottom = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the trapezium:");
                        double trapeziumHeight = double.Parse(Console.ReadLine());
                        Trapezium trapezium = new Trapezium(trapeziumTop, trapeziumBottom, trapeziumHeight);
                        AreaCalculator trapeziumAreaCalculator = new AreaCalculator();
                        double trapeziumArea = trapeziumAreaCalculator.CalculateArea(trapezium);
                        Console.WriteLine($"The area of the trapezium is: {trapeziumArea}");
                        break;

                    case 5:
                        Console.WriteLine("Enter the base length of the parallelogram:");
                        double parallelogramBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the parallelogram:");
                        double parallelogramHeight = double.Parse(Console.ReadLine());
                        Parallelogram parallelogram = new Parallelogram(parallelogramBase, parallelogramHeight);
                        AreaCalculator parallelogramAreaCalculator = new AreaCalculator();
                        double parallelogramArea = parallelogramAreaCalculator.CalculateArea(parallelogram);
                        Console.WriteLine($"The area of the parallelogram is: {parallelogramArea}");
                        break;

                    case 6:
                        Console.WriteLine("Enter the first diagonal length of the rhombus:");
                        double rhombusDiagonal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second diagonal length of the rhombus:");
                        double rhombusDiagonal2 = double.Parse(Console.ReadLine());
                        Rhombus rhombus = new Rhombus(rhombusDiagonal1, rhombusDiagonal2);
                        AreaCalculator rhombusAreaCalculator = new AreaCalculator();
                        double rhombusArea = rhombusAreaCalculator.CalculateArea(rhombus);
                        Console.WriteLine($"The area of the rhombus is: {rhombusArea}");
                        break;

                    case 7:
                        Console.WriteLine("Enter the first diagonal length of the kite:");
                        double kiteDiagonal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second diagonal length of the kite:");
                        double kiteDiagonal2 = double.Parse(Console.ReadLine());
                        Kite kite = new Kite(kiteDiagonal1, kiteDiagonal2);
                        AreaCalculator kiteAreaCalculator = new AreaCalculator();
                        double kiteArea = kiteAreaCalculator.CalculateArea(kite);
                        Console.WriteLine($"The area of the kite is: {kiteArea}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                break;

            case 2:
                Console.WriteLine("Which 3D shape do you want to calculate the volume for?");
                Console.WriteLine("1. Cube");
                Console.WriteLine("2. Rectangular Prism");
                Console.WriteLine("3. Sphere");
                Console.WriteLine("4. Right Circular Cylinder");
                Console.WriteLine("5. Right Circular Cone");
                Console.WriteLine("6. Right Square Pyramid");

                var shape3DChoice = int.Parse(Console.ReadLine());

                switch (shape3DChoice)
                {

                    case 1:
                        Console.WriteLine("Enter the side length:");
                        double cubeSide = double.Parse(Console.ReadLine());
                        Cube cube = new Cube(cubeSide);
                        double cubeVolume = cube.CalculateVolume();
                        Console.WriteLine($"The volume of the cube is {cubeVolume}");
                        break;

                    case 2:
                        Console.WriteLine("Enter the length:");
                        double rectPrismLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width:");
                        double rectPrismWidth = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height:");
                        double rectPrismHeight = double.Parse(Console.ReadLine());
                        RectangularPrism rectPrism = new RectangularPrism(rectPrismLength, rectPrismWidth, rectPrismHeight);
                        double rectPrismVolume = rectPrism.CalculateVolume();
                        Console.WriteLine($"The volume of the rectangular prism is {rectPrismVolume}");
                        break;

                    case 3:
                        Console.WriteLine("Enter the radius:");
                        double sphereRadius = double.Parse(Console.ReadLine());
                        Sphere sphere = new Sphere(sphereRadius);
                        double sphereVolume = sphere.CalculateVolume();
                        Console.WriteLine($"The volume of the sphere is {sphereVolume}");
                        break;

                    case 4:
                        Console.WriteLine("Enter the radius:");
                        double cylinderRadius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height:");
                        double cylinderHeight = double.Parse(Console.ReadLine());
                        RightCircularCylinder cylinder = new RightCircularCylinder(cylinderRadius, cylinderHeight);
                        double cylinderVolume = cylinder.CalculateVolume();
                        Console.WriteLine($"The volume of the right circular cylinder is {cylinderVolume}");
                        break;

                    case 5:
                        Console.WriteLine("Enter the radius:");
                        double coneRadius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height:");
                        double coneHeight = double.Parse(Console.ReadLine());
                        RightCircularCone cone = new RightCircularCone(coneRadius, coneHeight);
                        double coneVolume = cone.CalculateVolume();
                        Console.WriteLine($"The volume of the right circular cone is {coneVolume}");
                        break;

                    case 6:
                        Console.WriteLine("Enter the base length:");
                        double pyramidBaseLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height:");
                        double pyramidHeight = double.Parse(Console.ReadLine());
                        RightSquarePyramid pyramid = new RightSquarePyramid(pyramidBaseLength, pyramidHeight);
                        double pyramidVolume = pyramid.CalculateVolume();
                        Console.WriteLine($"The volume of the right square pyramid is {pyramidVolume}");
                        break;

                    default:
                        Console.WriteLine("Invalid shape entered.");
                        break;
                }
                break;
        }
    }
}