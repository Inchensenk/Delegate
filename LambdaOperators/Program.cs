using System;

namespace LambdaOperators
{
    public delegate void HelloDelegate(string s);
    public class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate helloDelegate = (x) => { Console.WriteLine("Привет, " + x); };
            helloDelegate("Андрей");
        }
    }
}