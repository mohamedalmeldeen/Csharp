using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            byte age;
            Console.WriteLine("Enter Your Name Please:");
            name = Console.ReadLine();
            Console.WriteLine("and Enter Your age Please:");
            age = Convert.ToByte(Console.ReadLine()); 
            Console.WriteLine($"Welcome Mr. {name}, Your age is: {age}");

            /*int number = 5;
            string name = "Almeldeen20";
            name = "Mohamed";
            number = "5+3";
            string name = "Almeldeen20";
            byte age = 32;*/
            //Console.WriteLine("My Name is: " + name  + "and My Age is: " + age);
            //Console.Write("My Name is: {0}, and My Age is: {1}  and My Age is: " ,name,age);

            //string Interpolation
            //Console.Write($"My Name is: {name} and My Age is: {age}");


            Console.ReadKey();
        }
    }
}
