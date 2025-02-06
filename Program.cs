using System;

namespace TestGitHub
{
    public class Program
    {


        static void Main(string[] args)
        {
            SumElement sumElement = new SumElement();
            double a = 2;
            double b = 3;
            Console.WriteLine(sumElement.Result(a, b));

            double a2 = 22;
            double b2 = 23;
            Console.WriteLine(sumElement.Result(a2, b2));

            double a3 = 32;
            double b3 = 33;
            Console.WriteLine(sumElement.Result(a3, b3));

            Console.ReadLine();
        }
    }
}
