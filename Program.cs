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

            //for branche work

            DifferenceElements differenceElements = new DifferenceElements();
            Console.WriteLine(differenceElements.Result(a, b));

            Console.ReadLine();
        }
    }
}
