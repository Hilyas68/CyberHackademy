using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task.Exercise7
{
    class Dog
    {
        public int _weight { get; set; }
        public string _name { get; set; }
        public Dog(string name, int weight)
        {
            this._name = name;
            this._weight = weight;
        }
            
    }

    class Tester
    {
        public static void Main()
        {
            Dog[] dogs =
            {
                new Dog("Milo", 26),
                new Dog("Frisky", 10),
                new Dog("Laika", 50)
            };

            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog._name} : {dog._weight}");
            }
        }
    }
}
