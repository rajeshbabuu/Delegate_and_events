using System;

namespace DelegateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Delegate Demo");
            Operation obj = new Operation(Demo.Addition);
            //Console.WriteLine("Addition is = {0}",obj(23,27));
            MulticastDelegate.ImplementDelegate();
            Console.ReadKey();
        }
    }
}