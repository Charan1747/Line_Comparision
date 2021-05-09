using System;

namespace LineComparisionProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Values of X1,X2,Y1,Y2:");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X1 is: " + X1 + "\t X2 is: " + X2 + "\tY1 is: " + Y1 + "\tY2 is: " + Y2);
            double Length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Your Length is: " + Length);
            Console.ReadKey();
        }
    }
}
