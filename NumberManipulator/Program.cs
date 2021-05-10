using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInt = 12;
            Console.WriteLine($"{myInt}");
            Console.WriteLine($"{(myInt * myInt) + 14 - 3}");
        }
    }
}
