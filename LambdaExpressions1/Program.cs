using System;

namespace LambdaExpressions1
{
    public delegate bool CompareDelegate(string a, string b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //сообщаем делегату compareDelegate лямда вырожение (x,y) => x==y
            CompareDelegate compareDelegate = (x,y) => x==y;

            bool result = compareDelegate("Hello","hello");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}