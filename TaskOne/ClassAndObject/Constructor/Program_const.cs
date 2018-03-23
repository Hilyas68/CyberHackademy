using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Constructor
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, This is a Simple Calculator that Add, Subtract, Multiply and Divide.two values");
            

                label:
                Console.WriteLine("Enter first Value");
                double firstVal = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter first Value");
                double secondVal = double.Parse(Console.ReadLine());

                Maths calculate = new Maths(firstVal, secondVal);
                calculate.Add();
                calculate.Subtract();
                calculate.Multiply();
                calculate.Divide();

            int e = 1;
                
            end:
                Console.WriteLine("Do you want to perform another task: enter 1 - Yes, 2 - No ");
                int input = int.Parse(Console.ReadLine());

            try
            {

                while (e == 1)
                {
                    if (input == 1)
                    {
                        goto label;
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong Input");
            }

            goto end;
        }
    }
}
