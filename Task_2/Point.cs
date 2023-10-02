using System;

namespace Task_2
{
    class Point
    {
        public double X { get; }
        public double Y { get; }
        public string Label { get; }

        public Point(double x, double y, string label)
        {
            X = x;
            Y = y;
            Label = label;
        }
    }
}