using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Week5Task.Generic
{
    class ComplaintManager<String>
    {

        public Queue<string> _complaints = new Queue<string>();

     
        public void Insert(string complaint)
        {
            _complaints.Enqueue(complaint);
        }

        public string Remove()
        {
            return _complaints.Dequeue().ToString();
        }

        
    }
}
