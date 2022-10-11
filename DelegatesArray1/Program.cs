using System;

namespace DelegatesArray1
{
    public delegate void MyDelegate(string s);
    internal class Program
    {
        private static void SayHello(string str)
        {
            Console.WriteLine("Hello, "+str);
        }

        private static void SayGoodbye(string str)
        {
            Console.WriteLine("Goodbye, " + str);
        }

        private static void AskHowAreYou(string str)
        {
            Console.WriteLine($"How Are You, {str}?");
        }

        static void Main(string[] args)
        {
            //инициализация с помощью ссылок на методы
            /*MyDelegate[] methodsArray = new MyDelegate[]
            {
                SayHello, SayGoodbye, AskHowAreYou
            };*/

            //инициализация с помощью анонимных методов
            MyDelegate[] methodsArray = new MyDelegate[]
            {
                //анонимный метод
                delegate (string s)
                {
                    Console.WriteLine($"Hello, {s}");
                },

                //лямбда оператор
                (s) =>
                {
                    Console.WriteLine($"Goodbye, {s}");
                },

                //выражение лямбда
                (s)=>Console.WriteLine($"How Are You, {s}?")
            };
         

            for (int i = 0; i < methodsArray.Length; i++)
            {
                methodsArray[i](Convert.ToString(i));
            }

            Console.ReadKey();
        }
    }
}