using System;
using System.Reflection.Metadata;

namespace DelegateMethod
{
    public delegate string HelloDelegate(string name);

    class SomeClass
    {
        public string SayHello(string s)
        {
            return $"Привет, {s}";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();

            //Сообщаем делегат helloDelegate с методом SayHello
            HelloDelegate helloDelegate = new HelloDelegate(someClass.SayHello);
            
            //Вывод на консоль результат вызова делегата//

            //короткая запись
            Console.WriteLine(helloDelegate("ПЕТР"));

            //длинная запись
            Console.WriteLine(helloDelegate.Invoke("ПЕТР"));

            Console.ReadKey();
        }
    }
}