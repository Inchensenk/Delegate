using System;

namespace AnonymousMethods1
{
    public class Program
    {
        public delegate int AddDelegate(int a, int b);
        static void Main(string[] args)
        {
            AddDelegate addDelegate = new AddDelegate(delegate (int number1, int number2) 
            { 
                int result = number1 + number2;
                return result;
            });

            int summ = addDelegate(10,26);
            Console.WriteLine(summ);
            Console.ReadKey();
        }
    }
}