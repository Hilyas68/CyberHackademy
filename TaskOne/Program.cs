using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, This is a Simple Calculator that Add, Subtract, Multiply and Divide.two values");

            label:
            Console.WriteLine("Enter first Value");
            double firstVal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Value");
            double secondVal = double.Parse(Console.ReadLine());

            Maths calculate = new Maths();
            calculate.Add(firstVal, secondVal);
            calculate.Subtract(firstVal, secondVal);
            calculate.Multiply(firstVal, secondVal);
            calculate.Divide(firstVal, secondVal);

            int e = 1;
            Console.WriteLine("Do you want to perform another task: enter 1 - Yes, 2 - No ");
            int input = int.Parse(Console.ReadLine());

            while(e == 1)
            {
                if(input == 1)
                {
                    goto label;
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
