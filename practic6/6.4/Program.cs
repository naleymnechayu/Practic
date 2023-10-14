using System;

public class Program
{
    public static void Main()
    {
        task.Circle circle = new task.Circle() { Radius = 15 };
        task.Rectangle rectangle = new task.Rectangle() { Width = 15, Height = 10 };
        task.Triangle triangle = new task.Triangle() { SideA = 2, SideB = 3, SideC = 2 };

        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
        Console.WriteLine($"Периметр круга: {circle.CalculatePerimeter()}");

        Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
        Console.WriteLine($"Периметр прямоугольника: {rectangle.CalculatePerimeter()}");

        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        Console.WriteLine($"Периметр треугольника: {triangle.CalculatePerimeter()}");
        Console.WriteLine($"Треугольник является: {triangle.IsRightTriangle()}");

        Console.ReadLine();
    }
}