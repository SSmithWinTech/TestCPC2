using System;
using TestMyCPC;

namespace TestCPC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestMyCPC.MyCPCClass test = new TestMyCPC.MyCPCClass();
            var s = test.SqRt(22);
            //test.API_FILEOPEN()
            Console.WriteLine("SquareRoot of 22=" + s);
            Console.Write("Take the square root of: ");
            var a = Console.ReadLine();
            var b = Double.Parse(a);
            s = test.SqRt(b);
            Console.WriteLine("SquareRoot of "+ a +"=" + s);

        }
    }
}
