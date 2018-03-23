using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskOne.Collections
{
    class Tester
    {
        public static void Main()
        {
            //var stopWatch = new Stopwatch();
            //.......................................................Non Generic Collections......................................................

                ArrayList arrayList = Collections.GetArrayList();

                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }

            Console.ReadLine();

            //Console.WriteLine("......................List......................");


            //List<Employee> list = Collections.GetGenericList();

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name}  {item.Age}");
            //}

            //Console.ReadLine();

            //Console.WriteLine("......................Non Generic Stack......................");

            //Stack mystack = Collections.GetNonGenericStack();

            //foreach (var item in mystack)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.ReadLine();

            //Console.WriteLine("......................Generic Stack......................");

            //Stack<Employee> stack = Collections.GetStack();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name}  {item.Age}");
            //}

            //Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("......................Non Generic Queue......................");
            //Queue myqueue = Collections.GetNonGenericQueue();

            //foreach (var item in myqueue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Element at the peek");
            //Console.WriteLine(myqueue.Peek());
            //Console.ReadLine();

            //Console.WriteLine("......................Generic Queue......................");

            //Queue<Employee> queue = Collections.GetQueue();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name}  {item.Age}");
            //}
            //Console.ReadLine();

            //Console.WriteLine("......................HashTable......................");
            //Hashtable hashtable  = Collections.GetHashtable();

            //foreach (var item in hashtable)
            //{
            //    Console.WriteLine(item.);
            //}
            //Console.ReadLine(); 

            //Console.WriteLine("......................Dictionary......................");

            //var dictionary = Collections.GetDictionary();
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();


            //.......................................................Generic Collections......................................................
}

        //public static void PrintMillSecond(long time) => Console.WriteLine($"{time}ms");
        
    }
    
}

