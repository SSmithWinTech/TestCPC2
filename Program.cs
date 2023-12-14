using System;
using TestPublic;

namespace TestCPC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestPublic.TestCPC test = new TestPublic.TestCPC();
            var s = test.SqRt(22);
            Console.WriteLine("SquareRoot of 22=" + s);
            Console.ReadLine();
        }
    }
}
