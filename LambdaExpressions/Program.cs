using System;

namespace LambdaExpressions
{
    public delegate void HelloDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            //сообщаем делегату helloDelegate лямда выражение () => Console.WriteLine("Hello Vasya!")
            HelloDelegate helloDelegate = () => Console.WriteLine("Hello Vasya!");
            helloDelegate();//или helloDelegate.Invoke();

            Console.ReadKey();
        }
    }
}