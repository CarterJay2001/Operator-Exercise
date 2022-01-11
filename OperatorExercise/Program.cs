using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
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
