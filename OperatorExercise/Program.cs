using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 8;
            int add = a + b;

            if (a == 7 && b == 8)
            {
                Console.WriteLine($"{a}+{b} is {add}");
            }

            int c = 23;
            int d = 7;
            int sub = c - d;

            if (c == 23 && d == 7)
            {
                Console.WriteLine($"{c}-{d} is {sub}");
            }

            int e = 3;
            int f = 12;
            int mult = e * f;

            if (e == 3 && f == 12)
            {
                Console.WriteLine($"{e}*{f} is {mult}");
            }

            int g = 17;
            int h = 4;
            int quotient = g / h;
            int remainder = g % h;

            if (g == 17 && h == 4)
            {
                Console.WriteLine($"{g}/{h} is {quotient} remainder {remainder}");
            }


            Console.WriteLine("\nWhat is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double answer = AreaOfCircle(radius);
            Console.WriteLine($"\nThe area of a circle with a radius of {radius} is {answer}");
        }

        public static double AreaOfCircle(double radius)
        {
            double answer = Math.PI * radius * radius;

            return answer;
        }
    }
}
