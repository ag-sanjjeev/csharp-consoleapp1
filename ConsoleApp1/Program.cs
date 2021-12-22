using System;
//using System.Linq;
using Functionalities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTypes dt = new DataTypes("sanjjeev", 'm', 24, 12.34F, 34.45F, 564.454563D, 454.3424D, 234234.23424M, 23424.243234M, false);


            Console.WriteLine("\n------------------------------------\n");

            Strings st = new Strings("hello sanjjeev", "have a good day");


            Console.WriteLine("\n------------------------------------\n");

            UserInput ui = new UserInput();

            Console.WriteLine("\n------------------------------------\n");

            Arrays a = new Arrays();

            Console.WriteLine("\n-----------------------------------\n");

            GreetUser("sanjjeev"); // this should be call as method not as a function because oops concept play here

            Console.WriteLine("\nSquare of 5 : " + Square(5));

            Console.WriteLine("\n-----------------------------------\n");

            IfConditional ic = new IfConditional("india", 24);

            Console.WriteLine("\n-----------------------------------\n");

            SwitchStatement ss = new SwitchStatement();

            Console.WriteLine("\n-----------------------------------\n");

            Loopings l = new Loopings();

            Console.WriteLine("\n-----------------------------------\n");

            MultiDimensionalArray mda = new MultiDimensionalArray();

            Console.WriteLine("\n-----------------------------------\n");

            ExceptionHandling eh = new ExceptionHandling();

            Console.ReadKey();

        }

        static void GreetUser(string name) // method name should always start with upper case that is name rule
        {
            Console.WriteLine("\nMethod is initialized");
            Console.WriteLine("\nHello " + name);
        }

        static int Square(int num)
        {
            int result = num * num;
            return result;
        }
    }
}