using System;

namespace CG_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the area of a rectangle");
            Console.Write("Please enter the length of the rectangle:  ");
            string length = Console.ReadLine();
            

            Console.Write("Please enter the width of the rectangle:  ");
            string width = Console.ReadLine();

            int area = Convert.ToInt32(length) * Convert.ToInt32(width);

            Console.WriteLine("The area of the rectangle is " + area + ".");
            Console.ReadLine();
        }
    }
}
