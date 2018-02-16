using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task
{
    class SecondDog
    {
        private string name;

        public override bool Equals(object obj)
        {
            var dogA = new SecondDog();
            var dogB = new SecondDog();

            return dogA.name == dogB.name;
        }
    }
}
