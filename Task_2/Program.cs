using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();

            Console.WriteLine("Enter the number of points (3 to 5):");
            if (int.TryParse(Console.ReadLine(), out int numPoints) && numPoints >= 3 && numPoints <= 5)
            {
                for (int i = 1; i <= numPoints; i++)
                {
                    Console.WriteLine($"Enter coordinates for point {i}:");
                    double x, y;
                    if (TryGetCoordinate("X", out x) && TryGetCoordinate("Y", out y))
                    {
                        points.Add(new Point(x, y, $"Point {i}"));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter valid coordinates.");
                        i--;
                    }
                }

                Figure figure = new Figure(points.ToArray());
                figure.CalculatePerimeter();

                Console.WriteLine($"Type of figure: {figure.FigureType}");
                Console.WriteLine($"Perimeter of the figure: {figure.Perimeter}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 3 and 5.");
            }

            Console.ReadLine();
        }

        static bool TryGetCoordinate(string label, out double coordinate)
        {
            Console.Write($"{label}: ");
            return double.TryParse(Console.ReadLine(), out coordinate);
        }
    }
}