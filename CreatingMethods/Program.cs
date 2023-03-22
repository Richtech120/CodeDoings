using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CreatingMethods
{
    internal class Program
    {

        static void NewGreating(string name, int number)
        {
            Console.WriteLine($"Hello and welcome {name}, your number is {number}");
            Console.WriteLine($"Hi, My name is {name}, i am {number} years old");
        }
        public static void Main(string[] args)
        {
            //NewGreating("Jane", 69);
            //NewGreating("Daniel", 45);

           // Console.WriteLine("See how to create a user function:");
           // NewWay1();
            //NewWay2(38);


            //int counting = 30;
            //string newResult = (counting > 25) ? "True" : "False";
            //Console.WriteLine(newResult);


            int CreditUsub1 = 2;
            Console.WriteLine("What is your English score? ");
            string score = Console.ReadLine();
            int Result = Convert.ToInt32(CreditUsub1 + score);
            Console.WriteLine(Result);
            
            




            Console.ReadLine();
        }
        static void nam1 (string nam1)
        {
            Console.WriteLine(nam1);
            Console.WriteLine(Console.ReadLine());
        }

        public static void NewWay1(string name = "John")
        {
            Console.WriteLine($"Welcome Friend {name}");
        }
        public static void NewWay2(int age)
        {
            Console.WriteLine($"I am {age} years old");
        }

        

    }
}
