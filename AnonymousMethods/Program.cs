using System;

namespace AnonymousMethods
{
    public class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(delegate () { Console.WriteLine("Hello World!"); });

            myDelegate();// или myDelegate.Invoke()

            Console.ReadKey();
        }
    }
}