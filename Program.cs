using System;
using TestPublic;

namespace TestCPC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestCPC test = new TestCPC();
            var s = test.SqRt(22);
            Console.WriteLine("SquareRoot of 22=" + s);
            Console.ReadLine();
        }
    }
}
