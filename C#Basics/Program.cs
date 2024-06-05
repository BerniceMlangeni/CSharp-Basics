using System;

namespace Program
{
    internal class Basics
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Type in your name:");
            name = Console.ReadLine();

            Console.WriteLine( "Hello, " + name + "!");

        }
    }
}