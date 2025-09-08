using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._3
{
    internal class Circle
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        // Overloading the + operator to add areas of two circles
        public static double operator +(Circle c1, Circle c2)
        {
            return c1.Area() + c2.Area();
        }
        // Overloading the - operator to get the area difference of two circles
        public static double operator -(Circle c1, Circle c2)
        {
            return Math.Abs(c1.Area() - c2.Area());
        }
    }
}
