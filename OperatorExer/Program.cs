using System;
using System.ComponentModel.DataAnnotations;

namespace OperatorExer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your length?");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your width?");
            int width = int.Parse(Console.ReadLine());

            var areaRect = length * width;
            var perimeter = ((length * 2) + (width * 2));

            Console.WriteLine($"The permimeter of this object runs {perimeter} and has an area of {areaRect}");

            Console.WriteLine("What is the diameter of your circle?");
            var diameter = int.Parse(Console.ReadLine());

            var radius = diameter / 2;
            var pi = Math.PI;

            var areaOfCircle = pi * (radius * radius);

            Console.WriteLine($"The area of your circle is {areaOfCircle}");




        }
    }
}
