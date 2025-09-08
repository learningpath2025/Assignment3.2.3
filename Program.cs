/*
Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.
*/

namespace Assignment3._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("Enter radius of first circle:");
            circle.Radius = Convert.ToDouble(Console.ReadLine());
            Circle circle2 = new Circle();
            Console.WriteLine("Enter radius of second circle:");
            circle2.Radius = Convert.ToDouble(Console.ReadLine());
            double areaSum = circle + circle2;
            double areaDiff = circle - circle2;
            Console.WriteLine($"Sum of areas: {areaSum}");
            Console.WriteLine($"Difference of areas: {areaDiff}");
            Console.ReadLine();
            

        }

        

    }
}
