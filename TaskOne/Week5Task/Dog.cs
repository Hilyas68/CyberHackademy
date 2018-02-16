using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task
{
    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Dog Moved");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog Speaks");
        }

        public override void ToString()
        {
            Console.WriteLine("Dog To String");
        }

        public override bool Equals(object obj)
        {
            var dog1 = new Dog();
            var dog2 = new Dog();
            return dog1 == dog2;
        }
    }
}
