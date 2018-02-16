using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task
{
    class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Cat Moved");
        }

        public override void Speak()
        {
            Console.WriteLine("Cat Speaks");
        }

        public override void ToString()
        {
            Console.WriteLine("Cat ToString");
        }

    }
}
