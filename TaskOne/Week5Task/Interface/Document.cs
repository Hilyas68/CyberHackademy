using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task.Interface
{
    class Document : IStorable, IPrintable
    {
        public void ExportTo(string storeHouse)
        {
            Console.WriteLine($"Exporting {storeHouse} to Drop Box");
        }

        public void Print(string item)
        {
            throw new NotImplementedException();
        }

        public void Read(string item)
        {
            throw new NotImplementedException();
        }

        public void Write(string storeHouse)
        {
            Console.WriteLine($"Writing {storeHouse} to Cloud");
        }
    }
}
