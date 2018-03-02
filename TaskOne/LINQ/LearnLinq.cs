using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.LINQ
{
    class LearnLinq
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

            #region
            //Using Loop to fetch record in collection

            //Student[] students = new Student[10];

            //int i = 0;

            //foreach (Student std in studentArray)
            //{
            //    if (std.Age > 12 && std.Age < 20)
            //    {
            //        if (std.Age > -1)
            //        {
            //            students[i] = std;
            //        }
            //        i++;
            //    }
            //}

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Age);
            //}
            #endregion

            //Using LINQ to query number of Teenagers 
            var teenagerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20);
            foreach (var item in teenagerStudents)
            {
                Console.WriteLine(item.Age);
            }
            // Use LINQ to find first student whose name is Bill 
            var bill = studentArray.Where(s => s.StudentName.Contains("Bill"));
            foreach (var item in bill)
            {
                Console.WriteLine(item.StudentName);
            }

            //Accessing Default value
            Student student = new Student();
            Console.WriteLine(student.StudentID + student.StudentName + student);

            // Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine(student5.StudentName);
        }

        //neSTED CLASS  
        class Student
        {
            public int StudentID { get; set; } = -1;
            public String StudentName { get; set; } = "Name";
            public int Age { get; set; } = 5;
        }

    }

}
