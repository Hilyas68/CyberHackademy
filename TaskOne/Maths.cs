using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class Maths
    {
        //private double firstVal, secondVal;

        //public Maths(double param1, double param2)
        //{
        //    param1 = firstVal;
        //    param2 = secondVal;
        //}

       public void Add(double a , double b)
        {
            Console.WriteLine($"Addition of {a} and {b} is {a + b}");

        }

        public void Subtract(double a, double b)
        {
            Console.WriteLine($"Subtraction of {a} and {b} is {a - b}");

        }

        public void Multiply(double a, double b)
        {
            Console.WriteLine($"Multiply of {a} and {b} is {a * b}");

        }

        public void Divide(double a, double b)
        {
            Console.WriteLine($"Division of {a} and {b} is {a / b}");

        }
    }
}
