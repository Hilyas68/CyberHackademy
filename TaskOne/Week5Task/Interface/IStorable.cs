using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task.Interface
{
    interface IStorable
    {
        void Read(string item);

        void Write (string storeHouse);
    }
}
