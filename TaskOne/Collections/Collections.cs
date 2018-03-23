using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.Collections
{
    class Collections
    {
        //........................................Non Generic................................................

        public static ArrayList GetArrayList()
        {
            ArrayList arrayList = new ArrayList()
            {
                new {Id = 1, Name = "Oriahi Emmanuel", Age = 50, Department = "CyberSoft"},
                false,
                553,
                "String",
                'C',
                39.04,
                new {Name = "Lasisi", Profession = "Software Engineer"}
            };


            arrayList.Add(new Employee { Id = 5, Name = "Mabi Chuks", Age = 50, Department = "NOC" });

            return arrayList;
        }

        public static Stack GetNonGenericStack()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(false);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push('c');
            //int myInt = (int)myStack.Pop();
            return myStack;
        }

        public static Queue GetNonGenericQueue()
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("Hello!!");
            myQueue.Enqueue(null);
            myQueue.Enqueue(false);
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue('s');

            return myQueue;
        }

        
        public static Hashtable GetHashtable()
        {
            var hashtable = new Hashtable
            {
                { "EmployeeOne", new { Id = 1, Name = "Ochiaka Okey", Age = 53, Department = "NOC" } },
                { "EmployeeTwo", new { Id = 2, Name = "Gaby Olowoniwa", Age = 30, Department = "CyberSoft" } },
                { "EmployeeThree", new { Id = 3, Name = "Oriahi Emmanuel", Age = 40, Department = "CyberSoft" } },
                { "EmployeeFour", new { Id = 4, Name = "OSezuah Ofure", Age = 40, Department = "CyberSoft" } },
                { 'e', new { Id = 5, Name = "Mabi Chuks", Age = 50, Department = "NOC" } },
                { "Group Number", 2 },
                { true, "Group TWo" },
                { 6, "Data Structure" }
            };

            return hashtable;
        }

        //........................................Generic..........................................................................

        public static List<Employee> GetGenericList()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee{Id = 1, Name = "Oriahi Emmanuel", Age = 50, Department = "CyberSoft"},
                new Employee{Id = 2, Name = "Gaby Olowoniwa", Age = 30, Department = "CyberSoft"},
                new Employee{Id = 3, Name = "Ochiaka Okey", Age = 53, Department = "NOC"},
                new Employee{Id = 4, Name = "OSezuah Ofure", Age = 40, Department = "CyberSoft"},
                new Employee{Id = 5, Name = "Mabi Chuks", Age = 50, Department = "NOC"},
            };

            list.Add(new Employee { Id = 5, Name = "Mabi Chuks", Age = 50, Department = "NOC" });

            list.RemoveAt(0);

            return list;
        }

        public static Stack<Employee> GetStack()
        {
            Stack<Employee> employee = new Stack<Employee>();
            employee.Push(new Employee { Id = 1, Name = "Ochiaka Okey", Age = 53, Department = "NOC" });
            employee.Push(new Employee { Id = 2, Name = "Gaby Olowoniwa", Age = 30, Department = "CyberSoft" });
            employee.Push(new Employee { Id = 3, Name = "Oriahi Emmanuel", Age = 40, Department = "CyberSoft" });
            employee.Push(new Employee { Id = 4, Name = "OSezuah Ofure", Age = 40, Department = "CyberSoft" });
            employee.Push(new Employee { Id = 5, Name = "Mabi Chuks", Age = 50, Department = "NOC" });

            employee.Pop();
            employee.Peek();
            
            return employee;
        }

        public static Queue<Employee> GetQueue()
        {
            Queue<Employee> employee = new Queue<Employee>();
            employee.Enqueue(new Employee { Id = 1, Name = "Ochiaka Okey", Age = 53, Department = "NOC" });
            employee.Enqueue(new Employee { Id = 2, Name = "Gaby Olowoniwa", Age = 30, Department = "CyberSoft" });
            employee.Enqueue(new Employee { Id = 3, Name = "Oriahi Emmanuel", Age = 40, Department = "CyberSoft" });
            employee.Enqueue(new Employee { Id = 4, Name = "OSezuah Ofure", Age = 40, Department = "CyberSoft" });
            employee.Enqueue(new Employee { Id = 5, Name = "Mabi Chuks", Age = 50, Department = "NOC" });

            employee.Dequeue();
            employee.Peek();
            
            return employee;
        }

        public static Dictionary<string, Employee> GetDictionary()
        {
           var dictionary = new Dictionary<string, Employee>();
            dictionary.Add("Employee one", new Employee{ Id = 1, Name = "Ochiaka Okey", Age = 53, Department = "NOC" });
            dictionary.Add("Employee two", new Employee { Id = 2, Name = "Gaby Olowoniwa", Age = 30, Department = "CyberSoft" });
            dictionary.Add("Employee three", new Employee { Id = 3, Name = "Oriahi Emmanuel", Age = 40, Department = "CyberSoft" });
            dictionary.Add("Employee four", new Employee { Id = 4, Name = "OSezuah Ofure", Age = 40, Department = "CyberSoft" });
            dictionary.Add("Employee five", new Employee { Id = 5, Name = "Mabi Chuks", Age = 50, Department = "NOC" });

            return dictionary;
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
    }   
}
