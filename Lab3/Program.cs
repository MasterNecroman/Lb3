using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateRectangle();
            Console.WriteLine("Exiting the program.");
        }

        static void CalculateRectangle()
        {
            Console.WriteLine("Enter the length of the first side of the rectangle:");
            double side1 = GetValidInput("Invalid input. Please enter a valid number for the first side:");

            Console.WriteLine("Enter the length of the second side of the rectangle:");
            double side2 = GetValidInput("Invalid input. Please enter a valid number for the second side:");

            Rectangle rectangle = new Rectangle(side1, side2);

            double area = rectangle.Area;
            double perimeter = rectangle.Perimeter;

            Console.WriteLine($"Area of the rectangle: {area}");
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");

            Console.WriteLine("Do you want to calculate another rectangle? (yes/no)");
            string continueStr = Console.ReadLine()?.ToLower();

            if (continueStr == "yes")
            {
                CalculateRectangle();
            }
        }

        static double GetValidInput(string errorMessage)
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine(errorMessage);
            }
            return input;
        }
    }
}