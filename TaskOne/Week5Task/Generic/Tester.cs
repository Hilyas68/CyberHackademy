using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task.Generic
{
    class Tester
    {
        public static void Main(String[] args)
        {   
            ComplaintManager<String> complaintManager = new ComplaintManager<String>();
            complaintManager.Insert("First In");
            complaintManager.Insert("Second In");
            complaintManager.Insert("Third In");

            foreach (var item in complaintManager._complaints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Remove section");
            Console.WriteLine(complaintManager.Remove());
        }
    }
}
