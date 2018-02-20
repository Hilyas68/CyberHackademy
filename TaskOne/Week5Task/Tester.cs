using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task
{
   public class Tester
    {
        public static void Main(String[] args)
        {
            Animal[] animals =
            {
                new Cat(),
                new Dog()

            };

            foreach (var animal in animals)
            {
                animal.Move();
                animal.Speak();
                animal.ToString();
               
            }

            Console.ReadLine();

            var dog = new SecondDog { Name = "Hassan" };
            var dog1 = new SecondDog { Name = "Hassan" };

            if (dog.Equals(dog1))
            {
                Console.WriteLine("Dogs are Equal");
            }
            else
            {
                Console.WriteLine("Dogs are not Equal");
            }



        }
    }
}
