using System;

namespace Task_2
{
    class Figure
    {
        public double Perimeter { get; private set; }
        public string FigureType { get; private set; }

        private Point[] points;

        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                throw new ArgumentException("A figure must have 3 to 5 points.");
            }

            this.points = points;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                Point currentPoint = points[i];
                Point nextPoint = points[(i + 1) % points.Length];

                double sideLength = GetSideLength(currentPoint, nextPoint);
                perimeter += sideLength;
            }

            Perimeter = perimeter;
            FigureType = GetFigureType();

            return perimeter;
        }

        private double GetSideLength(Point A, Point B)
        {
            double sideLength = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return sideLength;
        }

        private string GetFigureType()
        {
            switch (points.Length)
            {
                case 3:
                    return "Triangle";
                case 4:
                    return "Quadrilateral";
                case 5:
                    return "Pentagon";
                default:
                    return "Unknown";
            }
        }
    }
}