using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string myString = Console.ReadLine();
            int charPos = myString.IndexOf("a");
            string name = myString.Substring(charPos);
            Console.WriteLine(name);
        }
    }
}

