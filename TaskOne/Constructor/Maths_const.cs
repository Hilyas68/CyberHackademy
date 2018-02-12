using System;


namespace TaskOne.Constructor
{
    public class Maths
    {
        private double firstVal, secondVal;
        public  Maths(double firstVal, double secondVal)
        {
            this.firstVal = firstVal;
            this.secondVal = secondVal;
        }


       public void Add()
        {
            Console.WriteLine($"Addition of {firstVal} and {secondVal} is {secondVal + firstVal}");

        }

        public void Subtract()
        {
            Console.WriteLine($"Subtraction of {firstVal} and {secondVal} is {secondVal - firstVal}");

        }

        public void Multiply()
        {
            Console.WriteLine($"Multiply of {firstVal} and {secondVal} is {secondVal * firstVal}");

        }

        public void Divide()
        {
            Console.WriteLine($"Division of {firstVal} and {secondVal} is {secondVal / firstVal}");

        }
    }
}
