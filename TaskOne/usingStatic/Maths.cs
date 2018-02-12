using System;


namespace TaskOne.usingStatic
{
    public static class Maths
    {
       public static void Add(double a , double b)
        {
            Console.WriteLine($"Addition of {a} and {b} is {a + b}");

        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"Sutraction of {a} and {b} is {a - b}");

        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"Multiply of {a} and {b} is {a * b}");

        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine($"Division of {a} and {b} is {a / b}");

        }
    }
}
