using System;

namespace task
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public string IsRightTriangle()
        {
            if (SideA * SideA + SideB * SideB == SideC * SideC || SideA * SideA + SideC * SideC == SideB * SideB || SideC * SideC + SideB * SideB == SideA * SideA)
            {
                return "Прямоугольный";
            }
            else if (SideA * SideA + SideB * SideB < SideC * SideC || SideA * SideA + SideC * SideC < SideB * SideB || SideC * SideC + SideB * SideB < SideA * SideA)
            {
                return "Тупоугольный";
            }
            else
            {
                return "Остроугольный";
            }
        }
    }
}
