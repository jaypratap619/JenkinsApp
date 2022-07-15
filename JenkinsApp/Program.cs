using System;
using MathDLL;
namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            MyMaths m1 = new MyMaths(4, 5);
            Console.WriteLine(m1.Add());
            Console.WriteLine(m1.Multiply());
            Console.ReadLine();
        }
    }
}
