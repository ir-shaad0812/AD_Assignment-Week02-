using System;

class Circle
{
    // Constant declaration
    public const double PI = 3.14;

    // Method to calculate the area of a circle
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    // Method to calculate the perimeter (circumference)
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}


class CircleDemo
{
    static void Main()
    {
        // Create an object of the Circle class
        Circle circle = new Circle();

        double radius = 5.0;

        // Display area and perimeter
        Console.WriteLine($"Area of circle: {circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter of circle: {circle.CalculatePerimeter(radius)}");

        // Display the constant PI
        Console.WriteLine($"The value of constant PI: {Circle.PI}");
    }
}
