using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task
{
    class SecondDog
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            // var d = (SecondDog)obj;
            var d = obj as SecondDog;

            if(d?.Name == this.Name) // the question mark makes Name = null while empty
            {
                return true;
            }

            return false;
        }
    }
}
