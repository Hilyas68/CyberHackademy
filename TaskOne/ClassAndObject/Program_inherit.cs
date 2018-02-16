using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();
            car.Reverse();
            car.Ignite();

            Truck truck = new Truck();
            truck.color = "Red";

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.color = "Black";

            Book book = new Book("Awake", "Bennedit", "09192991910wqw" );
            Console.WriteLine(book.ToString());

        }   
    }
}
