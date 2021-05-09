using System;

namespace LineComparisionProblems
{
    class Program
    {
        int X1, X2, Y1, Y2;
        double Length;
        public void Coordinates()
        {
            Console.WriteLine("Enter your X1,X2,Y1,Y2:");
            X1 = Convert.ToInt32(Console.ReadLine());
            X2 = Convert.ToInt32(Console.ReadLine());
            Y1 = Convert.ToInt32(Console.ReadLine());
            Y2 = Convert.ToInt32(Console.ReadLine());
        }

        public double CalCulate(int X1, int X2, int Y1, int Y2)
        {
            Length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            return Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparision Problem");
            Program lobject = new Program();
            Console.WriteLine("Enter The First Line Co-Ordinates: ");
            lobject.Coordinates();
            lobject.CalCulate(lobject.X1, lobject.X2, lobject.Y1, lobject.Y2);
            double Length_of_First_Line = lobject.Length;
            Console.WriteLine("Enter The Second Line Co-Ordinates: ");
            lobject.Coordinates();
            lobject.CalCulate(lobject.X1, lobject.X2, lobject.Y1, lobject.Y2);
            double Length_of_Second_Line = lobject.Length;

            if (Length_of_First_Line == Length_of_Second_Line)
            {
                Console.WriteLine("Two lines are Equal");
            }
            else
            {
                Console.WriteLine("Two lines are Not Equal");
            }
        }
    }
}
